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
using System.Globalization;

namespace LogiS
{
    class ClassPrevision : ClassGen
    {
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        static SqlConnection con = new SqlConnection(conString);
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt = new DataTable();

        #region Propriétés
        private int idprevision;
        private string dateprevision;
        private float taux;
        private string libellecharge;
        private double fraischarge;
        private int idpays;
        private int idproduit;
        private double somme_vol;
        private double somme_poids;
        private double somme_prix_vol;
        private int indice_vol;
        public string Dateprevision { get { return dateprevision; } set { dateprevision = value; } }
        public float Taux { get { return taux; } set { taux = value; } }
        public string Libellecharge { get { return libellecharge; } set { libellecharge = value; } }
        public double Fraischarge { get { return fraischarge; } set { fraischarge = value; } }
        public int Idpays { get { return idpays; } set { idpays = value; } }
        #endregion

        #region Opérations
        public ClassPrevision() { }
        public ClassPrevision(FormPrevision p)
        {
            dateprevision = p.dtpDate.Text;
            taux = float.Parse(p.txtTaux.Text);
            
        }
        
        ClassPays pa = new ClassPays();
        ClassProduit pro = new ClassProduit();
        public void ChargerListe(TextBox txt,DataGridView dgv, string motif)
        {
            if (txt.Text != "")
            {
                try
                {
                    switch (motif)
                    {
                        case "pays": pa.Afficher(txt, dgv);
                            if (dgv.RowCount > 0)
                            {
                                dgv.BringToFront();
                                dgv.Visible = true;
                            }
                            else
                                dgv.Visible = false;
                            break;
                        case "produit": pro.Afficher(txt, dgv);
                            if (dgv.RowCount > 0)
                            {
                                dgv.BringToFront();
                                dgv.Visible = true;
                            }
                            else
                                dgv.Visible = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                dgv.Visible = false;
        }
        
        List<int> listidproduit = new List<int>();
        public void SelectionLigne(FormPrevision p, string motif)
        {
            if(motif == "pays")
            {
                if (p.dgvPays.RowCount > 0)
                {
                    idpays = int.Parse(p.dgvPays.CurrentRow.Cells[0].Value.ToString());
                    p.txtPays.Text = p.dgvPays.CurrentRow.Cells[1].Value.ToString();
                    p.lblMonnaie.Text = p.dgvPays.CurrentRow.Cells[2].Value.ToString();
                    p.dgvPays.Visible = false;
                    p.txtTaux.Focus();
                }
            }
            else
            {
                if (p.dgvProduit.RowCount > 0)
                {
                    if (!listidproduit.Contains(int.Parse(p.dgvProduit.CurrentRow.Cells[0].Value.ToString())))
                    {
                        idproduit = int.Parse(p.dgvProduit.CurrentRow.Cells[0].Value.ToString());
                        p.dgvPrev.Rows.Add();
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[0].Value = p.dgvPrev.RowCount;
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[1].Value = idproduit;
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[2].Value = p.dgvProduit.CurrentRow.Cells[1].Value.ToString();
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[3].Value = p.dgvProduit.CurrentRow.Cells[2].Value.ToString();
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[4].Value = p.dgvProduit.CurrentRow.Cells[3].Value.ToString();
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[6].Value = p.dgvProduit.CurrentRow.Cells[4].Value.ToString();
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[8].Value = p.dgvProduit.CurrentRow.Cells[5].Value.ToString();
                        for (int i = 5; i < p.dgvPrev.ColumnCount; i++)
                        {
                            if(i != 6 && i != 8)
                                p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[i].Value = 0;
                        }
                        p.dgvPrev.Rows[p.dgvPrev.RowCount - 1].Cells[5].Selected = true;
                        listidproduit.Add(idproduit);
                        p.dgvProduit.Visible = false;
                    }
                    else
                        MessageBox.Show("Ce produit est déjà dans la liste ci-dessous !", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void CalculLigne(FormPrevision p)
        {
            for (int i = 7; i < p.dgvPrev.ColumnCount; i++)
            {
                if (i < 11)
                {
                    p.dgvPrev.CurrentRow.Cells[i].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[5].Value.ToString()) * Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i - 1].Value.ToString());
                    
                    if (Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i].Value) == 0)
                    {
                        p.dgvPrev.CurrentRow.Cells[i-1].Style.BackColor = Color.IndianRed;
                        p.dgvPrev.CurrentRow.Cells[i - 1].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        p.dgvPrev.CurrentRow.Cells[i - 1].Style.BackColor = Color.FromArgb(240, 240, 240);
                        p.dgvPrev.CurrentRow.Cells[i - 1].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
                else if (i == 11)
                {
                    if (p.txtTaux.Text != "")
                    {
                        p.dgvPrev.CurrentRow.Cells[i].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[10].Value.ToString()) * Convert.ToDouble(p.txtTaux.Text);
                        p.dgvPrev.CurrentRow.Cells[12].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[5].Value.ToString()) * Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i].Value.ToString());
                    }
                    else
                    {
                        p.dgvPrev.CurrentRow.Cells[10].Value = 0;
                        p.dgvPrev.CurrentRow.Cells[11].Value = 0;
                        p.dgvPrev.CurrentRow.Cells[1 + 1].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[5].Value.ToString()) * Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i].Value.ToString());
                    }
                    if (Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i].Value) == 0)
                    {
                        p.dgvPrev.CurrentRow.Cells[10].Style.BackColor = Color.IndianRed;
                        p.dgvPrev.CurrentRow.Cells[10].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        p.dgvPrev.CurrentRow.Cells[10].Style.BackColor = Color.FromArgb(240, 240, 240);
                        p.dgvPrev.CurrentRow.Cells[10].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                    i++;
                }
                else if (i == 14)
                {
                    p.dgvPrev.CurrentRow.Cells[i].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[5].Value.ToString()) * Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i - 1].Value.ToString());
                    p.dgvPrev.CurrentRow.Cells[15].Value = Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[14].Value.ToString()) - Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[12].Value.ToString());

                    if (Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[13].Value) <= Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[11].Value))
                    {
                        p.dgvPrev.CurrentRow.Cells[13].Style.BackColor = Color.IndianRed;
                        p.dgvPrev.CurrentRow.Cells[13].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        p.dgvPrev.CurrentRow.Cells[13].Style.BackColor = Color.FromArgb(240, 240, 240);
                        p.dgvPrev.CurrentRow.Cells[13].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                    i++;
                }
                else if (i == 17)
                {
                    p.dgvPrev.CurrentRow.Cells[i].Value = int.Parse(p.dgvPrev.CurrentRow.Cells[5].Value.ToString()) * Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[i - 1].Value.ToString());

                    if (Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[16].Value) <= Convert.ToDouble(p.dgvPrev.CurrentRow.Cells[11].Value))
                    {
                        p.dgvPrev.CurrentRow.Cells[16].Style.BackColor = Color.IndianRed;
                        p.dgvPrev.CurrentRow.Cells[16].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        p.dgvPrev.CurrentRow.Cells[16].Style.BackColor = Color.FromArgb(240, 240, 240);
                        p.dgvPrev.CurrentRow.Cells[16].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
                i++;
            }
        }
        public void CalculerCharge(FormPrevision p)
        {
            libellecharge = "";
            fraischarge = 0;
            for (int i = 0; i < p.dgvCharge.RowCount - 1; i++)
            {
                if (libellecharge == "")
                    libellecharge = p.dgvCharge.Rows[i].Cells[1].Value.ToString();
                else
                    libellecharge = string.Format("{0}, {1}", libellecharge, p.dgvCharge.Rows[i].Cells[1].Value.ToString());
                fraischarge += Convert.ToDouble(p.dgvCharge.Rows[i].Cells[2].Value);
            }
            if(libellecharge!= "")
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[1].Value = libellecharge;
            if(fraischarge > 0)
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[2].Value = fraischarge;
        }
        public void AjouterCharge(FormPrevision p)
        {
            if (p.dgvCharge.RowCount == 0)
            {
                p.dgvCharge.Rows.Add();
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[0].Value = p.dgvCharge.RowCount;
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[1].Value = "";
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[2].Value = 0;
            }
            else
            {
                if(p.dgvCharge.RowCount > 1)
                    p.dgvCharge.Rows.RemoveAt(p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Index);

                p.dgvCharge.Rows.Add(2);
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[0].Value = p.dgvCharge.RowCount;
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 2].Cells[1].Value = "";
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 2].Cells[2].Value = 0;
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[1].Value = "";
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[2].Value = 0;
                p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].ReadOnly = true;
                NumLigneDGV(p.dgvCharge);
                CalculerCharge(p);
            }            
        }
        public void TestTaux(TextBox txt)
        {
            TestFloat(txt);
        }
        public void CalculerParVolume(FormPrevision p, FormPrevisionParVolume pv)
        {
            if (p.cboContainer.Text != "" && p.txtPays.Text != "" && p.txtTaux.Text != "" && p.dgvCharge.RowCount != 0 && p.dgvPrev.RowCount != 0)
            {
                pv.dgv.Rows.Add(5);
                pv.dgv.Rows[0].Cells[0].Value = "Date";
                pv.dgv.Rows[0].Cells[1].Value = p.dtpDate.Text;
                pv.dgv.Rows[1].Cells[0].Value = "Pays";
                pv.dgv.Rows[1].Cells[1].Value = p.txtPays.Text;
                pv.dgv.Rows[2].Cells[0].Value = "Taux";
                pv.dgv.Rows[2].Cells[1].Value = p.txtTaux.Text;
                pv.dgv.Rows[3].Cells[0].Value = "Charges $";
                pv.dgv.Rows[3].Cells[1].Value = p.dgvCharge.Rows[p.dgvCharge.RowCount-1].Cells[2].Value;
                pv.dgv.Rows[4].Cells[0].Value = "Container(pds)";
                pv.dgv.Rows[4].Cells[1].Value = p.cboContainer.Text;

                if (p.cboContainer.Text == "20")
                    indice_vol = (int)(1000000 / (27500 / 30));
                else if (p.cboContainer.Text == "40")
                    indice_vol = (int)(1000000 / (28000 / 68));
                else
                    indice_vol = (int)(1000000 / (28000 / 78));

                somme_vol = 0; somme_prix_vol = 0;
                for (int i = 0; i < p.dgvPrev.RowCount; i++)
                {
                    pv.dgvPrev.Rows.Add();
                    pv.dgvPrev.Rows[i].Cells[0].Value = p.dgvPrev.Rows[i].Cells[0].Value;
                    pv.dgvPrev.Rows[i].Cells[1].Value = p.dgvPrev.Rows[i].Cells[1].Value;
                    pv.dgvPrev.Rows[i].Cells[2].Value = p.dgvPrev.Rows[i].Cells[2].Value;
                    pv.dgvPrev.Rows[i].Cells[3].Value = p.dgvPrev.Rows[i].Cells[3].Value;
                    pv.dgvPrev.Rows[i].Cells[4].Value = p.dgvPrev.Rows[i].Cells[4].Value;
                    pv.dgvPrev.Rows[i].Cells[5].Value = p.dgvPrev.Rows[i].Cells[5].Value;
                    pv.dgvPrev.Rows[i].Cells[6].Value = p.dgvPrev.Rows[i].Cells[6].Value;
                    pv.dgvPrev.Rows[i].Cells[7].Value = p.dgvPrev.Rows[i].Cells[7].Value;
                    pv.dgvPrev.Rows[i].Cells[8].Value = p.dgvPrev.Rows[i].Cells[8].Value;
                    pv.dgvPrev.Rows[i].Cells[9].Value = p.dgvPrev.Rows[i].Cells[9].Value;
                    pv.dgvPrev.Rows[i].Cells[10].Value = Convert.ToDouble(p.dgvPrev.Rows[i].Cells[9].Value) * 1000000/indice_vol;
                    somme_vol += Convert.ToDouble(pv.dgvPrev.Rows[i].Cells[9].Value);
                    somme_prix_vol += Convert.ToDouble(pv.dgvPrev.Rows[i].Cells[10].Value);
                }
                //Total
                pv.dgvPrev.Rows.Add();
                pv.dgvPrev.Rows[pv.dgvPrev.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                pv.dgvPrev.Rows[pv.dgvPrev.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                pv.dgvPrev.Rows[pv.dgvPrev.RowCount - 1].Cells[2].Value = "Totaux";
                pv.dgvPrev.Rows[pv.dgvPrev.RowCount - 1].Cells[9].Value = somme_vol;
                pv.dgvPrev.Rows[pv.dgvPrev.RowCount - 1].Cells[10].Value = somme_prix_vol;

                //Calcul de charge par article
                for (int i = 0; i < p.dgvPrev.RowCount; i++)
                {                   
                    pv.dgvPrev.Rows[i].Cells[11].Value = Convert.ToDouble(pv.dgvPrev.Rows[i].Cells[10].Value) * Convert.ToDouble(pv.dgv.Rows[3].Cells[1].Value) / somme_prix_vol;
                    pv.dgvPrev.Rows[i].Cells[12].Value = Convert.ToDouble(pv.dgvPrev.Rows[i].Cells[11].Value) / Convert.ToDouble(pv.dgvPrev.Rows[i].Cells[5].Value);
                }

                pv.ShowDialog();
                pv.Close();
            }
            else
                MessageBox.Show("Désolé! Champ(s) obligaoire(s) vide(s)", "Valeur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Annuler(FormPrevision p)
        {
            p.dtpDate.ResetText();
            p.lblMonnaie.Text = "";
            p.txtPays.Clear();
            p.txtTaux.Clear();
            p.txtProduit.Clear();
            p.dgvPays.Visible = false;
            p.dgvProduit.Visible = false;
            p.dgvPrev.Rows.Clear();
            p.dgvCharge.Rows.Clear();
            p.dgvPays.DataSource = null;
            p.dgvProduit.DataSource = null;
            p.txtCharge.Clear();
            p.chbCharge.Checked = false;
        }

        ProduitPrevision pp = new ProduitPrevision();

        public void Enregistrer(FormPrevision p)
        {
            //Constitution charge
            if (p.chbCharge.Checked)
                libellecharge = "Toutes les charges";
            else
            {
                libellecharge = p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[1].Value.ToString();                
            }
            if (p.txtCharge.Text != "")
                fraischarge = double.Parse(p.txtCharge.Text);
            else
                fraischarge = Convert.ToDouble(p.dgvCharge.Rows[p.dgvCharge.RowCount - 1].Cells[2].Value);

            if (p.txtPays.Text != "" && p.lblMonnaie.Text != "" && p.txtTaux.Text != "" && libellecharge != "" && fraischarge > 0)
            {
                idprevision = NouveauID("prevision");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Prevision VALUES (@id, @date_jour, @taux, @charge, @fraischarge, @idpays)", con);
                    cmd.Parameters.AddWithValue("@id", idpays);
                    cmd.Parameters.AddWithValue("@date_jour", p.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@taux", p.txtTaux.Text);
                    cmd.Parameters.AddWithValue("@charge", libellecharge);
                    cmd.Parameters.AddWithValue("@fraischarge", fraischarge);
                    cmd.Parameters.AddWithValue("@idpays", idpays);
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
                pp.AjouterProduitProvision(p);
            }            
        }
        public void Modifier(FormPrevision p, string motif)
        {
            if (motif == "prev")
                motif = "";//Modifier la prévision
            else
                pp.ModifierProduitProvision(p);//Modifier la ligne de produit prevision
        }
        public void Supprimer(FormPrevision p)
        {
            //supprimer prévision
            //
            pp.SupprimerProduitProvision(p);
        }

        #endregion

        private class ProduitPrevision : ClassGen
        {
            #region Propriétés
            private int id;
            private int idprevision;
            private int idproduit;
            private int qteproduit;
            private double poidsunit;
            private double volumunit;
            private double prixunitA;
            private double prixunitVA;
            private double prixunitV;
            #endregion

            #region Opérations
            public void AjouterProduitProvision(FormPrevision p)
            {
                for (int i = 0; i < p.dgvPrev.RowCount; i++)
                {
                    id = NouveauID("produitprevision");
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO ProduitPrevision VALUES (@id, @idprevision, @idproduit, @qte, @poids, @volume, @prixA, @prixVA, @prixV)", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idprevision", idprevision);
                        cmd.Parameters.AddWithValue("@idproduit", p.dgvPrev.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@qte", Convert.ToInt32(p.dgvPrev.Rows[i].Cells[5].Value));
                        cmd.Parameters.AddWithValue("@prixA", Convert.ToDouble(p.dgvPrev.Rows[i].Cells[11].Value));
                        cmd.Parameters.AddWithValue("@prixVA", Convert.ToDouble(p.dgvPrev.Rows[i].Cells[13].Value));
                        cmd.Parameters.AddWithValue("@prixV", Convert.ToDouble(p.dgvPrev.Rows[i].Cells[16].Value));
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
                }
            }
            public void ModifierProduitProvision(FormPrevision p)
            {

            }
            public void SupprimerProduitProvision(FormPrevision p)
            {

            }
            public void AfficherProduitProvision(FormPrevision p)
            {

            }
            #endregion
        }
    }

}

