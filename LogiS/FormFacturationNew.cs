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
    public partial class FormFacturationNew : Form
    {
        public FormFacturationNew()
        {
            InitializeComponent();
            for (int i = 0; i < dgvFacture.ColumnCount; i++)
            {
                dgvFacture.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassFacturation f = new ClassFacturation();
        public bool stock_existe;
        public string categorie = "produit";
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            f.Enregistrer(this);
            this.Close();
        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {
            f.TestValeurFloat(txtRemise);
        }

        private void FormFacturationNew_Load(object sender, EventArgs e)
        {
            
        }
        ClassPrevision p = new ClassPrevision();
        private void txtProduit_TextChanged(object sender, EventArgs e)
        {
            p.ChargerListe(txtProduit, dgvProduit, "produit");
        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f.SelectionStock(this, new FormStockRecherche());
        }

        private void btnProforma_Click(object sender, EventArgs e)
        {
            if (dgvFacture.RowCount > 0)
                f.GenererFacture(this, new FormImpression());
            else
                MessageBox.Show("Désolé! Aucune ligne de facture trouvée", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void chbService_Click(object sender, EventArgs e)
        {
            if (chbService.Checked)
            {

                txtProduit.Enabled = false;
                txtProduit.Clear();
                dgvFacture.Rows.Clear();
                dgvFacture.ReadOnly = false;
                btnService.Enabled = true;
                categorie = "service";
            }
            else
            {
                txtProduit.Enabled = true;
                dgvFacture.Rows.Clear();
                txtProduit.Focus();
                dgvFacture.ReadOnly = true;
                btnService.Enabled = false;
            }
        }

        private void dgvFacture_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dgvFacture.CurrentCell.Value) >= 0)
                    f.CalculFacture(this);
                else
                {
                    MessageBox.Show("Valeur négative non autorisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvFacture.CurrentCell.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La valeur saisie est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvFacture.CurrentCell.Value = 0;
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            f.SelectionService(this, new FormService());
        }
    }
}
