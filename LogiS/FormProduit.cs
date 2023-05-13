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
    public partial class FormProduit : Form
    {
        public FormProduit()
        {
            InitializeComponent();
        }
        ClassProduit p = new ClassProduit();
        private void chbNomProduit_Click(object sender, EventArgs e)
        {
            if(chbNomProduit.Checked)
            {
                txtNomCom.Text = txtProduit.Text;
                txtNomCom.Enabled = false;
            }
            else
            {
                txtNomCom.Clear();
                txtNomCom.Enabled = true;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            p.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            p.Enregistrer(this);
        }

        private void FormProduit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProduit.Produit' table. You can move, or remove it, as needed.
            //this.produitTableAdapter.Fill(this.dataSetProduit.Produit);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            p.Modifier(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            p.Supprimer(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            p.Afficher(txtNomCom, dgvProduit);
        }

        private void dgvCharge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p.SelectionDGV(this);
        }

        private void txtPoids_TextChanged(object sender, EventArgs e)
        {
            p.TestValeurFloat(txtPoids);
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            p.TestValeurFloat(txtVolume);
        }
    }
}
