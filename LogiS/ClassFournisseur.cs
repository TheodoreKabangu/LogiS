using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;


namespace LogiS
{
    class ClassFournisseur: ClassGen
    {
        int idfour;
        //Operations
        public void TestValeurEntier(TextBox txt)
        {
            TestEntier(txt);
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmdtxt = @"SELECT f.idfour, f.nomfour, f.person_contact, f.telephone, f.email, f.numcompte, f.intitule, f.code_swift, f.banque, p.nompays, f.idpays
                    FROM   Fournisseur AS f INNER JOIN
                    Pays AS p ON f.idpays = p.idpays
                    WHERE nomfour LIKE '" + txt.Text.Replace("'", "") + "%'";                    
                }
                else
                {
                    cmdtxt = @"SELECT f.idfour, f.nomfour, f.person_contact, f.telephone, f.email, f.numcompte, f.intitule, f.code_swift, f.banque, p.nompays, f.idpays
                    FROM   Fournisseur AS f INNER JOIN
                    Pays AS p ON f.idpays = p.idpays";
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
                MontantReste(dgv, "fournisseur");
        }
        public void Annuler(FormFournisseurNew f)
        {
            f.txtNomFour.Clear();
            f.txtPays.Clear();
            f.txtPays.Enabled = true;
            f.txtPersContact.Clear();
            f.txtTel.Clear();
            f.txtEmail.Text = "RAS";
            f.txtNumCompte.Text = "RAS";
            f.txtIntitule.Text = "RAS";
            f.txtCodeSwift.Text = "RAS";
            f.txtBanque.Text = "RAS";
            f.txtNomFour.Focus();
            f.btnModifier.Enabled = false;
        }
        
        public void Enregistrer(FormFournisseurNew f)
        {
            if (!f.txtPays.Enabled && f.txtNomFour.Text != "" && f.txtPersContact.Text != "" && f.txtTel.Text != "" && f.txtEmail.Text != "" && f.txtNumCompte.Text != "" && f.txtIntitule.Text != "" && f.txtCodeSwift.Text != "" && f.txtBanque.Text != "")
            {
                if(VerifierValeurUnique(f.txtNomFour.Text, "fournisseur")==0)
                {
                    idfour = NouveauID("fournisseur");
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO Fournisseur VALUES (@id, @idpays, @nomfour, @perso_contact, @tel, @email, @numcompte, @intitule, @swift, @banque)", con);
                        cmd.Parameters.AddWithValue("@id", idfour);
                        cmd.Parameters.AddWithValue("@idpays", f.idpays);
                        cmd.Parameters.AddWithValue("@nomfour", f.txtNomFour.Text);
                        cmd.Parameters.AddWithValue("@perso_contact", f.txtPersContact.Text);
                        cmd.Parameters.AddWithValue("@tel", "+" + f.txtTel.Text);
                        cmd.Parameters.AddWithValue("@email", f.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@numcompte", f.txtNumCompte.Text);
                        cmd.Parameters.AddWithValue("@intitule", f.txtIntitule.Text);
                        cmd.Parameters.AddWithValue("@swift", f.txtCodeSwift.Text);
                        cmd.Parameters.AddWithValue("@banque", f.txtBanque.Text);
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
                    MessageBox.Show("Désolé! Un autre fournisseur utilise déjà ce nom dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SelectionDGV(FormFournisseur c)
        {
            if (c.dgvFour.RowCount != 0)
            {
                idfour = Convert.ToInt32(c.dgvFour.CurrentRow.Cells[0].Value);
                c.btnModifier.Enabled = true;
                c.btnSupprimer.Enabled = true;
                c.btnPayer.Enabled = true;
                c.btnBanque.Enabled = true;
            }
        }
        public void Modifier(FormFournisseurNew f)
        {           
            if (!f.txtPays.Enabled && f.txtNomFour.Text != "" && f.txtPersContact.Text != "" && f.txtTel.Text != "" && f.txtEmail.Text != "" && f.txtNumCompte.Text != "" && f.txtIntitule.Text != "" && f.txtCodeSwift.Text != "" && f.txtBanque.Text != "")
            {
                if (VerifierValeurUnique(f.txtNomFour.Text, "fournisseur") == 0)
                {
                    idfour = Convert.ToInt32(f.Text.Substring(0, f.Text.IndexOf("-")));
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("UPDATE Fournisseur SET idpays = @idpays, nomfour = @nomfour, person_contact = @perso_contact, telephone = @tel, email = @email, numcompte = @numcompte, intitule = @intitule, code_swift = @swift, banque = @banque WHERE idfour = @id", con);
                        cmd.Parameters.AddWithValue("@id", idfour);
                        cmd.Parameters.AddWithValue("@idpays", f.idpays);
                        cmd.Parameters.AddWithValue("@nomfour", f.txtNomFour.Text);
                        cmd.Parameters.AddWithValue("@perso_contact", f.txtPersContact.Text);
                        cmd.Parameters.AddWithValue("@tel", "+" + f.txtTel.Text);
                        cmd.Parameters.AddWithValue("@email", f.txtEmail.Text);
                        cmd.Parameters.AddWithValue("@numcompte", f.txtNumCompte.Text);
                        cmd.Parameters.AddWithValue("@intitule", f.txtIntitule.Text);
                        cmd.Parameters.AddWithValue("@swift", f.txtCodeSwift.Text);
                        cmd.Parameters.AddWithValue("@banque", f.txtBanque.Text);
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
                    MessageBox.Show("Désolé! Un autre fournisseur utilise déjà ce nom dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormFournisseur f)
        {
            f.btnSupprimer.Enabled = false;
            if (Compter("fournisseuroperation", idfour) == 0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM Fournisseur WHERE idfour = @id", con);
                    cmd.Parameters.AddWithValue("@id", idfour);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.dgvFour.Rows.RemoveAt(f.dgvFour.CurrentRow.Index);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
                MessageBox.Show("Désolé! Ce fournisseur ne peut être supprimé car il est impliqué dans certaines opérations dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void PayementFour(int id, FormJournalOperation j)
        {
            con.Close();
            try
            {
                cmd = new SqlCommand("SELECT idpayement, date_jour, libelle, montant FROM PayementFournisseur WHERE idfour = @id AND date_jour BETWEEN @dateDe AND @dateA", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                dr = cmd.ExecuteReader();
                j.dgv.Rows.Clear();
                while (dr.Read())
                {
                    j.dgv.Rows.Add();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[2].Value = dr[2].ToString();
                    if (dr[3].ToString() != "")
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = dr[3].ToString();
                    else
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = 0;
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = 0;
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void FactureFour(int id, FormJournalOperation j)
        {
            con.Close();
            try
            {
                cmd = new SqlCommand("SELECT idfacture, date_facture, libelle, montant-remise FROM FactureFournisseur WHERE idfour = @id AND date_facture BETWEEN @dateDe AND @dateA", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                dr = cmd.ExecuteReader();
                j.dgv.Rows.Clear();
                while (dr.Read())
                {
                    j.dgv.Rows.Add();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[2].Value = dr[2].ToString();
                    if (dr[3].ToString() != "")
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = dr[3].ToString();
                    else
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = 0;
                    if (Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value) == 0)
                    {
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = 0;
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void JournalFour(int id, FormJournalOperation j)
        {
            if (j.motif == "payementfour")
                PayementFour(id, j);
            else if (j.motif == "facturefour")
                FactureFour(id, j);
            else
            {
                PayementFour(id, j);
                con.Close();
                try
                {
                    cmd = new SqlCommand("SELECT idfacture, date_facture, libelle, montant-remise FROM FactureFournisseur WHERE idfour = @id AND date_facture BETWEEN @dateDe AND @dateA", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                    cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        j.dgv.Rows.Add();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[2].Value = dr[2].ToString();
                        if (dr[3].ToString() != "")
                            j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = dr[3].ToString();
                        else
                            j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = 0;
                        if (Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value) == 0)
                        {
                            j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value = 0;
                            j.dgv.Rows[j.dgv.RowCount - 1].Cells[5].Value = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                if(j.dgv.RowCount != 0)
                {
                    for (int i = 0; i < j.dgv.RowCount; i++)
                    {
                        if (i == 0)
                            j.dgv.Rows[i].Cells[5].Value = Convert.ToDouble(j.dgv.Rows[i].Cells[3].Value) - Convert.ToDouble(j.dgv.Rows[i].Cells[4].Value);
                        else
                            j.dgv.Rows[i].Cells[5].Value = Convert.ToDouble(j.dgv.Rows[i - 1].Cells[5].Value) + Convert.ToDouble(j.dgv.Rows[i].Cells[3].Value) - Convert.ToDouble(j.dgv.Rows[i].Cells[4].Value);
                    }
                }
            }
        }
    }
}
