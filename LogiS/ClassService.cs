using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogiS
{
    class ClassService : ClassGen
    {
        int idservice;
        #region Opérations
        public void SelectionDGV(FormService s)
        {
            if(s.dgvService.RowCount != 0)
            {
                if (s.facturation)
                {
                    s.btnValider.Enabled = true;
                    
                }
                else
                {
                    s.txtNom.Text = s.dgvService.CurrentRow.Cells[1].Value.ToString();
                    s.btnModifier.Enabled = true;
                    s.btnSupprimer.Enabled = true;
                    s.btnAjouter.Enabled = false;
                }
            }
        }
        public void Enregistrer(FormService s)
        {
            if(s.txtNom.Text != "")
            {
                idservice = NouveauID("service");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO ServIce VALUES (@id, @nomservice)", con);
                    cmd.Parameters.AddWithValue("@id", idservice);
                    cmd.Parameters.AddWithValue("@nomservice", s.txtNom.Text);

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
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormService s)
        {
            if (s.txtNom.Text != "")
            {
                idservice = Convert.ToInt32(s.dgvService.CurrentRow.Cells[0].Value);
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE Service SET nomservice = @nomservice WHERE idservice = @id", con);
                    cmd.Parameters.AddWithValue("@id", idservice);
                    cmd.Parameters.AddWithValue("@nomservice", s.txtNom.Text);

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
                s.btnModifier.Enabled = false;
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormService s)
        {
            idservice = Convert.ToInt32(s.dgvService.CurrentRow.Cells[0].Value);
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE FROM Service WHERE idservice = @id", con);
                cmd.Parameters.AddWithValue("@id", idservice);

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
            s.btnSupprimer.Enabled = false;
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmdtxt = @"SELECT * FROM Service WHERE nomservice LIKE '" + txt.Text.Replace("'", "") + "%'";
                }
                else
                {
                    cmdtxt = @"SELECT * FROM Service";
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
        }
        #endregion
    }
}
