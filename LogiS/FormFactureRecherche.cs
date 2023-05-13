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
    public partial class FormFactureRecherche : Form
    {
        public FormFactureRecherche()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFournis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFournis.RowCount != 0)
                dgvFournis.ContextMenuStrip = contextMenuStrip1;
        }

        private void FormFactureRecherche_Shown(object sender, EventArgs e)
        {
            //dgvFournis.Rows.Add(10);
        }

        private void btnTriDette_Click(object sender, EventArgs e)
        {
            if (btnTriDette.BackColor != Color.LightSteelBlue)
                btnTriDette.BackColor = Color.LightSteelBlue;
            else
                btnTriDette.BackColor = Color.Transparent;
        }
    }
}
