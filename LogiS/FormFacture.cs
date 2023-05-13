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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            new FormFactureNew().ShowDialog();
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFacture.Facture' table. You can move, or remove it, as needed.
            this.factureTableAdapter.Fill(this.dataSetFacture.Facture);

        }
    }
}
