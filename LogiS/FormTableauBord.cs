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
    public partial class FormTableauBord : Form
    {
        public FormTableauBord()
        {
            InitializeComponent();
            for (int i = 0; i < dgvCaisse.ColumnCount; i++)
            {
                dgvCaisse.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvTiers.ColumnCount; i++)
            {
                dgvTiers.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvBanque.ColumnCount; i++)
            {
                dgvBanque.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvCmd.ColumnCount; i++)
            {
                dgvCmd.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            new FormUtilisateur().ShowDialog();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            new FormProduit().ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            new FormService().ShowDialog();
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            new FormPays().ShowDialog();
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            new FormCompteBancaire().ShowDialog();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            new FormFournisseur().ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new FormClient().ShowDialog();
        }

        private void btnTiers_Click(object sender, EventArgs e)
        {
            new FormTiersOperation().ShowDialog();
        }
        FormNouveauITem i;
        private void btnCaisse_Click(object sender, EventArgs e)
        {
            i = new FormNouveauITem();
            i.motif = "caisse";
            i.ShowDialog();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            i = new FormNouveauITem();
            i.motif = "depot";
            i.ShowDialog();
        }

        private void btnFacturier_Click(object sender, EventArgs e)
        {
            i = new FormNouveauITem();
            i.motif = "facturier";
            i.ShowDialog();
        }
    }
}
