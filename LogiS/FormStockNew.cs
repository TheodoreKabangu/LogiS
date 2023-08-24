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
    public partial class FormStockNew : Form
    {
        public FormStockNew()
        {
            InitializeComponent();
        }
        ClassStock s = new ClassStock();
        private void txtQteStock_TextChanged(object sender, EventArgs e)
        {
            s.TestValeurEntier(txtQteStock);
        }

        private void txtAnnee_TextChanged(object sender, EventArgs e)
        {
            s.TestValeurEntier(txtAnnee);
        }

        private void txtBenefice_TextChanged(object sender, EventArgs e)
        {
            s.TestValeurFloat(txtBenefice);
            if(txtBenefice.Text != "")
            {
                txtPrixVente.Text = (Convert.ToDouble(txtCoutAchat.Text) + Convert.ToDouble(txtCoutAchat.Text) * Convert.ToDouble(txtBenefice.Text) / 100).ToString("0.00");
                if(txtValMin.Text != "")
                    txtPrixVente.Text = (Convert.ToInt32(txtValMin.Text) * Math.Ceiling(Convert.ToDouble(txtPrixVente.Text) / Convert.ToInt32(txtValMin.Text))).ToString("0.00");
            }
        }

        private void txtCoutAchat_TextChanged(object sender, EventArgs e)
        {
            s.TestValeurFloat(txtBenefice);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            s.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            s.Enregistrer(this);
        }
        public int idproduit, iddepot = 0;
        private void btnModifier_Click(object sender, EventArgs e)
        {
            s.Modifier(this);
        }
        private void cboDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            iddepot = s.IDdepot(cboDepot.Text);
        }

        private void cboDepot_DropDown(object sender, EventArgs e)
        {
            s.ChargerDepot(cboDepot);
        }

        private void txtValMin_TextChanged(object sender, EventArgs e)
        {
            s.TestValeurEntier(txtValMin);
        }
    }
}
