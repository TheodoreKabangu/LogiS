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
    class ClassProduit: ClassGen
    {
        #region Attributs
        private int idproduit;
        #endregion
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        #region Opérations
        public void Annuler(FormProduit p)
        {
            p.txtProduit.Clear();
            p.txtNomCom.Clear();
            p.chbNomProduit.Checked = false;
            p.cboUnite.DropDownStyle = ComboBoxStyle.DropDown;
            p.cboUnite.SelectedText = "";
            p.cboUnite.DropDownStyle = ComboBoxStyle.DropDownList;
            p.dgvProduit.DataSource = null;
            p.txtProduit.Focus();
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Open();
            try
            {
                if (txt.Text != "")
                {
                    cmd = new SqlCommand("SELECT * FROM Produit WHERE nomcommercial LIKE '" + txt.Text.Replace("'", "") + "%'", con);
                }
                else
                    cmd = new SqlCommand("SELECT * FROM Produit", con);
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
        public void Enregistrer(FormProduit p)
        {
            if(p.txtProduit.Text!= "" && p.txtNomCom.Text != "" && p.cboUnite.Text != "" && p.txtPoids.Text != "" && p.txtVolume.Text != "")
            {
                idproduit = NouveauID("produit");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Produit VALUES (@id, @nomproduit, @nomcommercial, @unite)", con);
                    cmd.Parameters.AddWithValue("@id", idproduit);
                    cmd.Parameters.AddWithValue("@nomproduit", p.txtProduit.Text);
                    cmd.Parameters.AddWithValue("@nomcommercial", p.txtNomCom.Text);
                    cmd.Parameters.AddWithValue("@unite", p.cboUnite.Text);
                    cmd.Parameters.AddWithValue("@poids", Convert.ToDouble(p.txtPoids.Text));
                    cmd.Parameters.AddWithValue("@volume", Convert.ToDouble(p.txtVolume.Text));
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
        public void SelectionDGV(FormProduit p)
        {
            if (p.dgvProduit.RowCount != 0)
            {
                idproduit = int.Parse(p.dgvProduit.CurrentRow.Cells[0].Value.ToString());
                p.txtProduit.Text = p.dgvProduit.CurrentRow.Cells[1].Value.ToString();
                p.txtNomCom.Text = p.dgvProduit.CurrentRow.Cells[2].Value.ToString();
                p.cboUnite.DropDownStyle = ComboBoxStyle.DropDown;
                p.cboUnite.Text = p.dgvProduit.CurrentRow.Cells[3].Value.ToString();
                p.cboUnite.DropDownStyle = ComboBoxStyle.DropDownList;
                p.btnModifier.Enabled = true;
                p.btnSupprimer.Enabled = true;
            }
        }
        public void Modifier(FormProduit p)
        {
            if (p.txtProduit.Text != "" && p.txtNomCom.Text != "" && p.cboUnite.Text != "")
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE Produit SET nomproduit = @nomproduit, nomcommercial = @nomcommercial, unite = @unite WHERE idproduit = @id", con);
                    cmd.Parameters.AddWithValue("@id", idproduit);
                    cmd.Parameters.AddWithValue("@nomproduit", p.txtProduit.Text);
                    cmd.Parameters.AddWithValue("@nomcommercial", p.txtNomCom.Text);
                    cmd.Parameters.AddWithValue("@unite", p.cboUnite.Text);
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
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormProduit p)
        {
            if(Compter("produitprevision", idproduit) == 0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM Produit WHERE idproduit = @id", con);
                    cmd.Parameters.AddWithValue("@id", idproduit);
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
            }
            else
                MessageBox.Show("Désolé! Ce pays ne peut être supprimé car il est impliqué dans les prévisions", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
