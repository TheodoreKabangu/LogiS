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
    public partial class MdiStock : Form
    {
        public MdiStock()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void AppelSousForm(MdiStock c, Form r)
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
        private void AppelSousForm(MdiStock c, FormDepotEntree r)
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
            r.poste = "stock";
            r.Show();
        }
        private void AppelSousForm(MdiStock c, FormDepotSortie r)
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
            r.poste = "stock";
            r.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormStock());
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormCommande());
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepotEntree());
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepotSortie());
        }
    }
}
