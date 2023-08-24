using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace LogiS
{
    class ClassClient: ClassGen
    {
        #region Attributs
        private int idclient;
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        #endregion

        #region Operations
        
        public void TestValeurEntier(TextBox txt)
        {
            TestEntier(txt);
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Close();
            try
            {
                if (txt.Text != "")
                {
                    cmd = new SqlCommand("SELECT * FROM Client WHERE nomclient LIKE '" + txt.Text.Replace("'", "") + "%'", con);
                }
                else
                    cmd = new SqlCommand("SELECT * FROM Client", con);
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
                MontantReste(dgv, "client");
        }
        public void Annuler(FormClientNew c)
        {
            c.txtNom.Clear();
            c.txtTel.Clear();
            c.txtEmail.Clear();
            c.btnModifier.Enabled = false;
            c.btnAjouter.Enabled = true;
            c.txtNom.Focus();
        }
        public void Enregistrer(FormClientNew c)
        {
            if (c.txtNom.Text != "" && c.txtTel.Text != "" && c.txtEmail.Text != "")
            {
                idclient = NouveauID("client");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Client VALUES (@id, @nomclient, @tel, @email)", con);
                    cmd.Parameters.AddWithValue("@id", idclient);
                    cmd.Parameters.AddWithValue("@nomclient", c.txtNom.Text);
                    cmd.Parameters.AddWithValue("@tel", "+"+c.txtTel.Text);
                    cmd.Parameters.AddWithValue("@email", c.txtEmail.Text);
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
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormClientNew c)
        {
            c.btnModifier.Enabled = false;
            if (c.txtNom.Text != "" && c.txtTel.Text != "" && c.txtEmail.Text != "")
            {
                idclient = Convert.ToInt32(c.Text.Substring(0, c.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE Client SET nomclient = @nomclient, telephone = @tel, email = @email WHERE idclient = @id", con);
                    cmd.Parameters.AddWithValue("@id", idclient);
                    cmd.Parameters.AddWithValue("@nomclient", c.txtNom.Text);
                    cmd.Parameters.AddWithValue("@tel", "+" + c.txtTel.Text);
                    cmd.Parameters.AddWithValue("@email", c.txtEmail.Text);
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
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SelectionDGV(FormClient c)
        {
            if (c.dgvClient.RowCount != 0)
            {
                idclient = Convert.ToInt32(c.dgvClient.CurrentRow.Cells[0].Value);
                if (c.poste != "facturation")
                {
                    c.btnModifier.Enabled = true;
                    c.btnSupprimer.Enabled = true;
                    c.btnPayer.Enabled = true;
                    c.btnFacture.Enabled = true;
                    c.btnPayement.Enabled = true;
                    c.btnBanque.Enabled = true;
                    c.btnSolde.Enabled = true;
                }
                else
                    c.btnFacturer.Enabled = true;                                  
            }
        }
        public void Supprimer(FormClient c)
        {
            c.btnSupprimer.Enabled = false;
            if (Compter("clientoperation", idclient) == 0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM Client WHERE idclient = @id", con);
                    cmd.Parameters.AddWithValue("@id", idclient);
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
            }
            else
                MessageBox.Show("Désolé! Ce client ne peut être supprimé car il est impliqué dans certaines opérations dans le système", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void PayementClient(int id, FormJournalOperation j)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT idpayement, date_jour, libelle, montant FROM PayementClient WHERE idclient = @id AND date_jour BETWEEN @dateDe AND @dateA", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                dr = cmd.ExecuteReader();
                j.dgv.Rows.Clear();
                while (dr.Read())
                {
                    j.dgv.Rows.Add();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString().Substring(0, 10);
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[2].Value = dr[2].ToString();
                    if (dr[3].ToString() != "")
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = dr[3].ToString();
                    else
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[4].Value = 0;
                    if (Convert.ToDouble(j.dgv.Rows[j.dgv.RowCount - 1].Cells[3].Value)==0)
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
        private void FactureClient(int id, FormJournalOperation j)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT idfacture, date_facture, libelle, montant-remise FROM FactureClient WHERE idclient = @id AND date_facture BETWEEN @dateDe AND @dateA", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                dr = cmd.ExecuteReader();
                j.dgv.Rows.Clear();
                while (dr.Read())
                {
                    j.dgv.Rows.Add();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                    j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString().Substring(0, 10);
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
        public void JournalClient(int id, FormJournalOperation j)
        {
            if (j.motif == "payementclient")
                PayementClient(id, j);
            else if (j.motif == "factureclient")
                FactureClient(id, j);
            else
            {
                //Créances
                FactureClient(id, j);
                //Dettes
                con.Open();
                try
                {
                    cmd = new SqlCommand("SELECT idpayement, date_jour, libelle, montant FROM PayementClient WHERE idclient = @id AND date_jour BETWEEN @dateDe AND @dateA", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@dateDe", j.dtpDateDe.Text);
                    cmd.Parameters.AddWithValue("@dateA", j.dtpDateA.Text);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        j.dgv.Rows.Add();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[0].Value = dr[0].ToString();
                        j.dgv.Rows[j.dgv.RowCount - 1].Cells[1].Value = dr[1].ToString().Substring(0, 10) ;
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

                if (j.dgv.RowCount != 0)
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
        
        #endregion
    }
}
