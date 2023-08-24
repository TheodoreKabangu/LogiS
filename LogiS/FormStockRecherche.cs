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
    public partial class FormStockRecherche : Form
    {
        public FormStockRecherche()
        {
            InitializeComponent();
            for (int i = 0; i < dgvStock.ColumnCount; i++)
            {
                dgvStock.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public bool facturation, ajout_succes;
        ClassStock s = new ClassStock();
        private void FormStockRecherche_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStock.ProduitStock' table. You can move, or remove it, as needed.
            //this.produitStockTableAdapter.Fill(this.dataSetStock.ProduitStock);

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            s.Afficher(txtProduit, dgvStock);
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStock.RowCount != 0 && facturation)
                btnValider.Enabled = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvStock.CurrentRow.Cells[6].Value) > 0 && Convert.ToInt32(dgvStock.CurrentRow.Cells[1].Value) >= Convert.ToInt32(dgvStock.CurrentRow.Cells[6].Value))
                {
                    ajout_succes = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La quantité demandée doit être supérieure à 0 et inférieure à celle en stock", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La quantité demandée doit être un nombre entier supérieure à 0", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
