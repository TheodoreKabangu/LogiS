using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LogiS
{
    class ClassPays: ClassGen
    {
        #region Propriétés
        private int idpays;
        //private string nompays;
        //private string monnaie;
        #endregion


        #region Opérations       
        
        public void Annuler(FormPays p)
        {
            p.txtPays.Clear();
            p.txtMonnaie.Clear();
            p.dgvPays.DataSource = null;
            p.btnModifier.Enabled = false;
            p.btnSupprimer.Enabled = false;
            p.btnAjouter.Enabled = true;
            p.txtPays.Focus();
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmd = new SqlCommand("SELECT * FROM Pays WHERE nompays LIKE '" + txt.Text.Replace("'", "") + "%'", con);
                }
                else
                    cmd = new SqlCommand("SELECT * FROM Pays", con);
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
        public void Enregistrer(FormPays p)
        {
            if (p.txtPays.Text != "" && p.txtMonnaie.Text != "")
            {
                idpays = NouveauID("pays");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Pays VALUES (@id, @nompays, @monnaie)", con);
                    cmd.Parameters.AddWithValue("@id", idpays);
                    cmd.Parameters.AddWithValue("@nompays", p.txtPays.Text);
                    cmd.Parameters.AddWithValue("@monnaie", p.txtMonnaie.Text);
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
                Annuler(p);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SelectionDGV(FormPays p)
        {
            if(p.dgvPays.RowCount != 0)
            {
                idpays = int.Parse(p.dgvPays.CurrentRow.Cells[0].Value.ToString());
                p.txtPays.Text = p.dgvPays.CurrentRow.Cells[1].Value.ToString();
                p.txtMonnaie.Text = p.dgvPays.CurrentRow.Cells[2].Value.ToString();
                p.btnModifier.Enabled = true;
                p.btnSupprimer.Enabled = true;
                p.btnAjouter.Enabled = false;
            }
        }
        public void Modifier(FormPays p)
        {
            if (p.txtPays.Text != "" && p.txtMonnaie.Text != "")
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE Pays SET nompays = @nompays, monnaie = @monnaie WHERE idpays = @id", con);
                    cmd.Parameters.AddWithValue("@id", idpays);
                    cmd.Parameters.AddWithValue("@nompays", p.txtPays.Text);
                    cmd.Parameters.AddWithValue("@monnaie", p.txtMonnaie.Text);
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
                Annuler(p);
                Afficher(p.txtPays, p.dgvPays);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormPays p)
        {
            if (Compter("previsionpays", idpays) == 0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM Pays WHERE idpays = @id", con);
                    cmd.Parameters.AddWithValue("@id", idpays);
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
                Annuler(p);
                Afficher(p.txtPays, p.dgvPays);
            }
            else
                MessageBox.Show("Désolé! Ce pays ne peut être supprimé car il est impliqué dans certaines opérations dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}
