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
    public partial class MdiPrevision : Form
    {
        public MdiPrevision()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
        private Form activeForm = null;
        private void AppelSousForm(MdiPrevision p, FormPrevision child, bool recherche)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            p.pnlChildForm.Controls.Add(child);
            p.pnlChildForm.Tag = child;
            child.BringToFront();
            if (recherche)
            {
                child.recherche = true;
                child.txtPays.Enabled = false;
                child.btnPays.Visible = false;
                //child.lblPays.Text = string.Format("{0} {1}", child.lblPays.Text, child.lblPays.Text); 
            }
            child.Show();
        }
        private void AppelSousForm(MdiPrevision p, Form child)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            p.pnlChildForm.Controls.Add(child);
            p.pnlChildForm.Tag = child;
            child.BringToFront();          
            child.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormPrevision(), true);
            if (btnOuvrir.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnOuvrir.BackColor = Color.FromArgb(85, 85, 115);
                btnFournisseur.BackColor = Color.FromArgb(85, 85, 137);
                btnPrevision.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnOuvrir.BackColor = Color.FromArgb(85, 85, 137);
        }
        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                panel2.Visible = false;
            else
                panel2.Visible = true;
            if(btnFournisseur.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnFournisseur.BackColor = Color.FromArgb(85, 85, 115);
                btnPrevision.BackColor = Color.FromArgb(85, 85, 137);
                btnOuvrir.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnFournisseur.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnPrevision_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormPrevision(), false);
            if (btnPrevision.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnPrevision.BackColor = Color.FromArgb(85, 85, 115);
                btnFournisseur.BackColor = Color.FromArgb(85, 85, 137);
                btnOuvrir.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnPrevision.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormFacture());
        }
        private void btnFourn_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormFournisseur());
        }
    }
}
