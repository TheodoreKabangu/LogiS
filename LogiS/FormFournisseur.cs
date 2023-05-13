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
    public partial class FormFournisseur : Form
    {
        public FormFournisseur()
        {
            InitializeComponent();
        }
        ClassFournisseur f = new ClassFournisseur();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFournisseur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFour.Fournisseur' table. You can move, or remove it, as needed.
            this.fournisseurTableAdapter.Fill(this.dataSetFour.Fournisseur);
            dgvFour.DataSource = this.dataSetFour.Fournisseur;
            f.MontantFournisseur(this);
        }
    }
}
