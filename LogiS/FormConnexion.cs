using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiS
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        ClassConnexion c = new ClassConnexion();

        public bool access_autorise;
        public string poste;
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            new FormAccueil().Show();
            this.Close();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMotdePass.UseSystemPasswordChar = false;
            else
                txtMotdePass.UseSystemPasswordChar = true;
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            txtUtilisateur.Select();
        }

        private void txtMotdePass_Enter(object sender, EventArgs e)
        {
            if (txtMotdePass.Text == "Mot de passe")
                txtMotdePass.Text = "";
            txtMotdePass.ForeColor = Color.Black;
            if (!checkBox1.Checked)
                txtMotdePass.UseSystemPasswordChar = true;
        }

        private void txtUtilisateur_TextChanged(object sender, EventArgs e)
        {
            txtUtilisateur.ForeColor = Color.Black;
        }

        private void txtUtilisateur_Click(object sender, EventArgs e)
        {
            if (txtUtilisateur.Text == "Utilisateur")
                txtUtilisateur.Text = "";
            txtUtilisateur.ForeColor = Color.Black;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            c.Connexion(this);
        }

        private void linkModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c.ModifierMotdePasse(this, new FormConnexionPass());
        }
    }
}
