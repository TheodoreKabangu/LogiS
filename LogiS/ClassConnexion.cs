using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace LogiS
{
    class ClassConnexion: ClassGen
    {
        int id;
        string specification;
        #region Opérations
        public void Connexion(FormConnexion c)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT * FROM Utilisateur", con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if(dr[1].ToString()==c.txtUtilisateur.Text && dr[2].ToString()==c.txtMotdePass.Text && dr[3].ToString()==c.poste)
                    {
                        c.access_autorise = true;
                        id = int.Parse(dr[0].ToString());
                        specification = dr[4].ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            con.Close();
            if (c.access_autorise)
            {
                if (c.poste == "tresorerie")
                {
                    if (specification == c.cboUtilisateur.Text)
                    {
                        MdiTresorerie t = new MdiTresorerie();
                        t.idcaisse = TrouverID(specification, "caisse");
                        t.Show();
                    }
                    else
                    {
                        c.access_autorise = false;
                        MessageBox.Show("Accès refusé", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (c.poste == "factura")
                {
                    MdiFacturation f = new MdiFacturation();
                    //r.idutilisateur = id;
                    //RefuserAutorisation("infirmier - réception");
                    f.Show();
                }
                else if (c.poste == "manager")
                {
                    MdiPrevision p = new MdiPrevision();
                    //rec.idutilisateur = id;
                    //RefuserAutorisation("pharmacie - caisse");
                    p.Show();
                }
                else if (c.poste == "admin")
                {
                    MdiAdmin p = new MdiAdmin();
                    //rec.idutilisateur = id;
                    //RefuserAutorisation("pharmacie - caisse");
                    p.Show();
                }
                else if (c.poste == "stock")
                {
                    MdiStock p = new MdiStock();
                    //rec.idutilisateur = id;
                    //RefuserAutorisation("pharmacie - caisse");
                    p.Show();
                }
                else if (c.poste == "depot")
                {                    
                    if (specification == c.cboUtilisateur.Text)
                    {
                        MdiDepot p = new MdiDepot();
                        p.iddepot = TrouverID(specification, "depot");
                        p.Show();
                    }
                    else
                    {
                        c.access_autorise = false;
                        MessageBox.Show("Accès refusé", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (c.access_autorise)
                    c.Close();
            }
            else
                MessageBox.Show("Vérifiez que l'utilisateur et le mot de passe correspondent au poste sélectionné ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ChargerCombo(FormConnexion c)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT specification FROM Utilisateur WHERE poste= @poste", con); 
                cmd.Parameters.AddWithValue("@poste", c.poste);
                dr = cmd.ExecuteReader();
                c.cboUtilisateur.Items.Clear();
                while(dr.Read())
                {
                    c.cboUtilisateur.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if (c.cboUtilisateur.Items.Count>0) 
                c.cboUtilisateur.Enabled = true;
        }
        public void ModifierMotdePasse(FormConnexion c, FormConnexionPass cp)
        {
            cp.txtUtilisateur.Select();
            cp.poste = c.poste;
            cp.ShowDialog();
            if (cp.connexion)
            {
                c.txtUtilisateur.ForeColor = Color.Black;
                c.txtMotdePass.ForeColor = Color.Black;
                c.txtMotdePass.UseSystemPasswordChar = true;
                c.txtUtilisateur.Text = cp.txtUtilisateur.Text;
                c.txtMotdePass.Text = cp.txtConfirmerMdPass.Text;
                c.btnConnexion.Select();
            }
            cp.Close();
        }
        private int TestMotdePass(FormConnexionPass c)
        {
            id = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("select id from Utilisateur where utilisateur = @utilisateur and motdepasse = @mot and poste = @poste", con);
                cmd.Parameters.AddWithValue("@utilisateur", c.txtUtilisateur.Text);
                cmd.Parameters.AddWithValue("@mot", c.txtAncienMdPass.Text);
                cmd.Parameters.AddWithValue("@poste", c.poste);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    id = Convert.ToInt32(dr[0].ToString());
                }
                else
                    MessageBox.Show("Vérifiez que cet utilisateur et ce mot de passe existent pour le poste sélectionné ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            con.Close();
            return id;
        }

        public void Modifier(FormConnexionPass c)
        {
            c.idutilisateur = TestMotdePass(c);
            if (c.idutilisateur != 0)
            {
                if (c.txtNouveauMdPass.Text == c.txtConfirmerMdPass.Text && c.txtNouveauMdPass.Text != "111111" && c.txtNouveauMdPass.Text != "123456")
                {
                    if (c.txtNouveauMdPass.Text.Length >= 6)
                    {
                        con.Open();
                        SqlTransaction tx = con.BeginTransaction();
                        try
                        {
                            cmd = new SqlCommand("UPDATE Utilisateur SET motdepasse= @motdepasse where id= @id", con);
                            cmd.Parameters.AddWithValue("@id", c.idutilisateur);
                            cmd.Parameters.AddWithValue("@motdepasse", c.txtConfirmerMdPass.Text);
                            cmd.Transaction = tx;
                            cmd.ExecuteNonQuery();
                            tx.Commit();
                            if (MessageBox.Show("Modifié avec succès\n\rVoulez-vous vous connecter ?", "Mise à jour", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                c.connexion = true;
                                c.Hide();
                            }
                            else
                            {
                                c.connexion = false;
                                c.Hide();
                            }
                        }
                        catch (Exception ex)
                        {
                            tx.Rollback();
                            MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe doit avoir une taille miniamale de 8 caractères", "Valeur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        c.txtNouveauMdPass.Select();
                    }
                }
                else
                    MessageBox.Show("Confirmation du nouveau mot de passe invalide! \n\nLe mot de passe ne doit pas être si facile que 11111111 ou 12345678", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
