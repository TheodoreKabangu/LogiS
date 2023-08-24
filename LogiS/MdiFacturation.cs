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
    public partial class MdiFacturation : Form
    {
        public MdiFacturation()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void AppelSousForm(MdiFacturation c, FormClient r)
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
            r.poste = "facturation";
            r.dgvClient.Columns[1].Visible = false;
            r.Show();
        }
        private void AppelSousForm(MdiFacturation c, FormFacturation r)
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
            r.poste = "facturation";
            r.Show();
        }
        private void AppelSousForm(MdiFacturation c, FormFacturationNew f)
        {
            f.txtTypeFacture.Text = "proforma";
            f.txtClient.Enabled = true;
            f.txtRemise.Enabled = false;
            f.txtLibelle.Enabled = false;
            f.btnProforma.Enabled = true;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
        private void btnFacturer_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormClient());
            if (btnFacturer.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnFacturer.BackColor = Color.FromArgb(85, 85, 115);
                btnFacture.BackColor = Color.FromArgb(85, 85, 137);
                btnProforma.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnFacturer.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormFacturation());
            if (btnFacture.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnFacture.BackColor = Color.FromArgb(85, 85, 115);
                btnFacturer.BackColor = Color.FromArgb(85, 85, 137);
                btnProforma.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnFacture.BackColor = Color.FromArgb(85, 85, 137);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProforma_Click(object sender, EventArgs e)
        {
            AppelSousForm(this, new FormFacturationNew());
            if (btnProforma.BackColor != Color.FromArgb(85, 85, 115))
            {
                btnProforma.BackColor = Color.FromArgb(85, 85, 115);
                btnFacturer.BackColor = Color.FromArgb(85, 85, 137);
                btnFacture.BackColor = Color.FromArgb(85, 85, 137);
                btnMessagerie.BackColor = Color.FromArgb(85, 85, 137);
            }
            else
                btnProforma.BackColor = Color.FromArgb(85, 85, 137);
        }
    }
}
