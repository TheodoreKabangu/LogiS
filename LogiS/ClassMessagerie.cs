using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace LogiS
{
    class ClassMessagerie: ClassGen
    {
        int idmsg;
        #region Opérations
        public void Annuler(FormMessageNew m)
        {
            m.txtCompte.Clear();
            m.txtObjet.Clear();
            m.txtMessage.Clear();
            m.txtFichier.Clear();
        }
        public void Envoyer(FormMessageNew m)
        {
            if(m.txtCompte.Text != "" && m.txtObjet.Text != "" && m.txtMessage.Text != "")
            {
                idmsg = NouveauID("msg");
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    if (m.txtFichier.Text == "")
                        cmd = new SqlCommand("INSERT INTO Message (idmessage, expediteur, destinataire, objet, msg, date_jour, heure, statutmsg) VALUES (@id, @exp, @dest, @objet, @msg, @date_jour, @heure, @statut)", con);
                    else
                    {
                        using (Stream stream = File.OpenRead(m.txtFichier.Text))
                        {
                            //binarisation du fichier preuve
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            var fichier = new FileInfo(m.txtFichier.Text);
                            string ext = fichier.Extension;
                            string nomfichier = fichier.Name;

                            cmd = new SqlCommand("INSERT INTO Message VALUES (@id, @exp, @dest, @objet, @msg, @date_jour, @heure, @statut, @fichier, @nomfichier, @ext)", con);
                            cmd.Parameters.AddWithValue("@fichier", buffer);
                            cmd.Parameters.AddWithValue("@nomfichier", nomfichier);
                            cmd.Parameters.AddWithValue("@ext", ext);
                        }                       
                    }
                    cmd.Parameters.AddWithValue("@id", idmsg);
                    cmd.Parameters.AddWithValue("@exp", m.expediteur);
                    cmd.Parameters.AddWithValue("@dest", m.destinataire);
                    cmd.Parameters.AddWithValue("@objet", m.txtObjet.Text);
                    cmd.Parameters.AddWithValue("@msg", m.txtMessage.Text);
                    cmd.Parameters.AddWithValue("@date_jour", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@heure", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@statut", "RAS");

                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Envoyé avec succès", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                Annuler(m);
            }
            else
            {
                MessageBox.Show("Désolé! Champs obligatoire(s) vide(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ModifierLu(FormMessage m)
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("UPDATE Message SET statutmsg = 'Lu' WHERE idmessage = "+idmsg+"", con);

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
        public void SelectionDGV(FormMessage m)
        {
            if(m.dgvMessage.RowCount != 0)
            {
                idmsg = Convert.ToInt32(m.dgvMessage.CurrentRow.Cells[0].Value);
                m.btnOuvrir.Enabled = true;
            }
        }
        public void Afficher(FormMessage m)
        {
            con.Close();
            try
            {
                if (m.txtExpediteur.Text != "")
                {
                    cmdtxt = @"SELECT idmessage, expediteur, objet, msg, date_jour, heure, nomfichier, statutmsg FROM Message WHERE date_jour BETWEEN @dateDe AND @dateA AND expediteur LIKE '" + m.txtExpediteur.Text.Replace("'", "") + "%'";
                }
                else
                    cmdtxt = @"SELECT idmessage, expediteur, objet, msg, date_jour, heure, nomfichier, statutmsg FROM Message WHERE date_jour BETWEEN @dateDe AND @dateA AND statutmsg = 'RAS'";
                cmd = new SqlCommand(cmdtxt, con);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                m.dgvMessage.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            if(m.dgvMessage.RowCount != 0)
            {
                for (int i = 0; i < m.dgvMessage.RowCount; i++)
                {
                    if (m.dgvMessage.Rows[i].Cells[7].Value.ToString() == "RAS")
                        m.dgvMessage.Rows[i].DefaultCellStyle.BackColor = m.dgvMessage.Rows[i].DefaultCellStyle.SelectionBackColor;
                }
            }
        }
        public void GenererCodeAdmin()
        {
            //Generer un code aléatoire qui permette à l'Admin de s'authentifier
            //et faire des opérations de MAJ sur les dépenses, recettes, Opératons tiers, etc.
            //le code sera généré, gardé derrière le form et envoyé comme un msg à l'admin.
            //Celui-ci ouvrira son interface et verra dans les msg le code et viendra le saisir
            //LogiS comparera le code saisi à celui qui a été envoyé pour valider ou non
            //l'opération demandée par l'admin.

        }
        #endregion
    }
}
