using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogiS
{
    class ClassUser: ClassGen
    {
        int id;
        //Op&rations
        public void Annuler(FormUtilisateur u)
        {
            u.txtUtilisateur.Clear();
            u.cboPoste.DropDownStyle = ComboBoxStyle.DropDown;
            u.cboPoste.SelectedText = "";
            u.cboPoste.DropDownStyle = ComboBoxStyle.DropDownList;
            u.txtSpecification.Clear();
            u.txtUtilisateur.Focus();
        }
        public void Enregistrer(FormUtilisateur u)
        {
            if (u.txtUtilisateur.Text != "" && u.cboPoste.Text != "" && u.txtSpecification.Text != "")
            {
                id = NouveauID("user");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Utilisateur VALUES (@id, @utilisateur, @motdepasse, @poste, @specification)", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@utilisateur", u.txtUtilisateur.Text);
                    cmd.Parameters.AddWithValue("@motdepasse", "123456");
                    cmd.Parameters.AddWithValue("@poste", u.cboPoste.Text);
                    cmd.Parameters.AddWithValue("@specification", u.txtSpecification.Text);
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
                Annuler(u);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormUtilisateur u)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("DELETE FROM Utilisateur WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(u.dgvUser.CurrentRow.Cells[0].Value));
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
        public void Afficher(FormUtilisateur u)
        {
            con.Close();
            try
            {
                if (u.txtUtilisateur.Text != "")
                {
                    cmdtxt = @"SELECT id, utilisateur, poste, specification 
                    FROM Utilisateur WHERE utilisateur LIKE '"+u.txtUtilisateur.Text.Replace("'", "")+"%' ";
                }
                else
                    cmdtxt = @"SELECT id, utilisateur, poste, specification 
                    FROM Utilisateur"; 
                cmd = new SqlCommand(cmdtxt, con);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                u.dgvUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void ChargerPoste(ComboBox cbo)
        {
            ChargerCbo(cbo, "poste");
        }
    }
}
