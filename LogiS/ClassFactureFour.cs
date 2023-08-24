
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LogiS
{
    class ClassFactureFour: ClassGen
    {
        int idfacture;
        //Opérations
        public void Annuler(FormFactureNew f)
        {
            f.dtpDate.ResetText();
            f.dtpTerme.ResetText();
            f.txtMontant.Clear();
            f.txtRemise.Clear();
            f.txtLibelle.Clear();
            f.txtFichier.Clear();
            f.dtpDate.Select();
        }
        public void Enregistrer(FormFactureNew f)
        {
            if (f.txtFournisseur.Text != "" && f.txtMontant.Text != "" && f.txtRemise.Text != "" && f.txtLibelle.Text != "")
            {
                //enregistrement
                idfacture = NouveauID("facturefour");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (f.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(f.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(f.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;
                            cmd = new SqlCommand("INSERT INTO FactureFournisseur VALUES (@id, @idfour, @libelle, @date_facture, @date_terme, @montant, @remise, @fichier, @nomficher, @ext)", con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                        }
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO FactureFournisseur VALUES (@id, @idfour, @libelle, @date_facture, @date_terme, @montant, @remise)", con);
                    }
                    cmd.Parameters.AddWithValue("@id", idfacture);
                    cmd.Parameters.AddWithValue("@idfour", idfacture);
                    cmd.Parameters.AddWithValue("@libelle", f.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@date_facture", f.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@date_terme", f.dtpTerme.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(f.txtMontant));
                    cmd.Parameters.AddWithValue("@remise", Convert.ToDouble(f.txtRemise));

                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Ajouté avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                Annuler(f);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormFactureNew f)
        {
            if (f.txtFournisseur.Text != "" && f.txtMontant.Text != "" && f.txtRemise.Text != "" && f.txtLibelle.Text != "")
            {
                //enregistrement
                idfacture = Convert.ToInt32(f.Text.Substring(0, f.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (f.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(f.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(f.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;
                            cmd = new SqlCommand("UPDATE FactureFournisseur SET idfour = @idfour, libelle = @libelle, date_facture = @date_facture, date_terme = @date_terme, montant = @montant, remise = @remise, fichier = @fichier, nomfichier = @nomficher, extfichier = @ext WHERE idfacture = @id", con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                        }
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE FactureFournisseur SET idfour = @idfour, libelle = @libelle, date_facture = @date_facture, date_terme = @date_terme, montant = @montant, remise = @remise WHERE idfacture = @id", con);
                    }
                    cmd.Parameters.AddWithValue("@id", idfacture);
                    cmd.Parameters.AddWithValue("@idfour", idfacture);
                    cmd.Parameters.AddWithValue("@libelle", f.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@date_facture", f.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@date_terme", f.dtpTerme.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(f.txtMontant));
                    cmd.Parameters.AddWithValue("@remise", Convert.ToDouble(f.txtRemise));

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
                Annuler(f);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Annuler(f);
        }
        public void Supprimer(FormFacture f)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE FROM FactureFournisseur WHERE idfacture = @id", con);
                cmd.Parameters.AddWithValue("@id", idfacture);
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
            f.btnSupprimer.Enabled = false;
            f.dgvFacture.Rows.RemoveAt(f.dgvFacture.CurrentRow.Index);
        }
        public void Afficher(FormFacture f)
        {
            con.Close();
            try
            {
                if (f.txtNomFour.Text == "")
                {
                    if (f.chbDate.Checked)
                        cmdtxt = @"SELECT ff.idfacture, ff.libelle, ff.date_facture, ff.date_terme, ff.montant, ff.remise, ff.nomfichier, f.nomfour
                        FROM   FactureFournisseur AS ff INNER JOIN
                        Fournisseur AS f ON f.idfour = ff.idfour
                        WHERE date_terme BETWEEN @dateDe AND @dateA";
                    else
                        cmdtxt = @"SELECT ff.idfacture, ff.libelle, ff.date_facture, ff.date_terme, ff.montant, ff.remise, ff.nomfichier, f.nomfour
                        FROM   FactureFournisseur AS ff INNER JOIN
                        Fournisseur AS f ON f.idfour = ff.idfour
                        WHERE date_facture BETWEEN @dateDe AND @dateA";
                }
                else
                {
                    if (f.chbDate.Checked)
                        cmdtxt = @"SELECT ff.idfacture, ff.libelle, ff.date_facture, ff.date_terme, ff.montant, ff.remise, ff.nomfichier, f.nomfour
                        FROM   FactureFournisseur AS ff INNER JOIN
                        Fournisseur AS f ON f.idfour = ff.idfour
                        WHERE date_terme BETWEEN @dateDe AND @dateA";
                    else
                        cmdtxt = @"SELECT ff.idfacture, ff.libelle, ff.date_facture, ff.date_terme, ff.montant, ff.remise, ff.nomfichier, f.nomfour
                        FROM   FactureFournisseur AS ff INNER JOIN
                        Fournisseur AS f ON f.idfour = ff.idfour
                        WHERE date_facture BETWEEN @dateDe AND @dateA";
                }
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", f.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", f.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                f.dgvFacture.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void SelectionDGV(FormFacture f)
        {
            if(f.dgvFacture.RowCount != 0)
            {
                idfacture = Convert.ToInt32(f.dgvFacture.CurrentRow.Cells[0].Value);
                f.btnModifier.Enabled = true;
                f.btnSupprimer.Enabled = true;
                f.btnOuvrir.Enabled = true;
            }
        }
        public void OuvrirFacture()
        {
            OuvrirFichier(idfacture, "facturefour");
        }
    }
}
