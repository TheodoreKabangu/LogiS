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
    public partial class FormTiersOperationNew : Form
    {
        public FormTiersOperationNew()
        {
            InitializeComponent();
        }
        ClassTiers t = new ClassTiers();
        private void btnFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            t.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            t.Modifier(this);
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            t.TestValeurFloat(txtMontant);
        }

        private void chbOperation_Click(object sender, EventArgs e)
        {
            if (chbOperation.Checked && chbOperation.Text == "Décaisser")
                t.AjouterDepense(this, new FormDepenseNew());
            else if (chbOperation.Checked && chbOperation.Text == "Encaisser")
                t.AjouterRecette(this, new FormRecetteNew());
        }
    }
}
