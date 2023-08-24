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
    public partial class FormDepenseNew : Form
    {
        public FormDepenseNew()
        {
            InitializeComponent();
            
        }
        public bool depensefour;
        ClassDepense d = new ClassDepense();
        public int idcaisse,idfour;
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            d.TestValeurFloat(txtMontant);
        }
        public double solde = 0;
        private void btnFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            d.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            d.AjouterDepense(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            d.Modifier(this);
        }
    }
}
