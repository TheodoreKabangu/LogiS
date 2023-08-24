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
    public partial class FormT_BancaireNew : Form
    {
        public FormT_BancaireNew()
        {
            InitializeComponent();
        }
        ClassT_Bancaire t = new ClassT_Bancaire();
        public string numcompte = "";
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

        private void btnCompte_Click(object sender, EventArgs e)
        {
            new FormCompteBancaire().ShowDialog();
        }

        private void cboCompte_DropDown(object sender, EventArgs e)
        {
            t.ChargerCombo(cboCompte, "intitulecompte");
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            t.TestValeurFloat(txtMontant);
        }
        
        private void cboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            numcompte = t.NumCompte(cboCompte.Text);
            txtLibelle.Focus();
        }
    }
}
