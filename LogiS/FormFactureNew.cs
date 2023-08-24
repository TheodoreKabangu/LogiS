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
    public partial class FormFactureNew : Form
    {
        public FormFactureNew()
        {
            InitializeComponent();
        }
        public int idfour;
        ClassFactureFour f = new ClassFactureFour();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            f.Enregistrer(this);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            f.Modifier(this);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            f.TestValeurFloat(txtMontant);
        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {
            f.TestValeurFloat(txtRemise);
        }
    }
}
