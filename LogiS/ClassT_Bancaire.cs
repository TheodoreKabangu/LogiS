using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LogiS
{
    class ClassT_Bancaire: ClassGen
    {
        int idtransact;
        #region Operations
        public void Annuler(FormT_BancaireNew t)
        {
            t.dtpDate.ResetText();
            t.txtLibelle.Clear();
            t.txtMontant.Clear();
            t.txtFichier.Clear();
			t.dtpDate.Select();
        }
        public void Enregistrer(FormT_BancaireNew t)
        {
            if (t.cboCompte.Text != "" && t.txtMontant.Text != "" && t.txtLibelle.Text != "")
            {
                if (AjouterTBancaire(t.txtOperation.Text, t.txtFichier.Text, t.dtpDate.Text, t.txtMontant.Text, t.txtLibelle.Text, t.numcompte))
                {
                    MessageBox.Show("Ajouté avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Annuler(t);
                }
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modifier(FormT_BancaireNew t)
        {
            if (t.cboCompte.Text != "" && t.txtMontant.Text != "" && t.txtLibelle.Text != "")
            {
                idtransact = Convert.ToInt32(t.Text.Substring(0, t.Text.IndexOf("-")));
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (t.txtFichier.Text != "")
                    {
                        using (Stream stream = File.OpenRead(t.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(t.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;

                            cmd = new SqlCommand("UPDATE TransactionB SET date_jour = @date_jour, montant = @montant, libelle = @libelle, fichier = @fichier, nomfichier = @nomficher, extfichier = @ext, type_op = @type_op, numcompte = @numcompte WHERE idtransact = @id", con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                        }
                    }
                    else
                        cmd = new SqlCommand("UPDATE TransactionB SET date_jour = @date_jour, montant = @montant, libelle = @libelle, type_op = @type_op, numcompte = @numcompte WHERE idtransact = @id", con);
                    cmd.Parameters.AddWithValue("@id", idtransact);
                    cmd.Parameters.AddWithValue("@date_jour", t.dtpDate.Text);
                    cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(t.txtMontant.Text));
                    cmd.Parameters.AddWithValue("@libelle", t.txtLibelle.Text);
                    cmd.Parameters.AddWithValue("@type_op", t.txtOperation.Text);
                    cmd.Parameters.AddWithValue("@numcompte", t.cboCompte.Text);

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
                Annuler(t);
                t.Close();
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Supprimer(FormT_Bancaire t)
        {
            if(t.poste =="tresorerie")
            {
                if(TrouverAttribut(idtransact, "statuttransact")=="RAS")
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM TransactionB WHERE idtransact = @id", con);
                        cmd.Parameters.AddWithValue("@id", idtransact);
                        cmd.Transaction = tx;
                        cmd.ExecuteNonQuery();
                        tx.Commit();
                        MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        t.btnSupprimer.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("Seul l'administrateur peut supprimer une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    cmd = new SqlCommand("DELETE FROM TransactionB WHERE idtransact = @id", con);
                    cmd.Parameters.AddWithValue("@id", idtransact);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Mise à jour réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    t.btnSupprimer.Enabled = false;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            
        }
        public void SelectionDGV(FormT_Bancaire t)
        {
            if(t.dgvTransact.RowCount != 0)
            {
                idtransact = Convert.ToInt32(t.dgvTransact.CurrentRow.Cells[0].Value);
                t.btnVoir.Enabled = true;
                t.btnModifier.Enabled = true;
                t.btnSupprimer.Enabled = true;
                if (t.poste == "tresorerie")
                {
                    t.btnMessage.Enabled = true;
                }                    
            }
        }
        public void VoirFichier(FormT_Bancaire t)
        {
            OuvrirFichier(idtransact, "transaction");
        }
        public void ChargerCombo(ComboBox cbo, string motif)
        {
            ChargerCbo(cbo, motif);
        }
        public string NumCompte(string intitule)
        {
            string numcompte = "";
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT numcompte FROM CompteBancaire WHERE intitule = @intitule", con);
                cmd.Parameters.AddWithValue("@intitule", intitule);
                dr = cmd.ExecuteReader();
                dr.Read();
                numcompte = dr[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return numcompte;
        }
        public void TestValeurFloat(TextBox txt)
        {
            TestFloat(txt);
        }
        public void Afficher(FormT_Bancaire t, string motif)
        {
            con.Close();
            try
            {
                if(t.cboCompte.Text == "")
                {
                    if (motif == "recherche")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE date_jour BETWEEN @dateDe AND @dateA";
                    }
                    else if (motif == "min")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE montant >= '" + Convert.ToDouble(t.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA";
                    }
                    else if (motif == "max")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE montant <= '" + Convert.ToDouble(t.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA";
                    }
                }
                else
                {
                    if (motif == "recherche")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE date_jour BETWEEN @dateDe AND @dateA AND numcompte = '"+t.numcompte+"'";
                    }
                    else if (motif == "min")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE montant >= '" + Convert.ToDouble(t.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND numcompte = '" + t.numcompte + "'";
                    }
                    else if (motif == "max")
                    {
                        cmdtxt = @"SELECT idtransact, date_jour, montant, libelle, nomfichier, extfichier, type_op, numcompte 
                    FROM TransactionB WHERE montant <= '" + Convert.ToDouble(t.txtMontant.Text) + "' AND date_jour BETWEEN @dateDe AND @dateA AND numcompte = '" + t.numcompte + "'";
                    }
                }
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", t.dtpDateDe.Text);
                cmd.Parameters.AddWithValue("@dateA", t.dtpDateA.Text);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                t.dgvTransact.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public void Cloturer()
        {
            ClotureTransactionB();
        }
        public string Solde(string numcompte)
        {
            return SoldeBanque(numcompte).ToString("0.00");
        }
        public int IDcaisse(string nomcaisse)
        {
            return TrouverID(nomcaisse, "caisse");
        }
        public void SignalerAdmin(int id, int expediteur)
        {
            MessageAdmin(id, expediteur, "transaction bancaire");
        }
        private bool AjouterTBancaire(string type_op, string txtFichier, string date_jour, string montant, string libelle, string numcompte)
        {
            bool cmdstate = false;
            idtransact = NouveauID("transact");
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                if (txtFichier != "")
                {
                    using (Stream stream = File.OpenRead(txtFichier))
                    {
                        //binarisation du fichier preuve
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        var fichier = new FileInfo(txtFichier);
                        string ext = fichier.Extension;
                        string nomfichier = fichier.Name;

                        cmd = new SqlCommand("INSERT INTO TransactionB VALUES (@id, @date_jour, @montant, @libelle, @fichier, @nomficher, @ext, @type_op, @numcompte,@statut)", con);
                        cmd.Parameters.AddWithValue("@fichier", buffer);
                        cmd.Parameters.AddWithValue("@nomficher", nomfichier);
                        cmd.Parameters.AddWithValue("@ext", ext);
                    }
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO TransactionB(idtransact, date_jour, montant, libelle, type_op, numcompte, statut) VALUES (@id, @date_jour, @montant, @libelle, @type_op, @numcompte,@statut)", con);
                }
                cmd.Parameters.AddWithValue("@id", idtransact);
                cmd.Parameters.AddWithValue("@date_jour", date_jour);
                cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(montant));
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cmd.Parameters.AddWithValue("@type_op", type_op);
                cmd.Parameters.AddWithValue("@numcompte", numcompte);
                cmd.Parameters.AddWithValue("@statut", "RAS");

                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                cmdstate = true;
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return cmdstate;
        }
        ClassRecette r = new ClassRecette();
        ClassDepense d = new ClassDepense();
        private void Annuler(FormVirementFond v)
        {
            v.cboType.DropDownStyle = ComboBoxStyle.DropDown;
            v.cboType.SelectedText = "";
            v.cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            v.cboDe.Items.Clear();
            v.cboA.Items.Clear();
            v.txtMontant.Clear();
            v.txtLibelle.Clear();
            v.txtFichier.Clear();
            v.cboType.Select();
        }
        public void ValiderVirement(FormVirementFond v)
        {
            if(v.cboType.Text != "" && v.cboDe.Text != "" && v.cboA.Text != "" && v.txtMontant.Text != "" && v.txtLibelle.Text != "")
            {
                if (v.cboType.Text == "banque-banque")
                {
                    if (AjouterTBancaire("sortie", v.txtFichier.Text, v.dtpDate.Text, v.txtMontant.Text, v.txtLibelle.Text, v.numcompte1))
                    {
                        if (AjouterTBancaire("entrée", v.txtFichier.Text, v.dtpDate.Text, v.txtMontant.Text, v.txtLibelle.Text, v.numcompte2))
                        {
                            MessageBox.Show("Opération réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Annuler(v);
                        }
                    }
                }
                else if (v.cboType.Text == "caisse-caisse")
                {
                    if(d.AjouterDepense(v.dtpDate.Text, v.txtFichier.Text, v.txtMontant.Text, v.txtLibelle.Text, v.idcaisse1))
                    {
                        if(r.AjouterRecette(v.dtpDate.Text, v.txtFichier.Text, v.txtMontant.Text, v.txtLibelle.Text, v.idcaisse2))
                        {
                            MessageBox.Show("Opération réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Annuler(v);
                        }
                    }
                }
                else if (v.cboType.Text == "banque-caisse")
                {
                    if (AjouterTBancaire("sortie", v.txtFichier.Text, v.dtpDate.Text, v.txtMontant.Text, v.txtLibelle.Text, v.numcompte1))
                    {
                        if (r.AjouterRecette(v.dtpDate.Text, v.txtFichier.Text, v.txtMontant.Text, v.txtLibelle.Text, v.idcaisse2))
                        {
                            MessageBox.Show("Opération réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Annuler(v);
                        }
                    }
                }
                else if (v.cboType.Text == "caisse-banque")
                {
                    if (d.AjouterDepense(v.dtpDate.Text, v.txtFichier.Text, v.txtMontant.Text, v.txtLibelle.Text, v.idcaisse1))
                    {
                        if (AjouterTBancaire("entrée", v.txtFichier.Text, v.dtpDate.Text, v.txtMontant.Text, v.txtLibelle.Text, v.numcompte2))
                        {
                            MessageBox.Show("Opération réussie", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Annuler(v);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
