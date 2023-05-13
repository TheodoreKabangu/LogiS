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
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string cmdtxt;
        //Operations
        public void MontantFournisseur(FormFournisseur f)
        {
            for (int i = 0; i < f.dgvFour.RowCount; i++)
            {
                con.Open();
                try
                {
                    cmdtxt = @"SELECT SUM(f.montant), SUM(d.montant), SUM(f.montant)-SUM(d.montant)
                    FROM Facture f
                    JOIN Fournisseur fo ON f.idfour = fo.idfour
                    JOIN Depense d ON d.idfour = fo.idfour
                    WHERE fo.idfour = @idfour";
                    cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.AddWithValue("@idfour", f.dgvFour.Rows[i].Cells[0].Value);
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        if (dr[0].ToString() != "")
                            f.dgvFour.Rows[i].Cells[1].Value = Convert.ToDouble(dr[0].ToString());
                        else
                            f.dgvFour.Rows[i].Cells[1].Value = 0;
                        if (dr[1].ToString() != "")
                            f.dgvFour.Rows[i].Cells[2].Value = Convert.ToDouble(dr[0].ToString());
                        else
                            f.dgvFour.Rows[i].Cells[2].Value = 0;
                        if (dr[2].ToString() != "")
                            f.dgvFour.Rows[i].Cells[3].Value = Convert.ToDouble(dr[0].ToString());
                        else
                            f.dgvFour.Rows[i].Cells[3].Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
    }
}
