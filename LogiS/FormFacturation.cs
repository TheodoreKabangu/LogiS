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
    public partial class FormFacturation : Form
    {
        public FormFacturation()
        {
            InitializeComponent();
            for (int i = 0; i < dgvFacture.ColumnCount; i++)
            {
                dgvFacture.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassFacturation f = new ClassFacturation();
        public string poste = "";
        private void FormFacturation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFactureClient.FactureClient' table. You can move, or remove it, as needed.
            //this.factureClientTableAdapter.Fill(this.dataSetFactureClient.FactureClient);
            
        }

        private void dgvFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f.SelectionDGV(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            f.Afficher(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            f.AnnulerFacture(this);
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            f.VoirFacture(this, new FormFacturationNew());
        }
    }
}
