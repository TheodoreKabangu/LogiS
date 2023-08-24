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
    public partial class FormCommandeNew : Form
    {
        public FormCommandeNew()
        {
            InitializeComponent();
        }

        private void FormCommandeNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProduit.Produit' table. You can move, or remove it, as needed.
            //this.produitTableAdapter.Fill(this.dataSetProduit.Produit);

        }
        ClassPrevision p = new ClassPrevision();
        private void txtProduit_TextChanged(object sender, EventArgs e)
        {
            p.ChargerListe(txtProduit, dgvProduit, "produit");
        }
    }
}
