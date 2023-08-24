using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace LogiS
{
    class ClassFacturation: ClassGen
    {
        int idfacture, id;

        #region Opérations
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        private void AjouterLigneFactureClient(FormFacturationNew f)
        {
            if(f.chbService.Checked)
            {
                for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                {
                    id = NouveauID("factureclientligne2");
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO FactureClientLigne2 VALUES (@id, @idfacture, @idservice, @prix, @qte_com)", con);
                        cmd.Parameters.AddWithValue("@idfacture", idfacture);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idservice", Convert.ToInt32(f.dgvFacture.Rows[i].Cells[0].Value));
                        cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(f.dgvFacture.Rows[i].Cells[2].Value));
                        cmd.Parameters.AddWithValue("@qte_com", Convert.ToInt32(f.dgvFacture.Rows[i].Cells[3].Value));

                        cmd.Transaction = tx;
                        cmd.ExecuteNonQuery();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            else
            {
                for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                {
                    id = NouveauID("factureclientligne");
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO FactureClientLigne VALUES (@id, @idfacture, @idstock, @qte_com)", con);
                        cmd.Parameters.AddWithValue("@idfacture", idfacture);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idstock", Convert.ToInt32(f.dgvFacture.Rows[i].Cells[0].Value));
                        cmd.Parameters.AddWithValue("@qte_com", Convert.ToInt32(f.dgvFacture.Rows[i].Cells[3].Value));

                        cmd.Transaction = tx;
                        cmd.ExecuteNonQuery();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }
        public void Enregistrer(FormFacturationNew f)
        {
            if (f.dgvFacture.RowCount> 0 && f.txtLibelle.Text != "" && f.txtRemise.Text != "")
            {
                idfacture = NouveauID("factureclient");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO FactureClient VALUES (@id, @idclient, @libelle, @date_facture, @date_terme, @montant, @remise, @statut, @raison_retrait, @categorie)", con);
                    cmd.Parameters.AddWithValue("@idclient", f.txtClient.Text.Substring(0, f.txtClient.Text.IndexOf(",")));
                    cmd.Parameters.AddWithValue("@id", idfacture);
                    cmd.Parameters.AddWithValue("@date_facture", f.dtpDateFacture.Text);
                    cmd.Parameters.AddWithValue("@date_terme", f.dtpDateFacture.Text);
                    cmd.Parameters.AddWithValue("@libelle", f.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount-1].Cells[4].Value));
                    cmd.Parameters.AddWithValue("@remise", Convert.ToDouble(f.txtRemise.Text));
                    cmd.Parameters.AddWithValue("@statut", "actif");
                    cmd.Parameters.AddWithValue("@raison_retrait", "RAS");
                    cmd.Parameters.AddWithValue("@categorie", f.categorie);

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
                AjouterLigneFactureClient(f);
                GenererFacture(f, new FormImpression());
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AnnulerFacture(FormFacturation f)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("UPDATE FactureClient SET statut = @statut, raison_retrait = @raison WHERE idfacture = @id", con);
                cmd.Parameters.AddWithValue("@id", idfacture);
                cmd.Parameters.AddWithValue("@statut", "annulé");
                cmd.Parameters.AddWithValue("@raison", f.txtRaison.Text);

                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Annulation réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void SelectionDGV(FormFacturation f)
        {
            if (f.dgvFacture.RowCount != 0)
            {
                idfacture = Convert.ToInt32(f.dgvFacture.CurrentRow.Cells[0].Value);

                f.btnVoir.Enabled = true;
                if (f.poste != "facturation")
                {
                    f.btnAnnuler.Enabled = true;
                    f.txtRaison.Enabled = true;
                }
            }
        }
        public void Afficher(FormFacturation f)
        {
            con.Close();
            try
            {
                if(f.txtLibelle.Text != "")
                    cmdtxt = @"SELECT f.idfacture, f.idclient, f.date_facture, f.date_terme, f.montant, f.remise, c.nomclient, f.libelle, f.categorie, f.statut, f.raison_retrait
                    FROM   FactureClient AS f INNER JOIN Client AS c ON c.idclient = f.idclient WHERE libelle LIKE '%"+f.txtLibelle.Text.Replace("'","")+"%' AND date_facture BETWEEN @dateDe AND @dateA";
                else
                    cmdtxt = @"SELECT f.idfacture, f.idclient, f.date_facture, f.date_terme, f.montant, f.remise, c.nomclient, f.libelle, f.categorie, f.statut, f.raison_retrait
                    FROM   FactureClient AS f INNER JOIN Client AS c ON c.idclient = f.idclient WHERE date_facture BETWEEN @dateDe AND @dateA";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", f.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", f.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                f.dgvFacture.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        
        ClassStock ps = new ClassStock();
        ClassService ss = new ClassService();
        public void SelectionStock(FormFacturationNew f, FormStockRecherche s)
        {
            if (f.dgvProduit.RowCount != 0)
            {
                f.txtProduit.Text = f.dgvProduit.CurrentRow.Cells[2].Value.ToString();
                f.dgvProduit.Visible = false;
                ps.Afficher(f.txtProduit, s.dgvStock);
                if (s.dgvStock.RowCount != 0)
                {
                    s.facturation = true;
                    s.txtProduit.Enabled = false;
                    s.btnAfficher.Enabled = false;
                    s.ShowDialog();
                    if (s.ajout_succes)
                    {                        
                        if (f.dgvFacture.RowCount == 0)
                        {
                            f.dgvFacture.Rows.Add();
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvStock.CurrentRow.Cells[0].Value;
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = string.Format("{0}, {1} kg, {2} m3", f.txtProduit.Text, s.dgvStock.CurrentRow.Cells[2].Value, s.dgvStock.CurrentRow.Cells[3].Value);
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = s.dgvStock.CurrentRow.Cells[5].Value;
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = s.dgvStock.CurrentRow.Cells[6].Value;
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value) * Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value);

                            //Total
                            f.dgvFacture.Rows.Add();
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
                            for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                            {
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
                            }
                        }
                        else
                        {
                            f.stock_existe = false;
                            for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                            {
                                if (s.dgvStock.CurrentRow.Cells[0].Value.ToString() == f.dgvFacture.Rows[i].Cells[0].Value.ToString())
                                {
                                    f.stock_existe = true;
                                    i += f.dgvFacture.RowCount;
                                }
                            }
                            if (!f.stock_existe)
                            {
                                f.dgvFacture.Rows.RemoveAt(f.dgvFacture.RowCount - 1);

                                f.dgvFacture.Rows.Add();
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvStock.CurrentRow.Cells[0].Value;
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = string.Format("{0}, {1} kg, {2} m3", f.txtProduit.Text, s.dgvStock.CurrentRow.Cells[2].Value, s.dgvStock.CurrentRow.Cells[3].Value);
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = s.dgvStock.CurrentRow.Cells[5].Value;
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = s.dgvStock.CurrentRow.Cells[6].Value;
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value) * Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value);

                                //Total
                                f.dgvFacture.Rows.Add();
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
                                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
                                for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                                {
                                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Le stock sélectionné existe déjà sur cette facture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                f.txtProduit.Focus();
                            }
                        }
                    }
                }                    
                else
                {
                    MessageBox.Show("Désolé! Ce produit n'existe pas en stock", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.txtProduit.Clear();
                    f.txtProduit.Focus();
                }
            }
        }
        public void SelectionService(FormFacturationNew f, FormService s)
        {
            s.facturation = true;
            ss.Afficher(s.txtNom, s.dgvService);
            for (int i = 0; i < f.dgvFacture.ColumnCount; i++)
            {
                if (i != 2 && i != 3)
                    f.dgvFacture.Columns[i].ReadOnly = true;
            }
            s.ShowDialog();
            if (s.ajout_succes)
            {
                if (f.dgvFacture.RowCount == 0)
                {
                    f.dgvFacture.Rows.Add();
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvService.CurrentRow.Cells[0].Value;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = s.dgvService.CurrentRow.Cells[1].Value;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = 1;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = 1;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 1;

                    //Total
                    f.dgvFacture.Rows.Add();
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
                    for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                    {
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
                    }
                }
                else
                {
                    f.stock_existe = false;
                    for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                    {
                        if (s.dgvService.CurrentRow.Cells[0].Value.ToString() == f.dgvFacture.Rows[i].Cells[0].Value.ToString())
                        {
                            f.stock_existe = true;
                            i += f.dgvFacture.RowCount;
                        }
                    }
                    if (!f.stock_existe)
                    {
                        f.dgvFacture.Rows.RemoveAt(f.dgvFacture.RowCount - 1);

                        f.dgvFacture.Rows.Add();
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvService.CurrentRow.Cells[0].Value;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = s.dgvService.CurrentRow.Cells[1].Value;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = 1;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = 1;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 1;

                        //Total
                        f.dgvFacture.Rows.Add();
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
                        for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
                        {
                            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le service sélectionné existe déjà sur cette facture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                    }
                }
            }
        }
        public void CalculFacture(FormFacturationNew f)
        {
            for (int i = 2; i < 4; i++)
            {
                f.dgvFacture.CurrentRow.Cells[4].Value = Convert.ToDouble(f.dgvFacture.CurrentRow.Cells[2].Value) * Convert.ToDouble(f.dgvFacture.CurrentRow.Cells[3].Value);
            }
            f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
            for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
            {
                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
            }
        }
        public void VoirFacture(FormFacturation f, FormFacturationNew fn)
        {
            fn.btnProforma.Enabled = false;
            fn.btnEnregistrer.Enabled = false;
            fn.txtProduit.Enabled = false;
            fn.chbService.Enabled = false;
            fn.txtLibelle.Enabled = false;
            fn.txtRemise.Enabled = false;
            if (f.dgvFacture.CurrentRow.Cells[6].Value.ToString() == "produit")
            {
                fn.Text = "Facture produit - LogiS";
            }
            else
            {
                fn.Text = "Facture service - LogiS";
            }
            fn.dtpDateFacture.Text = f.dgvFacture.CurrentRow.Cells[1].Value.ToString();
            fn.dtpDateTerme.Text = f.dgvFacture.CurrentRow.Cells[2].Value.ToString();
            fn.txtClient.Text = f.dgvFacture.CurrentRow.Cells[7].Value.ToString();
            fn.txtLibelle.Text = f.dgvFacture.CurrentRow.Cells[3].Value.ToString();
            fn.txtRemise.Text = f.dgvFacture.CurrentRow.Cells[5].Value.ToString();
            AfficherLigneFacture(fn);
            fn.ShowDialog();
            fn.Close();
        }
        private void AfficherLigneFacture(FormFacturationNew fn)
        {
            con.Open();
            try
            {
                if (fn.Text.Contains("produit"))
                {
                    cmdtxt = @"SELECT f.idstock, nomcommercial, poidsunit, volumeunit, prix_vente, qte_com, prix_vente * qte_com
                    FROM   FactureClientLigne AS f JOIN ProduitStock AS s ON s.idstock = f.idstock 
                    JOIN Produit p ON p.idproduit = s.idproduit WHERE idfacture = @id";
                    cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.AddWithValue("@id", idfacture);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fn.dgvFacture.Rows.Add();
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[0].Value = dr[0].ToString();
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[1].Value = string.Format("{0}, {1} kg, {2} m3", dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[2].Value = Convert.ToDouble(dr[4].ToString());
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[3].Value = Convert.ToInt32(dr[5].ToString());
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(dr[6].ToString());
                    }
                }
                else
                {
                    cmdtxt = @"SELECT f.idservice, nomservice, prix, qte_com, prix * qte_com
                    FROM   FactureClientLigne2 AS f JOIN Service AS s ON s.idservice = f.idservice 
                    WHERE idfacture = @id";
                    cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.AddWithValue("@id", idfacture);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fn.dgvFacture.Rows.Add();
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[0].Value = dr[0].ToString();
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[1].Value = dr[1].ToString();
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[2].Value = Convert.ToDouble(dr[2].ToString());
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[3].Value = Convert.ToInt32(dr[3].ToString());
                        fn.dgvFacture.Rows[fn.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(dr[4].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        
        ReportDataSource rs = new ReportDataSource();
        public void GenererFacture(FormFacturationNew f, FormImpression imp)
        {
            imp.Text = "Facture - LogiS";

            List<Facture> list = new List<Facture>();
            list.Clear();

            for (int i = 0; i < f.dgvFacture.RowCount; i++)
            {
                Facture fa = new Facture
                {
                    idstock = f.dgvFacture.Rows[i].Cells[0].Value.ToString(),
                    produit = f.dgvFacture.Rows[i].Cells[1].Value.ToString(),
                    prix = f.dgvFacture.Rows[i].Cells[2].Value.ToString(),
                    qte = f.dgvFacture.Rows[i].Cells[3].Value.ToString(),
                    total = f.dgvFacture.Rows[i].Cells[4].Value.ToString(),
                };
                list.Add(fa);
            }
            TimeSpan s = f.dtpDateFacture.Value.Date - f.dtpDateTerme.Value.Date;
            ReportParameter[] rparams;
            if(f.txtTypeFacture.Text=="proforma")
            {
                rparams = new ReportParameter[]
                {
                    new ReportParameter("typefacture", "Facture "+f.txtTypeFacture.Text),
                    new ReportParameter("numfacture", "NULL"),
                    new ReportParameter("date_facture", f.dtpDateFacture.Text),
                    new ReportParameter("date_terme", f.dtpDateTerme.Text),
                    new ReportParameter("nomclient", f.txtClient.Text),
                    new ReportParameter("telephone", "NULL"),
                    new ReportParameter("email", "NULL"),
                    new ReportParameter("echeance", s.TotalDays.ToString()),
                };
            }
            else
            {
                rparams = new ReportParameter[]
                {
                    new ReportParameter("typefacture", "Facture "+f.txtTypeFacture.Text),
                    new ReportParameter("numfacture", idfacture.ToString()),
                    new ReportParameter("date_facture", f.dtpDateFacture.Text),
                    new ReportParameter("date_terme", f.dtpDateTerme.Text),
                    new ReportParameter("nomclient", f.txtClient.Text.Substring(f.txtClient.Text.IndexOf(",")+2)),
                    new ReportParameter("telephone", TrouverAttribut(Convert.ToInt32(f.txtClient.Text.Substring(0, f.txtClient.Text.IndexOf(","))), "telclient")),
                    new ReportParameter("email", TrouverAttribut(Convert.ToInt32(f.txtClient.Text.Substring(0, f.txtClient.Text.IndexOf(","))), "emailclient")),
                    new ReportParameter("echeance", s.TotalDays.ToString()),
                };
            }
            
            rs.Name = "DataSet1";
            rs.Value = list;
            imp.reportViewer1.LocalReport.DataSources.Clear();
            imp.reportViewer1.LocalReport.DataSources.Add(rs);
            imp.reportViewer1.LocalReport.ReportEmbeddedResource = "LogiS.rpFactureClient.rdlc";
            imp.reportViewer1.LocalReport.SetParameters(rparams);
            imp.MaximumSize = imp.Size;
            imp.MaximizeBox = false;
            imp.MinimizeBox = false;
            imp.ShowDialog();
        }
        #endregion
    }
    class Facture
    {
        public string idstock { get; set; }
        public string produit { get; set; }
        public string qte { get; set; }
        public string prix { get; set; }
        public string total { get; set; }
    }
}
