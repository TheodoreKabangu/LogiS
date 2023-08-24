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
    public partial class FormFactureJournal : Form
    {
        public FormFactureJournal()
        {
            InitializeComponent();
            for (int i = 0; i < dgvFour.ColumnCount; i++)
            {
                dgvFour.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormFactureRecherche_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
