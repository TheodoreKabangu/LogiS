using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LogiS
{
    class ClassCompte: ClassGen
    {
        string numcompte = "";
        #region Opérations
        public void Annuler(FormCompteBancaire c)
        {
            c.txtCompte.Clear();
            c.txtLibelle.Clear();
            c.txtDevise.Clear();
            c.btnModifier.Enabled = false;
            c.btnSupprimer.Enabled = false;
            c.btnAjouter.Enabled = true;
            c.dgvCompte.DataSource = null;
            c.txtCompte.Focus();
        }
        public void Enregistrer(FormCompteBancaire c)
        {
            if (c.txtCompte.Text != "" && c.txtLibelle.Text != "" && c.txtDevise.Text != "")
            {
                if (VerifierValeurUnique(c.txtCompte.Text, "comptebancaire") == 0)
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO CompteBancaire VALUES (@numcompte, @intitule, @devise)", con);
                        cmd.Parameters.AddWithValue("@numcompte", c.txtCompte.Text);
                        cmd.Parameters.AddWithValue("@intitule", c.txtLibelle.Text);
                        cmd.Parameters.AddWithValue("@devise", c.txtDevise.Text);
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
                    Annuler(c);
                }
                else
                    MessageBox.Show("Le numéro compte fourni existe déjà dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormCompteBancaire c)
        {
            if (c.txtCompte.Text != "" && c.txtLibelle.Text != "" && c.txtDevise.Text != "")
            {
                if (VerifierValeurUnique(c.txtCompte.Text, "comptebancaire") == 0)
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("UPDATE CompteBancaire SET numcompte = @numcompte, intitule = @intitule, devise = @devise WHERE numcompte = @numcompte", con);
                        cmd.Parameters.AddWithValue("@numcompte", numcompte);
                        cmd.Parameters.AddWithValue("@intitule", c.txtLibelle.Text);
                        cmd.Parameters.AddWithValue("@devise", c.txtDevise.Text);
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
                    Annuler(c);
                }
                else
                    MessageBox.Show("Le numéro compte fourni existe déjà dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormCompteBancaire c)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE CompteBancaire WHERE numcompte = @numcompte", con);
                cmd.Parameters.AddWithValue("@numcompte", numcompte);
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
            Annuler(c);
        }
        public void SelectionDGV(FormCompteBancaire c)
        {
            if(c.dgvCompte.RowCount != 0)
            {
                c.txtCompte.Text = c.dgvCompte.CurrentRow.Cells[0].Value.ToString();               
                c.txtLibelle.Text = c.dgvCompte.CurrentRow.Cells[1].Value.ToString();
                c.txtDevise.Text = c.dgvCompte.CurrentRow.Cells[2].Value.ToString();
                numcompte = c.txtCompte.Text;
                c.btnModifier.Enabled = true;
                c.btnSupprimer.Enabled = true;
                c.btnAjouter.Enabled = false;
            }
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmd = new SqlCommand("SELECT * FROM CompteBancaire WHERE intitule LIKE '" + txt.Text.Replace("'", "") + "%'", con);
                }
                else
                    cmd = new SqlCommand("SELECT * FROM CompteBancaire", con);
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
        }
        #endregion
    }
}
