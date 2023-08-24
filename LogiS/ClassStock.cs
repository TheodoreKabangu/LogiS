using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiS
{
    class ClassStock : ClassGen
    {
        public void Afficher(TextBox txt, DataGridView dgv)
        {
            con.Open();
            try
            {
                if (txt.Text != "")
                {
                    cmdtxt = @"SELECT idstock, qteinit, poidsunit, volumeunit, expiration, prix_vente FROM ProduitStock s JOIN Produit p ON p.idproduit = s.idproduit WHERE nomcommercial LIKE '" + txt.Text.Replace("'", "") + "%'";
                }
                else
                {
                    cmdtxt = @"SELECT idstock, qtestock, poidsunit, volumeunit, expiration, prix_vente FROM ProduitStock s JOIN Produit p ON p.idproduit = s.idproduit";
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
        public void AfficherProduitDepot(DataGridView dgv, TextBox txt, int iddepot)
        {
            con.Open();
            try
            {
                if(iddepot>0)
                {
                    if (txt.Text == "")
                        cmdtxt = @"SELECT p.idproduit, nomproduit, nomcommercial, unite, poidsunit,volumeunit  
                    FROM Produit p JOIN ProduitStock ps ON p.idproduit = ps.idproduit 
                    JOIN Depot d ON ps.iddepot = d.iddepot WHERE d.iddepot = " + iddepot + "";
                    else
                        cmdtxt = @"SELECT p.idproduit, nomproduit, nomcommercial, unite, poidsunit,volumeunit 
                    FROM Produit p JOIN ProduitStock ps ON p.idproduit = ps.idproduit 
                    JOIN Depot d ON ps.iddepot = d.iddepot WHERE d.iddepot = " + iddepot + " AND nomcommercial LIKE '" + txt.Text.Replace("'", "") + "%'";
                }
                else
                {
                    if (txt.Text == "")
                        cmdtxt = @"SELECT * FROM Produit ";
                    else
                        cmdtxt = @"SELECT * FROM Produit WHERE nomcommercial LIKE '" + txt.Text.Replace("'", "") + "%'";
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
        public void AfficherStock(FormStock s)
        {
            con.Open();
            try
            {
                if(s.cboDepot.Text == "")
                    cmd = new SqlCommand("SELECT idstock, qteinit, numlot, expiration, cout_achat, prix_vente, nomdepot FROM ProduitStock ps JOIN Depot d ON ps.iddepot = d.iddepot WHERE idproduit = @idproduit", con);
                else
                    cmd = new SqlCommand("SELECT idstock, qteinit, numlot, expiration, cout_achat, prix_vente, nomdepot FROM ProduitStock ps JOIN Depot d ON ps.iddepot = d.iddepot WHERE idproduit = @idproduit AND ps.iddepot = "+s.iddepot+"", con);
                cmd.Parameters.AddWithValue("@idproduit", s.dgvProduit.CurrentRow.Cells[0].Value.ToString());
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                s.dgvStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (s.dgvStock.RowCount != 0)
            {
                for (int i = 0; i < s.dgvStock.RowCount; i++)
                {
                    s.dgvStock.Rows[i].Cells[1].Value = Convert.ToInt32(s.dgvStock.Rows[i].Cells[1].Value) + QteStock(Convert.ToInt32(s.dgvStock.Rows[i].Cells[0].Value), TrouverID(s.dgvStock.Rows[i].Cells[6].Value.ToString(), "depot"));
                }
            }
        }
        public void AfficherStock(FormDepotStock s)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT idstock, qteinit, numlot, expiration, prix_vente, cout_achat, nomdepot FROM ProduitStock ps JOIN Depot d ON ps.iddepot = d.iddepot WHERE idproduit = @idproduit AND ps.iddepot = " + s.iddepot + "", con);
                cmd.Parameters.AddWithValue("@idproduit", s.dgvProduit.CurrentRow.Cells[0].Value.ToString());
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                s.dgvStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (s.dgvStock.RowCount != 0)
            {
                for (int i = 0; i < s.dgvStock.RowCount; i++)
                {
                    s.dgvStock.Rows[i].Cells[1].Value = Convert.ToInt32(s.dgvStock.Rows[i].Cells[1].Value) + QteStock(Convert.ToInt32(s.dgvStock.Rows[i].Cells[0].Value), s.iddepot);
                }
            }
        }
        int qte, idstock, idsortie, identree;
        private int QteEntree(int idstock, int iddepot)
        {
            qte = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(qteajoute) FROM StockEntree WHERE idstock = "+idstock+" AND iddepot = "+iddepot+"", con);               
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if (dr[0].ToString() != "") 
                        qte = Convert.ToInt32(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return qte;
        }
        private int QteSortie(int idstock, int iddepot)
        {
            qte = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(qtesortie) FROM StockSortie WHERE idstock = " + idstock + " AND iddepot = " + iddepot + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        qte = Convert.ToInt32(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return qte;
        }
        public int QteStock(int idstock, int iddepot)
        {
            return QteEntree(idstock, iddepot) - QteSortie(idstock, iddepot);
        }
        public void TestValeurEntier(TextBox txt)
        {
            TestEntier(txt);
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Annuler(FormStockNew s)
        {
            s.txtQteStock.Clear();
            s.txtAnnee.Clear();
            s.txtNumLot.Clear();
            s.txtCoutAchat.Clear();
            s.txtPrixVente.Clear();
            s.cboMois.DropDownStyle = ComboBoxStyle.DropDown;
            s.cboMois.SelectedText = "";
            s.cboMois.DropDownStyle = ComboBoxStyle.DropDownList;
            s.txtQteStock.Focus();
        }
        
        string expiration = "RAS";
        public void Enregistrer(FormStockNew s)
        {
            if (s.txtQteStock.Text != "" && s.txtNumLot.Text != "" && s.txtCoutAchat.Text != "" && s.txtPrixVente.Text != "" && s.cboDepot.Text != "")
            {
                idstock = NouveauID("stock");
                if (s.cboMois.Text != "" && s.txtAnnee.Text != "")
                    expiration = string.Format("{0}/{1}", s.cboMois.Text, s.txtAnnee.Text);
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO ProduitStock VALUES (@id, @idproduit, @qteinit, @numlot, @expiration, @cout_achat, @prix_vente, @iddepot)", con);
                    cmd.Parameters.AddWithValue("@id", idstock);
                    cmd.Parameters.AddWithValue("@idproduit", s.idproduit);
                    cmd.Parameters.AddWithValue("@qteinit", s.txtQteStock.Text);
                    cmd.Parameters.AddWithValue("@numlot", s.txtNumLot.Text);
                    cmd.Parameters.AddWithValue("@expiration", expiration);
                    cmd.Parameters.AddWithValue("@cout_achat", Convert.ToDouble(s.txtCoutAchat.Text));
                    cmd.Parameters.AddWithValue("@prix_vente", Convert.ToDouble(s.txtPrixVente.Text));
                    cmd.Parameters.AddWithValue("@iddepot", s.iddepot);
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
                Annuler(s);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormStockNew s)
        {
            if (s.txtQteStock.Text != "" && s.txtNumLot.Text != "" && s.txtCoutAchat.Text != "" && s.txtPrixVente.Text != "" && s.cboDepot.Text != "")
            {
                idstock = Convert.ToInt32(s.Text.Substring(0, s.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("UPDATE ProduitStock SET idproduit = @idproduit, qteinit = @qteinit, numlot = @numlot, expiration = @expiration, cout_achat = @cout_achat, prix_vente = @prix_vente, iddepot = @iddepot WHERE idstock = @id", con);
                    cmd.Parameters.AddWithValue("@id", idstock);
                    cmd.Parameters.AddWithValue("@idproduit", s.idproduit);
                    cmd.Parameters.AddWithValue("@qteinit", s.txtQteStock.Text);
                    cmd.Parameters.AddWithValue("@numlot", s.txtNumLot.Text);
                    cmd.Parameters.AddWithValue("@expiration", expiration);
                    cmd.Parameters.AddWithValue("@cout_achat", Convert.ToDouble(s.txtCoutAchat.Text));
                    cmd.Parameters.AddWithValue("@prix_vente", Convert.ToDouble(s.txtPrixVente.Text));
                    cmd.Parameters.AddWithValue("@iddepot", s.iddepot);
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
                Annuler(s);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int VerifierStock(int idstock)//Ajouer cette methode dans Compter ==> ClassGen
        {
            //Dans CommandeLigne
            qte = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT COUNT(idstock) FROM CommnandeLigne WHERE idstock = " + idstock + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        qte = Convert.ToInt32(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            //Dans StockEntree
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT COUNT(idstock) FROM StockEntree WHERE idstock = " + idstock + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        qte += Convert.ToInt32(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            //Dans StockSortie
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT COUNT(idstock) FROM StockSortie WHERE idstock = " + idstock + "", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() != "")
                        qte += Convert.ToInt32(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return qte;
        }
        public void Supprimer(FormStock s)
        {
            if(VerifierStock(idstock)==0)
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM ProduitStock WHERE idstock = @id", con);
                    cmd.Parameters.AddWithValue("@id", idstock);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    s.btnSupprimer.Enabled = false;
                    s.dgvStock.Rows.RemoveAt(s.dgvStock.CurrentRow.Index);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
                MessageBox.Show("Ce stock est déjà impliqué dans les transactions dans le système et ne peut être supprimé","Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void SelectionDGV(FormStock s)
        {
            if(s.dgvStock.RowCount != 0)
            {
                idstock = Convert.ToInt32(s.dgvStock.CurrentRow.Cells[0].Value);
                s.btnModifier.Enabled = true;
                s.btnSupprimer.Enabled = true;
            }
        }

        public void ChargerDepot(ComboBox cbo)
        {
            ChargerCbo(cbo, "depot");
        }
        public int IDdepot(string nomdepot)
        {
            return TrouverID(nomdepot, "depot");
        }

        public void AfficherEntree(FormDepotEntree s)
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT se.identree, se.date_jour, p.nomcommercial, p.unite, ps.numlot, ps.expiration, se.qteajoute, se.libelle, d.nomdepot
                FROM   StockEntree AS se INNER JOIN
                ProduitStock AS ps ON se.idstock = ps.idstock INNER JOIN
                Produit AS p ON ps.idproduit = p.idproduit INNER JOIN
                Depot AS d ON se.iddepot = d.iddepot
                WHERE date_jour BETWEEN @dateDe AND @dateA AND d.iddepot = " + s.iddepot + "";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", s.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", s.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                s.dgvStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public void AfficherSortie(FormDepotSortie s)
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT ss.idsortie, ss.date_jour, p.nomcommercial, p.unite, ps.numlot, ps.expiration, ss.qtesortie, ss.libelle, d.nomdepot
                FROM   StockSortie AS ss INNER JOIN
                ProduitStock AS ps ON ss.idstock = ps.idstock INNER JOIN
                Produit AS p ON ps.idproduit = p.idproduit INNER JOIN
                Depot AS d ON ss.iddepot = d.iddepot
                WHERE date_jour BETWEEN @dateDe AND @dateA AND d.iddepot = "+s.iddepot+"";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", s.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", s.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                s.dgvStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void Annuler(FormDepotLivraison s)
        {
            s.txtDepot.Clear();
            s.txtLibelle.Clear();
            s.txtQteStock.Clear();
            s.txtQteServie.Clear();
            s.dtpDate.ResetText();
        }
        public void Enregistrer(FormDepotLivraison s)
        {
            if (s.txtQteServie.Text != "" && Convert.ToInt32(s.txtQteServie.Text) <= Convert.ToInt32(s.txtQteStock.Text))
            {
                idsortie = NouveauID("sortiestock");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO StockSortie VALUES (@id, @idstock, @date_jour, @qte, @libelle, @iddepot,@statut)", con);
                    cmd.Parameters.AddWithValue("@id", idsortie);
                    cmd.Parameters.AddWithValue("@idstock", s.idstock);
                    cmd.Parameters.AddWithValue("@date_jour", s.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@qte", Convert.ToInt32(s.txtQteServie.Text));
                    cmd.Parameters.AddWithValue("@libelle", s.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@iddepot", s.iddepot);
                    cmd.Parameters.AddWithValue("@statut", "RAS");
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Sortie avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                Annuler(s);
            }
            else
            {
                MessageBox.Show("Vérifiez que la quantité servie est inférieure ou égale au stock disponible", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void RetourEnStock(FormDepotLivraison s)
        {
            if (s.txtQteServie.Text != "")
            {
                idsortie = NouveauID("entreestock");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("INSERT INTO StockEntree VALUES (@id, @idstock, @date_jour, @qte, @libelle, @iddepot)", con);
                    cmd.Parameters.AddWithValue("@id", idsortie);
                    cmd.Parameters.AddWithValue("@idstock", s.idstock);
                    cmd.Parameters.AddWithValue("@date_jour", s.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@qte", Convert.ToInt32(s.txtQteServie.Text));
                    cmd.Parameters.AddWithValue("@libelle", s.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@iddepot", s.iddepot);
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
                Annuler(s);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormDepotSortie s)
        {
            if(s.poste=="depot")
            {
                if (TrouverAttribut(idsortie, "statutsortie") == "RAS")
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM StockSortie WHERE idsortie = @id", con);
                        cmd.Parameters.AddWithValue("@id", idsortie);
                        cmd.Transaction = tx;
                        cmd.ExecuteNonQuery();
                        tx.Commit();
                        MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        s.btnRetirer.Enabled = false;
                        s.dgvStock.Rows.RemoveAt(s.dgvStock.CurrentRow.Index);
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("Seul le gestionnaire de stock peut supprimer une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM StockSortie WHERE idsortie = @id", con);
                    cmd.Parameters.AddWithValue("@id", idsortie);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    s.btnRetirer.Enabled = false;
                    s.dgvStock.Rows.RemoveAt(s.dgvStock.CurrentRow.Index);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }                       
        }
        public void SelectionDGV(FormDepotSortie s)
        {
            if (s.dgvStock.RowCount != 0)
            {
                idsortie = Convert.ToInt32(s.dgvStock.CurrentRow.Cells[0].Value);
                s.btnRetirer.Enabled = true;
            }
        }
        public void Supprimer(FormDepotEntree s)
        {
            if (s.poste == "depot")
            {
                if (s.dgvStock.CurrentRow.Cells[7].Value.ToString().StartsWith("Retour: "))
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM StockSortie WHERE idsortie = @id", con);
                        cmd.Parameters.AddWithValue("@id", idsortie);
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
                    MessageBox.Show("Seul le gestionnaire de stock peut supprimer cette entrée", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM StockSortie WHERE idsortie = @id", con);
                    cmd.Parameters.AddWithValue("@id", idsortie);
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
            
        }
        public void Cloturer()
        {
            ClotureSortie();
        }
    }
}
