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
    public partial class MdiAdmin : Form
    {
        public MdiAdmin()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void AppelSousForm(MdiAdmin c, Form r)
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
        private void btnDashbord_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormTableauBord());
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVirement_Click(object sender, EventArgs e)
        {
            new FormVirementFond().ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormStock());
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormCommande());
        }
    }
}
