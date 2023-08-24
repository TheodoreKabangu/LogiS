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
using System.IO;

namespace LogiS
{
    class ClassGen
    {
        static string conString = ConfigurationManager.ConnectionStrings["LogiS.Properties.Settings.constring"].ConnectionString;
        protected SqlConnection con = new SqlConnection(conString);
        protected SqlCommand cmd;
        protected SqlDataAdapter da;
        protected SqlDataReader dr;
        protected DataTable dt = new DataTable();
        protected string cmdtxt;

        //Attributs
        private int id = 0;
        private string chaine = "";
        double valeur;
        //Opération générales
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
                    case "client": cmd = new SqlCommand("SELECT MAX(idclient) FROM Client", con); break;
                    case "recette": cmd = new SqlCommand("SELECT MAX(idrecette) FROM Recette", con); break;
                    case "depense": cmd = new SqlCommand("SELECT MAX(iddepense) FROM Depense", con); break;
                    case "fournisseur": cmd = new SqlCommand("SELECT MAX(idfour) FROM Fournisseur", con); break;
                    case "tiers": cmd = new SqlCommand("SELECT MAX(idtiers) FROM Tiers", con); break;
                    case "operation": cmd = new SqlCommand("SELECT MAX(idoperation) FROM OperationTiers", con); break;
                    case "factureclient": cmd = new SqlCommand("SELECT MAX(idfacture) FROM FactureClient", con); break;
                    case "factureclientligne": cmd = new SqlCommand("SELECT MAX(id) FROM FactureClientLigne", con); break;
                    case "factureclientligne2": cmd = new SqlCommand("SELECT MAX(id) FROM FactureClientLigne2", con); break;
                    case "service": cmd = new SqlCommand("SELECT MAX(idservice) FROM Service", con); break;
                    case "msg": cmd = new SqlCommand("SELECT MAX(idmessage) FROM Message", con); break;
                    case "transact": cmd = new SqlCommand("SELECT MAX(idtransact) FROM TransactionB", con); break;
                    case "entreestock": cmd = new SqlCommand("SELECT MAX(identree) FROM StockEntree", con); break;
                    case "sortiestock": cmd = new SqlCommand("SELECT MAX(idsortie) FROM StockSortie", con); break;
                    case "stock": cmd = new SqlCommand("SELECT MAX(idstock) FROM ProduitStock", con); break;
                    case "payementclient": cmd = new SqlCommand("SELECT MAX(idpayement) FROM PayementClient", con); break;
                    case "payementfour": cmd = new SqlCommand("SELECT MAX(idpayement) FROM PayementFournisseur", con); break;
                    case "facturefour": cmd = new SqlCommand("SELECT MAX(idfacture) FROM FactureFournisseur", con); break;
                    case "user": cmd = new SqlCommand("SELECT MAX(id) FROM Utilisateur", con); break;
                    case "depot": cmd = new SqlCommand("SELECT MAX(iddepot) FROM Depot", con); break;
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
        protected int TrouverID(string chaine, string objet)
        {
            id = 0;
            try
            {
                switch (objet)
                {
                    case "fournisseur": cmd = new SqlCommand("SELECT idfour FROM Fournisseur WHERE nomfour = '"+chaine+"'", con); break;
                    case "depot": cmd = new SqlCommand("SELECT iddepot FROM Depot WHERE nomdepot = '" + chaine + "'", con); break;
                    case "caisse": cmd = new SqlCommand("SELECT idcaisse FROM Caisse WHERE nomcaisse = '" + chaine + "'", con); break;
                }
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    id = Convert.ToInt32(dr[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
        protected string TrouverAttribut(int id, string objet)
        {
            chaine = "";
            con.Open();
            try
            {
                switch (objet)
                {
                    case "client": cmd = new SqlCommand("SELECT nomclient FROM Client WHERE idclient = "+id+"", con); break;
                    case "telclient": cmd = new SqlCommand("SELECT telephone FROM Client WHERE idclient = " + id + "", con); break;
                    case "emailclient": cmd = new SqlCommand("SELECT email FROM Client WHERE idclient = " + id + "", con); break;
                    case "fournisseur": cmd = new SqlCommand("SELECT nomfour FROM Fournisseur WHERE idfour = " + id + "", con); break;
                    case "utilisateur": cmd = new SqlCommand("SELECT utilisateur FROM Utilisateur WHERE id = " + id + "", con); break;
                    case "statutsortie": cmd = new SqlCommand("SELECT statut FROM StockSortie WHERE idsortie = " + id + "", con); break;
                    case "statuttransact": cmd = new SqlCommand("SELECT statut FROM TransactionB WHERE idtransact = " + id + "", con); break;
                }
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    chaine = dr[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return chaine;
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
                    case "clientoperation":
                        cmdtxt = @"SELECT ((SELECT COUNT(c.idclient) 
                        FROM Client c
                        JOIN PayementClient r ON r.idclient = c.idclient
                        WHERE c.idclient = @id)
                        +
                        (SELECT COUNT(f.idclient)
                        FROM Client c
                        JOIN FactureClient f ON f.idclient = c.idclient
                        WHERE c.idclient = @id))";
                        cmd = new SqlCommand(cmdtxt, con);
                        cmd.Parameters.AddWithValue("@id", id);
                        break;
                    case "fournisseuroperation":
                        cmdtxt = @"SELECT ((SELECT COUNT(f.idfour) 
                        FROM PayementFournisseur 
                        WHERE f.idfour = @id)
                        +
                        (SELECT COUNT(f.idfour)
                        FROM FactureFournisseur  
                        WHERE f.idfour = @id))";
                        cmd = new SqlCommand(cmdtxt, con);
                        cmd.Parameters.AddWithValue("@id", id);
                        break;
                    case "operationtiers": cmd = new SqlCommand("SELECT COUNT(idoperation) FROM OperationTiers WHERE idtiers = @id", con); 
                        cmd.Parameters.AddWithValue("@id", id);
                        break;
                }
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
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
        protected void TestEntier(TextBox txt)
        {
            if (txt.Text != "")
            {
                try
                {
                    long.Parse(txt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La valeur saisie est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
                }
            }
        }

        private double PayementClient(int idclient)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM PayementClient WHERE idclient= @id", con);
                cmd.Parameters.AddWithValue("@id", idclient);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        private double SommeFactureClient(int idclient)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant-remise) FROM FactureClient WHERE idclient= @id", con);
                cmd.Parameters.AddWithValue("@id", idclient);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }

        private double PayementFournisseur(int idfour)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM PayementFournisseur WHERE idfour= @id", con);
                cmd.Parameters.AddWithValue("@id", idfour);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        private double SommeFactureFournisseur(int idfour)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant-remise) FROM FactureFournisseur WHERE idfour= @id", con);
                cmd.Parameters.AddWithValue("@id", idfour);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }

        private double SommeOperationTiers(int idtiers, string categorie)
        {
            valeur = 0;
            con.Open();
            try
            {
                if (categorie == "creance")
                    cmd = new SqlCommand("SELECT SUM(montant) FROM OperationTiers WHERE categorie = 'créance' AND idtiers= @id", con);
                else
                    cmd = new SqlCommand("SELECT SUM(montant) FROM OperationTiers WHERE categorie = 'dette' AND idtiers= @id", con);
                cmd.Parameters.AddWithValue("@id", idtiers);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        protected void MontantReste(DataGridView dgv, string motif)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (motif == "client")
                    dgv.Rows[i].Cells[1].Value = SommeFactureClient(Convert.ToInt32(dgv.Rows[i].Cells[0].Value)) - PayementClient(Convert.ToInt32(dgv.Rows[i].Cells[0].Value));
                else if (motif == "fournisseur")
                    dgv.Rows[i].Cells[1].Value = PayementFournisseur(Convert.ToInt32(dgv.Rows[i].Cells[0].Value)) - SommeFactureFournisseur(Convert.ToInt32(dgv.Rows[i].Cells[0].Value));
                else
                    dgv.Rows[i].Cells[1].Value = SommeOperationTiers(Convert.ToInt32(dgv.Rows[i].Cells[0].Value), "creance") - SommeOperationTiers(Convert.ToInt32(dgv.Rows[i].Cells[0].Value), "dette");
            }
        }
        protected void AfficherTransaction(DateTimePicker dtDe, DateTimePicker dtA, DataGridView dgv, string motif)
        {
            con.Close();
            try
            {
                if(motif == "operationtiers")
                    cmdtxt = @"SELECT o.idoperation, o.date_jour, o.montant, o.libelle, o.nomfichier, o.extfichier, o.categorie, o.idtiers, t.nomtiers, o.statut
                    FROM   OperationTiers AS o INNER JOIN Tiers AS t ON o.idtiers = t.idtiers WHERE date_jour BETWEEN @dateDe AND @dateA";
                else if (motif == "factureclient")
                    cmdtxt = @"SELECT f.idfacture, f.idclient, f.date_facture, f.date_terme, f.montant, f.avance, f.remise, f.nomfichier, f.extfichier, c.nomclient
                    FROM   FactureClient AS f INNER JOIN Client AS c ON c.idclient = f.idclient WHERE date_facture BETWEEN @dateDe AND @dateA";
                cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@dateDe", dtDe.Text);
                cmd.Parameters.AddWithValue("@dateA", dtA.Text);
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
        protected int VerifierValeurUnique(string attribut, string objet)
        {
            id = 0;
            try
            {
                switch (objet)
                {
                    case "fournisseur": cmd = new SqlCommand("SELECT COUNT(nomfour) FROM Fournisseur WHERE nomfour = @nomfour", con);
                        cmd.Parameters.AddWithValue("@nomfour", attribut);
                        break;
                    case "comptebancaire": cmd = new SqlCommand("SELECT COUNT(numcompte) FROM CompteBancaire WHERE numcompte = @numcompte", con);
                        cmd.Parameters.AddWithValue("@numcompte", attribut);
                        break;
                }
                con.Open();            
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    id = int.Parse(dr[0].ToString());               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return id;
        }       
        private double SommeRecette(int idcaisse)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM Recette WHERE idcaisse = "+idcaisse+"", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        private double SommeDepense(int idcaisse)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM Depense WHERE idcaisse = " + idcaisse + "", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        protected double SoldeCaisse(int idcaisse)
        {
            return SommeRecette(idcaisse)-SommeDepense(idcaisse);
        }

        private double EntreeBanque(string numcompte)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM TransactionB WHERE numcompte = '"+numcompte+"' AND type_op = 'entrée'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        private double SortieBanque(string numcompte)
        {
            valeur = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT SUM(montant) FROM TransactionB WHERE numcompte = '" + numcompte + "' AND type_op = 'sortie'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != "")
                    valeur = Convert.ToDouble(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return valeur;
        }
        protected double SoldeBanque(string numcompte)
        {
            return EntreeBanque(numcompte) - SortieBanque(numcompte);
        }

        protected void OuvrirFichier(int id, string motif)
        {
            con.Open();
            try
            {
                if(motif == "recette")
                    cmd = new SqlCommand("SELECT fichier, nomfichier, extfichier FROM Recette WHERE idrecette = @id", con);
                else if (motif == "depense")
                    cmd = new SqlCommand("SELECT fichier, nomfichier, extfichier FROM Depense WHERE iddepense = @id", con);
                else if (motif == "transaction")
                    cmd = new SqlCommand("SELECT fichier, nomfichier, extfichier FROM TransactionB WHERE idtransact = @id", con);
                else if (motif == "facturefour")
                    cmd = new SqlCommand("SELECT fichier, nomfichier, extfichier FROM FactureFournisseur WHERE idfacture = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if (dr[1].ToString() != "")
                    {
                        var fichier = (byte[])dr[0];
                        var nomfichier = dr[1].ToString();
                        var ext = dr[2].ToString();
                        var newfile = nomfichier.Replace(ext, "");
                        File.WriteAllBytes(newfile, fichier);
                        System.Diagnostics.Process.Start(newfile);
                    }
                    else
                        MessageBox.Show("Pas de preuve attachée à cette opération", "Valeur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        protected void ChargerCbo(ComboBox cbo, string motif)
        {
            con.Open();
            try
            {
                switch (motif)
                {
                    case "intitulecompte":
                        cmd = new SqlCommand("SELECT intitule FROM CompteBancaire", con);
                        dr = cmd.ExecuteReader();
                        cbo.Items.Clear();
                        while(dr.Read())
                        {
                            cbo.Items.Add(dr[0].ToString());
                        }
                        break;
                    case "depot":
                        cmd = new SqlCommand("SELECT nomdepot FROM Depot", con);
                        dr = cmd.ExecuteReader();
                        cbo.Items.Clear();
                        while (dr.Read())
                        {
                            cbo.Items.Add(dr[0].ToString());
                        }
                        break;
                    case "banque":
                        cmd = new SqlCommand("SELECT intitule FROM CompteBancaire", con);
                        dr = cmd.ExecuteReader();
                        cbo.Items.Clear();
                        while (dr.Read())
                        {
                            cbo.Items.Add(dr[0].ToString());
                        }
                        break;
                    case "caisse":
                        cmd = new SqlCommand("SELECT nomcaisse FROM Caisse", con);
                        dr = cmd.ExecuteReader();
                        cbo.Items.Clear();
                        while (dr.Read())
                        {
                            cbo.Items.Add(dr[0].ToString());
                        }
                        break;
                    case "poste":
                        cmd = new SqlCommand("SELECT DISTINCT poste FROM Utilisateur", con);
                        dr = cmd.ExecuteReader();
                        cbo.Items.Clear();
                        while (dr.Read())
                        {
                            cbo.Items.Add(dr[0].ToString());
                        }
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        protected string ConvertirEnLettres(TextBox txt)
        {
            string chaine = "";
            if (txt.Text.Contains(","))
            {
                chaine = NumbersToWords(Convert.ToInt64(txt.Text.Substring(0, txt.Text.IndexOf(","))));
                chaine = string.Format("{0} virgule {1} en dollar américain", chaine, NumbersToWords(long.Parse(txt.Text.Substring(txt.Text.IndexOf(",") + 1))));
            }
            else chaine = NumbersToWords(long.Parse(txt.Text));
            return chaine;
        }
        private string NumbersToWords(long number)
        {
            if (number == 0) return "zéro";

            if (number < 0) return "moins " + NumbersToWords(Math.Abs(number));

            string words = "";
            //valeur de test : 156789
            if ((number / 1000000000) > 0)
            {
                if ((number / 1000000000) == 1)
                    words += NumbersToWords(number / 1000000000) + " milliard ";
                else
                    words += NumbersToWords(number / 1000000000) + " milliards ";

                number %= 1000000000;
            }
            if ((number / 1000000) > 0)
            {
                if ((number / 1000000) == 1)
                    words += NumbersToWords(number / 1000000) + " million ";
                else
                    words += NumbersToWords(number / 1000000) + " millions ";

                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                if ((number / 1000) > 1) words += NumbersToWords(number / 1000) + " milles ";
                else
                    words += "mille ";

                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                if ((number / 100) == 1)
                    words += "cent ";
                else
                    words += NumbersToWords(number / 100) + " cents ";

                number %= 100;
            }
            if (number > 0)
            {
                //if (words != "") words += " ";
                var unites = new[] { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix sept", "dix huit", "dix neuf" };
                var dizaines = new[] { "zéro", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "septante", "quatre-vingt", "nonante" };

                if (number < 20) words += unites[number];
                else
                {
                    words += dizaines[number / 10];
                    if ((number % 10) > 0)
                    {
                        if (unites[number % 10] == "un")
                            words += "-et-un";
                        else
                            words += " " + unites[number % 10];
                    }
                }
            }
            return words;
        }

        protected void MessageAdmin(int idtransact, int expediteur, string type)
        {
            var m = new FormMessageNew();
            m.txtCompte.Text = TrouverAttribut(0, "utilisateur");
            m.expediteur = expediteur;
            m.destinataire = 0;
            m.txtCompte.Enabled = false;
            m.txtObjet.Text = string.Format("MAJ {0} ID {1}", type, idtransact);
            m.txtObjet.Enabled = false;
            m.txtMessage.Focus();
            m.ShowDialog();
            m.Close();
        }
        
        List<string> dates = new List<string>();
        protected void ClotureRecette()
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT DISTINCT date_jour
                FROM Recette 
                WHERE statut IS NULL
                ORDER BY date_jour DESC";
                cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                dates.Clear();
                while(dr.Read())
                {
                    dates.Add(dr[0].ToString().Substring(0, 10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if(dates.Count > 0)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    if(dates[i]!= DateTime.Now.ToShortDateString())
                    {
                        con.Open();
                        try
                        {
                            cmd = new SqlCommand("UPDATE Recette SET statut = 'validé' WHERE date_jour = '" + dates[i] + "'", con);
                            cmd.ExecuteNonQuery();
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
        protected void ClotureDepense()
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT DISTINCT date_jour
                FROM Depense 
                WHERE statut IS NULL
                ORDER BY date_jour DESC";
                cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                dates.Clear();
                while (dr.Read())
                {
                    dates.Add(dr[0].ToString().Substring(0, 10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (dates.Count > 0)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i] != DateTime.Now.ToShortDateString())
                    {
                        con.Open();
                        try
                        {
                            cmd = new SqlCommand("UPDATE Depense SET statut = 'validé' WHERE date_jour = '" + dates[i] + "'", con);
                            cmd.ExecuteNonQuery();
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
        protected void ClotureTransactionB()
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT DISTINCT date_jour
                FROM TransactionB 
                WHERE statut IS NULL
                ORDER BY date_jour DESC";
                cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                dates.Clear();
                while (dr.Read())
                {
                    dates.Add(dr[0].ToString().Substring(0, 10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (dates.Count > 0)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i] != DateTime.Now.ToShortDateString())
                    {
                        con.Open();
                        try
                        {
                            cmd = new SqlCommand("UPDATE TransactionB SET statut = 'validé' WHERE date_jour = '" + dates[i] + "'", con);
                            cmd.ExecuteNonQuery();
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
        protected void ClotureSortie()
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT DISTINCT date_jour
                FROM StockSortie 
                WHERE statut IS NULL
                ORDER BY date_jour DESC";
                cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                dates.Clear();
                while (dr.Read())
                {
                    dates.Add(dr[0].ToString().Substring(0, 10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (dates.Count > 0)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i] != DateTime.Now.ToShortDateString())
                    {
                        con.Open();
                        try
                        {
                            cmd = new SqlCommand("UPDATE StockSortie SET statut = 'validé' WHERE date_jour = '" + dates[i] + "'", con);
                            cmd.ExecuteNonQuery();
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
        protected void CloturerOperationTiers()
        {
            con.Open();
            try
            {
                cmdtxt = @"SELECT DISTINCT date_jour
                FROM OperationTiers 
                WHERE statut IS NULL
                ORDER BY date_jour DESC";
                cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                dates.Clear();
                while (dr.Read())
                {
                    dates.Add(dr[0].ToString().Substring(0, 10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (dates.Count > 0)
            {
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i] != DateTime.Now.ToShortDateString())
                    {
                        con.Open();
                        try
                        {
                            cmd = new SqlCommand("UPDATE OperationTiers SET statut = 'validé' WHERE date_jour = '" + dates[i] + "'", con);
                            cmd.ExecuteNonQuery();
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
    }
}
