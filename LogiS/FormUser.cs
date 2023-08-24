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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            for (int i = 0; i < dgvUser.ColumnCount; i++)
            {
                dgvUser.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUtilisateur.Utilisateur' table. You can move, or remove it, as needed.
            //sthis.utilisateurTableAdapter.Fill(this.dataSetUtilisateur.Utilisateur);

        }
    }
}
