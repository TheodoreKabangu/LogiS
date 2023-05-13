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
    public partial class FormPrevisionParVolume : Form
    {
        public FormPrevisionParVolume()
        {
            InitializeComponent();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvPrev.ColumnCount; i++)
            {
                dgvPrev.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
    }
}
