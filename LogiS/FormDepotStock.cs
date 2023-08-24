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
    public partial class FormDepotStock : Form
    {
        public FormDepotStock()
        {
            InitializeComponent();
            for (int i = 0; i < dgvProduit.ColumnCount; i++)
            {
                dgvProduit.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvStock.ColumnCount; i++)
            {
                dgvStock.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassStock s = new ClassStock();
        public int iddepot = 0;
        private void FormDepotStock_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            s.AfficherProduitDepot(dgvProduit, txtProduit, iddepot);
        }
        FormDepotLivraison l;
        private void btnLivrer_Click(object sender, EventArgs e)
        {
            l = new FormDepotLivraison();
            l.txtDepot.Text = dgvStock.CurrentRow.Cells[6].Value.ToString();
            l.txtLibelle.Text = string.Format("{0}, {1}, {2}", dgvProduit.CurrentRow.Cells[1].Value.ToString(), dgvStock.CurrentRow.Cells[2].Value.ToString(), dgvStock.CurrentRow.Cells[3].Value.ToString());
            l.txtQteStock.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            l.dtpDate.Select();
            l.iddepot = iddepot;
            l.idstock = Convert.ToInt32(dgvStock.CurrentRow.Cells[0].Value);
            l.operation = "sortie";
            l.ShowDialog();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //imprimer le stock dispo
            //d'abord Produit suivi d'un tableau de tous ses stocks
            //et ce, pour tous les produits
        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduit.RowCount != 0)
            {
                s.AfficherStock(this);
            }
        }

        private void FormDepotStock_Shown(object sender, EventArgs e)
        {
            btnAfficher_Click(null, null);
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvStock.RowCount != 0)
            {
                if(Convert.ToInt32(dgvStock.CurrentRow.Cells[1].Value)>0)
                    btnLivrer.Enabled = true;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            l = new FormDepotLivraison();
            l.txtDepot.Text = dgvStock.CurrentRow.Cells[6].Value.ToString();
            l.txtLibelle.Text = string.Format("Retour: {0}, {1}, {2}", dgvProduit.CurrentRow.Cells[1].Value.ToString(), dgvStock.CurrentRow.Cells[2].Value.ToString(), dgvStock.CurrentRow.Cells[3].Value.ToString());
            l.txtQteStock.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            l.dtpDate.Select();
            l.iddepot = iddepot;
            l.idstock = Convert.ToInt32(dgvStock.CurrentRow.Cells[0].Value);
            l.operation = "retour";
            l.Text = "Retour en stock - LogiS";
            l.ShowDialog();
        }
    }
}
