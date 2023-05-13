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
    class ClassGen
    {
        //Attributs
        private int id = 0;
        private string valeur = "";
        //Opération générales
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataReader dr;
        protected int NouveauID(string objet)
        {
            id = 0;
            try
            {
                switch (objet)
                {
                    case "pays": cmd = new SqlCommand("SELECT MAX(idpays) FROM Pays", con); break;
                    case "produit": cmd = new SqlCommand("SELECT MAX(idproduit) FROM Produit", con); break;
                    case "prevision": cmd = new SqlCommand("SELECT MAX(idprevision) FROM Prevision", con); break;
                    case "produitprevision": cmd = new SqlCommand("SELECT MAX(id) FROM ProduitPrevision", con); break;
                }
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() == "")
                    id = 1;
                else
                    id = int.Parse(dr[0].ToString()) + 1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
            return id;
        }
        protected int TrouverID(string chaine)
        {
            id = 0;
            return id;
        }
        protected string TrouverAttribut(int id)
        {
            valeur = "";
            return valeur;
        }
        protected int Compter(string motif, int id)
        {
            this.id = 0;
            try
            {
                switch (motif)
                {
                    case "previsionpays": cmd = new SqlCommand("SELECT COUNT(idprevision) FROM Prevision WHERE idpays = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        break;
                    case "produitprevision": cmd = new SqlCommand("SELECT COUNT(id) FROM ProduitPrevision WHERE idproduit = @id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        break;
                }
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    id = int.Parse(dr[0].ToString());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            return id;
        }
        protected void NumLigneDGV(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }
        protected void TestFloat(TextBox txt)
        {
            if (txt.Text != "")
            {
                try
                {
                    float.Parse(txt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La valeur saisie est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
                }
            }
        }
    }
}
