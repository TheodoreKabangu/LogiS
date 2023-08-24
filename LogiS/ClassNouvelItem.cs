using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiS
{
    class ClassNouvelItem: ClassGen
    {
        int id;
        //Opérations
        public void Enregistrer(FormNouveauITem n)
        {
            if (n.txtItem.Text != "")
            {
                id = NouveauID(n.motif);
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (n.motif == "caisse")
                        cmdtxt = @"INSERT INTO Caisse VALUES (@id, @item)";
                    else if (n.motif == "facturier")
                        cmdtxt = @"INSERT INTO Facturier VALUES (@id, @item)";
                    else
                        cmdtxt = @"INSERT INTO Depot VALUES (@id, @item)";
                    cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@item", n.txtItem.Text);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Ajouté avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                n.txtItem.Clear();
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormNouveauITem n)
        {
            if (n.txtItem.Text != "")
            {
                id = Convert.ToInt32(n.dgv.CurrentRow.Cells[0].Value);
                con.Close();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (n.motif == "caisse")
                        cmdtxt = @"UPDATE Caisse SET nomcaisse = @item WHEERE idcaisse = @id";
                    else if (n.motif == "facturier")
                        cmdtxt = @"UPDATE Facturier SET facturier = @item WHERE idfacturier = @id";
                    else
                        cmdtxt = @"UPDATE Depot SET nomdepot = @item WHERE iddepot = @id";
                    cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@item", n.txtItem.Text);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                n.txtItem.Clear();
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormNouveauITem n)
        {
            con.Close();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                id = Convert.ToInt32(n.dgv.CurrentRow.Cells[0].Value);
                if (n.motif == "caisse")
                    cmdtxt = @"DELETE FROM Caisse WHEERE idcaisse = @id";
                else if (n.motif == "facturier")
                    cmdtxt = @"DELETE FROM Facturier WHERE idfacturier = @id";
                else
                    cmdtxt = @"DELETE FROM Depot WHERE iddepot = @id";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@item", n.txtItem.Text);
                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            n.dgv.Rows.RemoveAt(n.dgv.CurrentRow.Index);
        }
        public void Afficher(FormNouveauITem n)
        {
            con.Close();
            try
            {
                if(n.motif == "caisse")
                    cmdtxt = @"SELECT id, nomcaisse FROM Caisse";
                else if (n.motif == "facturier")
                    cmdtxt = @"SELECT id, facturier FROM Facturier";
                else
                    cmdtxt = @"SELECT id, nomdepot FROM Depot";
                cmd = new SqlCommand(cmdtxt, con);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                n.dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
