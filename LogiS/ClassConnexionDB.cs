using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace LogiS
{
    class ClassConnexionDB
    {
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        public SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        public void Connexion()
        {
            //con.Open();
            //SqlTransaction tx = con.BeginTransaction();
        }
        public void Deconnexion()
        {
            //con.Close();
        }

        #region PAYS
        //public void AjouterPays()
        #endregion
    }
}
