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
    public partial class FormProduitUnite : Form
    {
        public FormProduitUnite()
        {
            InitializeComponent();
            for (int i = 0; i < dgvUnite.ColumnCount; i++)
            {
                dgvUnite.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public bool succes;

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            succes = true;
            for (int i = 0; i < dgvUnite.RowCount; i++)
            {
                if (txtUnite.Text == dgvUnite.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Cette existe déjà dans la liste", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    succes = false;
                    i += dgvUnite.RowCount;
                }
            }
            if (succes)
            {
                dgvUnite.Rows.Add();
                dgvUnite.Rows[dgvUnite.RowCount - 1].Cells[0].Value = txtUnite.Text;
            }
        }
    }
}
