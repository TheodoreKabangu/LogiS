using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LogiS
{
    class ClassTiers: ClassGen
    {
        int idtiers;

        #region Opérations
        public void Annuler(FormCompteTiersNew t)
        {
            t.btnModifier.Enabled = false;
            t.txtNom.Clear();
            t.txtTel.Clear();
            t.txtNom.Focus();
        }
        public void Enregistrer(FormCompteTiersNew t)
        {
            if (t.txtNom.Text != "" && t.txtTel.Text != "")
            {
                idtiers = NouveauID("tiers");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Tiers VALUES (@id, @nomtiers, @tel)", con);
                    cmd.Parameters.AddWithValue("@id", idtiers);
                    cmd.Parameters.AddWithValue("@nomtiers", t.txtNom.Text);
                    cmd.Parameters.AddWithValue("@tel", t.txtTel.Text);
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
                Annuler(t);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormCompteTiersNew t)
        {
            if (t.txtNom.Text != "" && t.txtTel.Text != "")
            {
                idtiers = Convert.ToInt32(t.Text.Substring(0,t.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE Tiers SET nomtiers = @nomtiers, telephone = @tel WHERE idtiers = @id", con);
                    cmd.Parameters.AddWithValue("@id", idtiers);
                    cmd.Parameters.AddWithValue("@nomtiers", t.txtNom.Text);
                    cmd.Parameters.AddWithValue("@tel", t.txtTel.Text);
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
                Annuler(t);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SelectionDGV(FormComptesTiers t)
        {
            if(t.dgvTiers.RowCount != 0)
            {
                idtiers = Convert.ToInt32(t.dgvTiers.CurrentRow.Cells[0].Value);

                t.btnModifier.Enabled = true;
                t.btnSupprimer.Enabled = true;
                t.btnCreance.Enabled = true;
                t.btnDette.Enabled = true;
                t.btnVoirDetails.Enabled = true;
            }
        }
        public void Supprimer(FormComptesTiers t)
        {
            if(Compter("operationtiers", idtiers)==0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM Tiers WHERE idtiers = @id", con);
                    cmd.Parameters.AddWithValue("@id", idtiers);
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
                t.dgvTiers.Rows.RemoveAt(t.dgvTiers.CurrentRow.Index);
            }
            else
                MessageBox.Show("Désolé! Ce compte tiers ne peut être supprimée car il est impliqué dans certaines opérations dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmdtxt = @"SELECT * FROM Tiers WHERE nomtiers LIKE '" + txt.Text.Replace("'", "") + "%'";
                }
                else
                {
                    cmdtxt = @"SELECT * FROM Tiers";
                }
                cmd = new SqlCommand(cmdtxt, con);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (dgv.RowCount > 0)
                MontantReste(dgv, "tiers");
        }
        public void JournalTiers(int id, FormJournalOperation j)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT idoperation, date_jour, libelle, montant, categorie FROM OperationTiers WHERE idtiers = @id AND date_jour BETWEEN @dateDe AND @dateA", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    j.dgv.Rows.Add();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString().Substring(0, 10);
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[2].Value = dr[2].ToString();
                    if (dr[4].ToString() == "dette")
                    {
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = dr[3].ToString();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = 0;
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = 0;
                    }
                    else
                    {
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = dr[3].ToString();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = 0;
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = 0;
                    }

                    if (j.dgv.RowCount == 1)
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value) - Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value);
                    else
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 2].Cells[5].Value) + Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value) - Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        int idoperation;
        public void AjouterRecette(FormTiersOperationNew op, FormRecetteNew r)
        {
            if (op.txtMontant.Text != "" && op.txtLibelle.Text != "")
            {
                r.txtMontant.Text = op.txtMontant.Text;
                r.txtLibelle.Text = op.txtLibelle.Text;
                r.txtPayeur.Text = op.txtTiers.Text.Substring(op.txtTiers.Text.IndexOf(" ") + 1);
                r.txtFichier.Text = op.txtFichier.Text;
                r.ShowDialog();
            }
            else
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void AjouterDepense(FormTiersOperationNew op, FormDepenseNew d)
        {
            if (op.txtMontant.Text != "" && op.txtLibelle.Text != "")
            {
                d.txtMontant.Text = op.txtMontant.Text;
                d.txtLibelle.Text = op.txtLibelle.Text;
                d.txtBeneficiaire.Text = op.txtTiers.Text.Substring(op.txtTiers.Text.IndexOf(" ") + 1);
                d.txtFichier.Text = op.txtFichier.Text;
                d.ShowDialog();
            } 
            else
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void Enregistrer(FormTiersOperationNew op)
        {
            if (op.txtMontant.Text != "" && op.txtLibelle.Text != "")
            {
                //enregistrement
                idoperation = NouveauID("operation");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (op.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(op.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(op.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;
                            cmd = new SqlCommand("INSERT INTO OperationTiers VALUES (@id, @date_jour, @montant, @libelle, @fichier, @nomficher, @ext, @categorie, @idtiers, @statut)", con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);

                        }
                    }
                    else
                        cmd = new SqlCommand("INSERT INTO OperationTiers (idoperation, date_jour, montant, libelle, categorie, idtiers, statut) VALUES (@id, @date_jour, @montant, @libelle, @categorie, @idtiers, @statut)", con);
                    cmd.Parameters.AddWithValue("@id", idoperation);
                    cmd.Parameters.AddWithValue("@date_jour", op.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(op.txtMontant.Text));
                    cmd.Parameters.AddWithValue("@libelle", op.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@categorie", op.txtTypeOperation.Text);
                    cmd.Parameters.AddWithValue("@idtiers", op.txtTiers.Text.Substring(0, op.txtTiers.Text.IndexOf(",")));
                    cmd.Parameters.AddWithValue("@statut", "RAS");

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
                op.Close();
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormTiersOperationNew op)
        {
            if (op.txtMontant.Text != "" && op.txtLibelle.Text != "")
            {
                if (op.txtFichier.Text != "")
                {
                    using (Stream stream = File.OpenRead(op.txtFichier.Text))
                    {
                        //binarisation du fichier preuve
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        var fichier = new FileInfo(op.txtFichier.Text);
                        string ext = fichier.Extension;
                        string nomfichier = fichier.Name;
                        //enregistrement
                        idoperation = Convert.ToInt32(op.Text.Substring(0, op.Text.IndexOf("-")));
                        con.Open();
                        SqlTransaction tx = con.BeginTransaction();
                        try
                        {
                            cmd = new SqlCommand("UPDATE OperationTiers SET date_jour = @date_jour, montant = @montant, libelle = @libelle, fichier = @fichier, nomfichier = @nomficher, extfichier = @ext, categorie = @categorie, idtiers = @idtiers WHERE idoperation = @id", con);
                            cmd.Parameters.AddWithValue("@id", idoperation);
                            cmd.Parameters.AddWithValue("@date_jour", op.dtpDate.Text);
                            cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(op.txtMontant.Text));
                            cmd.Parameters.AddWithValue("@libelle", op.txtLibelle.Text);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                            cmd.Parameters.AddWithValue("@categorie", op.txtTypeOperation.Text);
                            cmd.Parameters.AddWithValue("@idtiers", op.txtTiers.Text.Substring(0, op.txtTiers.Text.IndexOf(",")));

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
                        op.Close();
                    }
                }
                else
                {
                    idoperation = Convert.ToInt32(op.Text.Substring(0, op.Text.IndexOf("-")));
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("UPDATE OperationTiers SET date_jour = @date_jour, montant = @montant, libelle = @libelle, categorie = @categorie, idtiers = @idtiers WHERE idoperation = @id", con);
                        cmd.Parameters.AddWithValue("@id", idoperation);
                        cmd.Parameters.AddWithValue("@date_jour", op.dtpDate.Text);
                        cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(op.txtMontant.Text));
                        cmd.Parameters.AddWithValue("@libelle", op.txtLibelle.Text);
                        cmd.Parameters.AddWithValue("@categorie", op.txtTypeOperation.Text);
                        cmd.Parameters.AddWithValue("@idtiers", op.txtTiers.Text.Substring(0, op.txtTiers.Text.IndexOf(",")));

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
                    op.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Afficher(DateTimePicker dtDe, DateTimePicker dtA, DataGridView dgv)
        {
            AfficherTransaction(dtDe, dtA, dgv, "operationtiers");
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Cloturer()
        {
            CloturerOperationTiers();
        }
        public void SelectionDGV(FormTiersOperation t)
        {
            if (t.dgvOperation.RowCount != 0)
            {
                idoperation = Convert.ToInt32(t.dgvOperation.CurrentRow.Cells[0].Value);
                t.btnModifier.Enabled = true;
                t.btnVoir.Enabled = true;
            }
        }
        public void VoirFichier()
        {
            OuvrirFichier(idoperation, "operation");
        }
        #endregion
    }
}
