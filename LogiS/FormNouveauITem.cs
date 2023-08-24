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
    public partial class FormNouveauITem : Form
    {
        public FormNouveauITem()
        {
            InitializeComponent();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
               dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public string motif="";
        ClassNouvelItem n = new ClassNouvelItem();
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            n.Afficher(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            n.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            n.Modifier(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            n.Supprimer(this);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount != 0)
                txtItem.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
