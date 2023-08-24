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
    class ClassDepense: ClassGen
    {
        int iddepense;
        #region Operations
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Annuler(FormDepenseNew d)
        {
            d.dtpDate.ResetText();
            d.txtMontant.Clear();
            d.txtLibelle.Clear();
            d.txtFichier.Clear();
            d.txtBeneficiaire.Clear();
            d.btnModifier.Enabled = false;
            d.txtMontant.Focus();
        }
        private void AjouterPayementFour(FormDepenseNew r)
        {
            //enregistrement
            iddepense = NouveauID("payementfour");
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("INSERT INTO PayementFournisseur VALUES (@id, @idfour, @libelle, @date_jour, @montant)", con);
                cmd.Parameters.AddWithValue("@id", iddepense);
                cmd.Parameters.AddWithValue("@idfour", r.idfour);
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
        public bool AjouterDepense(string date_jour, string txtFichier, string montant, string libelle, int idcaisse)
        {
            bool cmdstate = false;
            iddepense = NouveauID("depense");
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

                        cmd = new SqlCommand("INSERT INTO Depense VALUES (@id, @date_jour, @montant, @libelle, @fichier, @nomficher, @ext, @statut,@idcaisse)", con);
                        cmd.Parameters.AddWithValue("@fichier", buffer);
                        cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                        cmd.Parameters.AddWithValue("@ext", ext);
                    }
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Depense (iddepense, date_jour, montant, libelle, statut,idcaisse) VALUES (@id, @date_jour, @montant, @libelle, @statut,@idcaisse)", con);
                }
                cmd.Parameters.AddWithValue("@id", iddepense);
                cmd.Parameters.AddWithValue("@date_jour", date_jour);
                cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(montant));
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cmd.Parameters.AddWithValue("@statut", "RAS");
                cmd.Parameters.AddWithValue("@idcaisse", idcaisse);

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
            return cmdstate; 
        }
        public void AjouterDepense(FormDepenseNew d)
        {
            if (d.txtMontant.Text != "" && d.txtLibelle.Text != "" && d.txtBeneficiaire.Text != "")
            {
                //enregistrement
                if(AjouterDepense(d.dtpDate.Text, d.txtFichier.Text, d.txtMontant.Text, d.txtLibelle.Text, d.idcaisse))
                {
                    MessageBox.Show("Ajouté avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenererBon(d, new FormImpression());
                }
                if (d.depensefour)
                    AjouterPayementFour(d);
                Annuler(d);                
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormDepenseNew d)
        {
            if (d.txtMontant.Text != "" && d.txtLibelle.Text != "" && d.txtBeneficiaire.Text != "")
            {
                iddepense = Convert.ToInt32(d.Text.Substring(0, d.Text.IndexOf("-")));
                //mise à jour
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (d.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(d.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(d.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;

                            cmdtxt = @"UPDATE Depense SET date_jour = @date_jour, montant = @montant,
                            libelle = @libelle, fichier = @fichier, nomfichier = @nomficher, 
                            extfichier = @ext WHERE iddepense = @id";
                            cmd = new SqlCommand(cmdtxt, con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                        }
                    }
                    else
                    {
                        cmdtxt = @"UPDATE Depense SET date_jour = @date_jour, montant = @montant,
                            libelle = @libelle WHERE iddepense = @id";
                        cmd = new SqlCommand(cmdtxt, con);
                    }
                    cmd.Parameters.AddWithValue("@id", iddepense);
                    cmd.Parameters.AddWithValue("@date_jour", d.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@libelle", d.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(d.txtMontant.Text));
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenererBon(d, new FormImpression());
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                Annuler(d);                
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormDepense d)
        {
            d.btnSupprimer.Enabled = false;
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE FROM Depense WHERE iddepense = @id", con);
                cmd.Parameters.AddWithValue("@id", iddepense);
                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.dgvDepense.Rows.RemoveAt(d.dgvDepense.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void Afficher(FormDepense d, string motif)
        {
            con.Close();
            try
            {
                if (motif == "recherche")
                {
                    cmdtxt = @"SELECT iddepense, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Depense WHERE date_jour BETWEEN @dateDe AND @dateA AND idcaisse = "+d.idcaisse+"";
                }
                else if (motif == "min")
                    cmdtxt = @"SELECT iddepense, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Depense WHERE montant >= '" + Convert.ToDouble(d.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND idcaisse = " + d.idcaisse + "";
                else if (motif == "max")
                    cmdtxt = @"SELECT iddepense, date_jour, montant, libelle, nomfichier, 
                    extfichier, statut FROM Depense WHERE montant <= '" + Convert.ToDouble(d.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND idcaisse = " + d.idcaisse + "";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", d.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", d.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                d.dgvDepense.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public string Valeur(int id, string objet)
        {
            return TrouverAttribut(id, objet);
        }
        public void SelectionDGV(FormDepense d)
        {
            if (d.dgvDepense.RowCount != 0)
            {
                iddepense = Convert.ToInt32(d.dgvDepense.CurrentRow.Cells[0].Value);
                d.btnVoir.Enabled = true;
                d.btnModifier.Enabled = true;
                d.btnSupprimer.Enabled = true;
                if (d.poste == "tresorerie")
                    d.btnMessage.Enabled = true;                 
            }
        }

        ClassMessagerie msg = new ClassMessagerie();

        public void SignalerAdmin(int id, int expediteur)
        {
            MessageAdmin(id, expediteur, "dépense");
        }
        public string Solde(int idcaisse)
        {
            return SoldeCaisse(idcaisse).ToString("0.00");
        }
        public void VoirFichier()
        {
            OuvrirFichier(iddepense, "depense");
        }
        private void GenererBon(FormDepenseNew r, FormImpression imp)
        {
            imp.Text = "Depense - LogiS";

            ReportParameter[] rparams = new ReportParameter[]
            {
                    new ReportParameter("id", iddepense.ToString()),
                    new ReportParameter("beneficiaire", r.txtBeneficiaire.Text),
                    new ReportParameter("montant", r.txtMontant.Text),
                    new ReportParameter("montantlettre", ConvertirEnLettres(r.txtMontant)),
                    new ReportParameter("date_jour", r.dtpDate.Text),
                    new ReportParameter("libelle", r.txtLibelle.Text),
            };

            imp.reportViewer1.LocalReport.DataSources.Clear();
            imp.reportViewer1.LocalReport.ReportEmbeddedResource = "LogiS.rpDepense.rdlc";
            imp.reportViewer1.LocalReport.SetParameters(rparams);
            imp.MaximumSize = imp.Size;
            imp.MaximizeBox = false;
            imp.MinimizeBox = false;
            imp.ShowDialog();
        }
        public void Cloturer()
        {
            ClotureDepense();
        }
        #endregion
    }
}
