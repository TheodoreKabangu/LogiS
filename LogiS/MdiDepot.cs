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
    public partial class MdiDepot : Form
    {
        public MdiDepot()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public int iddepot = 0;
        private void AppelSousForm(MdiDepot d, FormDepotStock c)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = c;
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            d.pnlChildForm.Controls.Add(c);
            d.pnlChildForm.Tag = c;
            c.BringToFront();
            c.iddepot = d.iddepot;
            
            c.Show();
        }
        private void AppelSousForm(MdiDepot d, FormDepotEntree c)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = c;
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            d.pnlChildForm.Controls.Add(c);
            d.pnlChildForm.Tag = c;
            c.BringToFront();
            c.iddepot = d.iddepot;
            c.poste = "depot";
            c.cboDepot.Enabled = false;
            c.Show();
        }
        private void AppelSousForm(MdiDepot d, FormDepotSortie c)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = c;
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            d.pnlChildForm.Controls.Add(c);
            d.pnlChildForm.Tag = c;
            c.BringToFront();
            c.iddepot = d.iddepot;
            c.poste = "depot";
            c.cboDepot.Enabled = false;
            c.Show();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepotStock());
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepotEntree());
        }

        private void btnLivraison_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormDepotSortie());
        }
    }
}
