using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace LogiS
{
    class ClassRecette: ClassGen
    {
        #region Attributs
        int idrecette;
        #endregion
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Annuler(FormRecetteNew r)
        {
            r.dtpDate.ResetText();
            r.txtMontant.Clear();
            r.txtLibelle.Clear();
            r.txtFichier.Clear();
            r.txtPayeur.Clear();
            r.btnModifier.Enabled = false;
            r.txtMontant.Focus();
        }
        public void Afficher(FormRecette r, string motif)
        {
            con.Close();
            try
            {
                if (motif == "recherche")
                {
                    cmdtxt = @"SELECT idrecette, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Recette WHERE date_jour BETWEEN @dateDe AND @dateA AND idcaisse = " + r.idcaisse + "";
                }
                else if (motif == "min")
                    cmdtxt = @"SELECT idrecette, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Recette WHERE montant >= '" + Convert.ToDouble(r.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND idcaisse = " + r.idcaisse + "";
                else if (motif == "max")
                    cmdtxt = @"SELECT idrecette, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Recette WHERE montant <= '" + Convert.ToDouble(r.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND idcaisse = " + r.idcaisse + "";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", r.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", r.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                r.dgvRecette.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void SelectionDGV(FormRecette r)
        {
            if (r.dgvRecette.RowCount != 0)
            {
                idrecette = Convert.ToInt32(r.dgvRecette.CurrentRow.Cells[0].Value);
                r.btnVoir.Enabled = true;
                r.btnModifier.Enabled = true;
                r.btnSupprimer.Enabled = true;
                if(r.poste=="tresorerie")
                    r.btnMessage.Enabled = true;
            }
        }
        
        ClassMessagerie msg = new ClassMessagerie();
        public void VoirFichier()
        {
            OuvrirFichier(idrecette, "recette");
        }
        private void AjouterPayementClient(FormRecetteNew r)
        {
            idrecette = NouveauID("payementclient");
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("INSERT INTO PayementClient VALUES (@id, @idclient, @libelle, @date_jour, @montant)", con);
                cmd.Parameters.AddWithValue("@id", idrecette);
                cmd.Parameters.AddWithValue("@idclient", r.idclient);
                cmd.Parameters.AddWithValue("@libelle", r.txtLibelle.Text);
                cmd.Parameters.AddWithValue("@date_jour", r.dtpDate.Text);
                cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(r.txtMontant.Text));

                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public bool AjouterRecette(string date_jour, string txtFichier, string montant, string libelle, int idcaisse)
        {
            bool cmdstate = false;
            idrecette = NouveauID("recette");
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                if (txtFichier != "")
                {
                    using (Stream stream = File.OpenRead(txtFichier))
                    {
                        //binarisation du fichier preuve
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        var fichier = new FileInfo(txtFichier);
                        string ext = fichier.Extension;
                        string nomfichier = fichier.Name;
                        cmd = new SqlCommand("INSERT INTO Recette VALUES (@id, @date_jour, @montant, @libelle, @fichier, @nomficher, @ext, @statut,@idcaisse)", con);
                        cmd.Parameters.AddWithValue("@fichier", buffer);
                        cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                        cmd.Parameters.AddWithValue("@ext", ext);
                    }
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Recette (idrecette, date_jour, montant, libelle, statut,idcaisse) VALUES (@id, @date_jour, @montant, @libelle, @statut,@idcaisse)", con);
                }
                cmd.Parameters.AddWithValue("@id", idrecette);
                cmd.Parameters.AddWithValue("@date_jour", date_jour);
                cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(montant));
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cmd.Parameters.AddWithValue("@statut", "RAS");
                cmd.Parameters.AddWithValue("@idcaisse", idcaisse);

                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                cmdstate = true;
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return cmdstate;
        }
        public void AjouterRecette(FormRecetteNew r)
        {
            if (r.txtMontant.Text != "" && r.txtLibelle.Text != "" && r.txtPayeur.Text != "")
            {
                //enregistrement
                if(AjouterRecette(r.dtpDate.Text, r.txtFichier.Text, r.txtMontant.Text, r.txtLibelle.Text, r.idcaisse))
                {
                    MessageBox.Show("Ajouté avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenererBon(r, new FormImpression());
                }
                if (r.recetteclient)
                    AjouterPayementClient(r);
                Annuler(r);                               
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormRecetteNew r)
        {
            if (r.txtMontant.Text != "" && r.txtLibelle.Text != "" && r.txtPayeur.Text != "")
            {
                //mise à jour
                idrecette = Convert.ToInt32(r.Text.Substring(0, r.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (r.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(r.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(r.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;

                            cmdtxt = @"UPDATE Recette SET date_jour = @date_jour, montant = @montant,
                            libelle = @libelle, fichier = @fichier, nomfichier = @nomficher, 
                            extfichier = @ext WHERE idrecette = @id";
                            cmd = new SqlCommand(cmdtxt, con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);

                        }
                    }
                    else
                    {
                        cmdtxt = @"UPDATE Recette SET date_jour = @date_jour, montant = @montant,
                            libelle = @libelle WHERE idrecette = @id";
                        cmd = new SqlCommand(cmdtxt, con);
                    }
                    cmd.Parameters.AddWithValue("@id", idrecette);
                    cmd.Parameters.AddWithValue("@date_jour", r.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(r.txtMontant.Text));
                    cmd.Parameters.AddWithValue("@libelle", r.txtLibelle.Text);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenererBon(r, new FormImpression());
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                Annuler(r);                              
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormRecette r)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE FROM Recette WHERE idrecette = @id", con);
                cmd.Parameters.AddWithValue("@id", idrecette);
                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            r.btnSupprimer.Enabled = false;
            r.dgvRecette.Rows.RemoveAt(r.dgvRecette.CurrentRow.Index);
        }
        public string Valeur(int id, string objet)
        {
            return TrouverAttribut(id, objet);
        }
        public string Solde(int idcaisse)
        {
            return SoldeCaisse(idcaisse).ToString("0.00");
        }
        
        ReportDataSource rs = new ReportDataSource();
        private void GenererBon(FormRecetteNew r, FormImpression imp)
        {
            imp.Text = "Recette - LogiS";
            
            ReportParameter[] rparams = new ReportParameter[]
            {
                    new ReportParameter("id", idrecette.ToString()),
                    new ReportParameter("payeur", r.txtPayeur.Text),
                    new ReportParameter("montant", r.txtMontant.Text),
                    new ReportParameter("montantlettre", ConvertirEnLettres(r.txtMontant)),
                    new ReportParameter("date_jour", r.dtpDate.Text),
                    new ReportParameter("libelle", r.txtLibelle.Text),
            };

            imp.reportViewer1.LocalReport.DataSources.Clear();
            imp.reportViewer1.LocalReport.ReportEmbeddedResource = "LogiS.rpRecette.rdlc";
            imp.reportViewer1.LocalReport.SetParameters(rparams);
            imp.MaximumSize = imp.Size;
            imp.MaximizeBox = false;
            imp.MinimizeBox = false;
            imp.ShowDialog();
        }

        public void SignalerAdmin(int id, int expediteur)
        {
            MessageAdmin(id, expediteur, "recette");
        }
        public void Cloturer()
        {
            ClotureRecette();
        }
    }
}
