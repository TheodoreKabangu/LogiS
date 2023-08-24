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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }
        ClassStock s = new ClassStock();
        public int iddepot;
        private void FormStock_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduit.RowCount != 0)
            {
                btnAjouter.Enabled = true;
                s.AfficherStock(this);
            }
        }

        private void btnMajProduit_Click(object sender, EventArgs e)
        {
            new FormProduit().ShowDialog();
        }
        FormStockNew sf= new FormStockNew();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            btnAjouter.Enabled = false;
            sf.idproduit = Convert.ToInt32(dgvProduit.CurrentRow.Cells[0].Value);
            sf.ShowDialog();
            s.AfficherStock(this);
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if(cboDepot.Text != "")
                s.AfficherProduitDepot(dgvProduit, txtProduit, iddepot);
            else
                s.AfficherProduitDepot(dgvProduit, txtProduit, 0);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            sf.Text = string.Format("{0}-{1}", dgvStock.CurrentRow.Cells[0].Value.ToString(), sf.Text);
            sf.idproduit = Convert.ToInt32(dgvProduit.CurrentRow.Cells[0].Value);
            sf.txtQteStock.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
            sf.txtNumLot.Text = dgvProduit.CurrentRow.Cells[2].Value.ToString();
            sf.txtCoutAchat.Text = Convert.ToDouble(dgvProduit.CurrentRow.Cells[4].Value).ToString();
            sf.txtPrixVente.Text = Convert.ToDouble(dgvProduit.CurrentRow.Cells[5].Value).ToString();
            sf.btnAjouter.Enabled = false;
            sf.btnModifier.Enabled = true;
            sf.ShowDialog();
            s.AfficherStock(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            s.Supprimer(this);
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s.SelectionDGV(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStock_Shown(object sender, EventArgs e)
        {
            btnAfficher_Click(null, null);
        }

        private void cboDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            iddepot = s.IDdepot(cboDepot.Text);
            s.AfficherProduitDepot(dgvProduit, txtProduit, iddepot);
        }

        private void cboDepot_DropDown(object sender, EventArgs e)
        {
            s.ChargerDepot(cboDepot);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            FormNouveauITem it = new FormNouveauITem();
            it.motif = "depot";
            it.Text = "Dépôt - LogiS";
            it.ShowDialog();
        }
    }
}
