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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }
        ClassFactureFour f = new ClassFactureFour();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormFacture_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FormFactureNew fac = new FormFactureNew();
            fac.Text = string.Format("{0}-{1}", dgvFacture.CurrentRow.Cells[0].Value.ToString(), fac.Text);
            fac.txtMontant.Text = Convert.ToDouble(dgvFacture.CurrentRow.Cells[1].Value).ToString("0.00");
            fac.txtRemise.Text = Convert.ToDouble(dgvFacture.CurrentRow.Cells[2].Value).ToString("0.00");
            fac.dtpDate.Text = dgvFacture.CurrentRow.Cells[3].Value.ToString();
            fac.dtpTerme.Text = dgvFacture.CurrentRow.Cells[4].Value.ToString();
            fac.txtLibelle.Text = dgvFacture.CurrentRow.Cells[5].Value.ToString();
            fac.txtFichier.Text = dgvFacture.CurrentRow.Cells[6].Value.ToString();
            fac.txtFournisseur.Text = dgvFacture.CurrentRow.Cells[7].Value.ToString();
            fac.dtpDate.Select();           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            f.Supprimer(this);
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            f.OuvrirFacture();
        }

        private void dgvFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f.SelectionDGV(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            f.Afficher(this);
        }
    }
}
