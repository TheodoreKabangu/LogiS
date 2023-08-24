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
    public partial class FormDepotEntree : Form
    {
        public FormDepotEntree()
        {
            InitializeComponent();
            for (int i = 0; i < dgvStock.ColumnCount; i++)
            {
                dgvStock.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassStock s = new ClassStock();
        public int iddepot;
        public string poste;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDepotEntree_Load(object sender, EventArgs e)
        {
        }

        private void cboDepot_DropDown(object sender, EventArgs e)
        {
            s.ChargerDepot(cboDepot);
        }

        private void cboDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            iddepot = s.IDdepot(cboDepot.Text);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            s.AfficherEntree(this);
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            s.Supprimer(this);               
        }
    }
}
