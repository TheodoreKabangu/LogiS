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
    public partial class MdiTresorerie : Form
    {
        public MdiTresorerie()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public int idcaisse;
        private void AppelSousForm(MdiTresorerie c, Form r)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = r;
            r.TopLevel = false;
            r.FormBorderStyle = FormBorderStyle.None;
            r.Dock = DockStyle.Fill;
            c.pnlChildForm.Controls.Add(r);
            c.pnlChildForm.Tag = r;
            r.BringToFront();

            r.Show();
        }
        private void AppelSousForm(MdiTresorerie c, FormRecette r)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = r;
            r.TopLevel = false;
            r.FormBorderStyle = FormBorderStyle.None;
            r.Dock = DockStyle.Fill;
            c.pnlChildForm.Controls.Add(r);
            c.pnlChildForm.Tag = r;
            r.BringToFront();
            r.poste = "tresorerie";
            r.idcaisse = c.idcaisse;
            r.Show();
        }
        private void AppelSousForm(MdiTresorerie c, FormDepense d)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = d;
            d.TopLevel = false;
            d.FormBorderStyle = FormBorderStyle.None;
            d.Dock = DockStyle.Fill;
            c.pnlChildForm.Controls.Add(d);
            c.pnlChildForm.Tag = d;
            d.BringToFront();
            d.poste = "tresorerie";
            d.idcaisse = c.idcaisse;
            d.Show();
        }
        private void AppelSousForm(MdiTresorerie c, FormClient r)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = r;
            r.TopLevel = false;
            r.FormBorderStyle = FormBorderStyle.None;
            r.Dock = DockStyle.Fill;
            c.pnlChildForm.Controls.Add(r);
            c.pnlChildForm.Tag = r;
            r.BringToFront();
            r.poste = "tresorerie";
            r.Show();
        }
        private void AppelSousForm(MdiTresorerie c, FormT_Bancaire t)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = t;
            t.TopLevel = false;
            t.FormBorderStyle = FormBorderStyle.None;
            t.Dock = DockStyle.Fill;
            c.pnlChildForm.Controls.Add(t);
            c.pnlChildForm.Tag = t;
            t.BringToFront();
            t.poste = "tresorerie";
            t.idcaisse = c.idcaisse;
            t.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecette_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormRecette());
            if (btnRecette.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnRecette.BackColor = Color.FromArgb(85, 85, 115);
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormClient());
            if (btnClient.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnClient.BackColor = Color.FromArgb(85, 85, 115);
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnDepense_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepense());
            if (btnDepense.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnDepense.BackColor = Color.FromArgb(85, 85, 115);
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnMessagerie_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormMessage());
            if (btnMessagerie.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 115);
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnCompteTiers_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormComptesTiers());
            if (btnCompteTiers.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 115);
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
        }      
        private void MdiCaisse_Shown(object sender, EventArgs e)
        {
            
        }

        private void btnTBancaire_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormT_Bancaire());
            if (btnTBancaire.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 115);
                btnRecette.BackColor = Color.FromArgb(85, 85, 137);
                btnDepense.BackColor = Color.FromArgb(85, 85, 137);
                btnCompteTiers.BackColor = Color.FromArgb(85, 85, 137);
                btnClient.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnTBancaire.BackColor = Color.FromArgb(85, 85, 137);
        }
    }
}
