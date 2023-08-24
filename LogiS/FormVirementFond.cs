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
    public partial class FormVirementFond : Form
    {
        public FormVirementFond()
        {
            InitializeComponent();
        }
        ClassT_Bancaire t = new ClassT_Bancaire(); 
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();
        }

        private void cboDe_DropDown(object sender, EventArgs e)
        {
            if (cboType.Text == "banque-banque")
            {
                t.ChargerCombo(cboDe, "banque");
            }
            else if(cboType.Text == "caisse-caisse")
            {
                t.ChargerCombo(cboDe, "caisse");
            }
            else if (cboType.Text == "banque-caisse")
            {
                //Charger les comptes bancaires puis les caisses
                t.ChargerCombo(cboDe, "banque");
            }
            else if (cboType.Text == "caisse-banque")
            {
                //Charger les caisses puis les comptes bancaires
                t.ChargerCombo(cboDe, "caisse");
            }
        }
        public string numcompte1, numcompte2;
        public int idcaisse1, idcaisse2;
        ClassRecette r = new ClassRecette();
        private void cboDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text == "banque-banque")
            {
                t.ChargerCombo(cboA, "banque");
                cboA.Items.Remove(cboDe.Text);
                numcompte1 = t.NumCompte(cboDe.Text);
                txtSolde1.Text = t.Solde(numcompte1);
            }
            else if (cboType.Text == "caisse-caisse")
            {
                t.ChargerCombo(cboA, "caisse");
                cboA.Items.Remove(cboDe.Text);
                idcaisse1 = t.IDcaisse(cboDe.Text);
                txtSolde1.Text = r.Solde(idcaisse1);
            }
            else if (cboType.Text == "banque-caisse")
            {
                //Charger les comptes bancaires puis les caisses
                t.ChargerCombo(cboA, "caisse");
                numcompte1 = t.NumCompte(cboDe.Text);
                txtSolde1.Text = t.Solde(numcompte1);
            }
            else if (cboType.Text == "caisse-banque")
            {
                //Charger les caisses puis les comptes bancaires
                t.ChargerCombo(cboA, "banque");
                idcaisse1 = t.IDcaisse(cboDe.Text);
                txtSolde1.Text = r.Solde(idcaisse1);
            }
        }

        private void cboA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text == "banque-banque")
            {
                numcompte2 = t.NumCompte(cboA.Text);
                txtSolde2.Text = t.Solde(numcompte2);
            }
            else if (cboType.Text == "caisse-caisse")
            {
                idcaisse2 = t.IDcaisse(cboA.Text);
                txtSolde2.Text = r.Solde(idcaisse2);
            }
            else if (cboType.Text == "banque-caisse")
            {
                //Charger les comptes bancaires puis les caisses
                idcaisse2 = t.IDcaisse(cboA.Text);
                txtSolde2.Text = r.Solde(idcaisse2);
            }
            else if (cboType.Text == "caisse-banque")
            {
                //Charger les caisses puis les comptes bancaires
                numcompte2 = t.NumCompte(cboA.Text);
                txtSolde2.Text = t.Solde(numcompte2);
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (cboDe.Text != "" && cboA.Text != "")
                t.TestValeurFloat(txtMontant);
            else
                MessageBox.Show("Sélectionnez l'origine et la destination de fonds", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtMontant_Leave(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txtMontant.Text)>Convert.ToDouble(txtSolde1.Text))
            {
                MessageBox.Show("Solde insuffisant pour ce montant", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontant.Select();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            t.ValiderVirement(this);
        }

        private void btnFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }
    }
}
