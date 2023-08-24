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
            for (int i = 0; i < dgvFour.ColumnCount; i++)
            {
                if(i != 1)
                    dgvFour.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassFournisseur f = new ClassFournisseur();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            new FormFournisseurNew().ShowDialog();
            FormFournisseur_Shown(null, null);
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            FormDepenseNew d = new FormDepenseNew();
            d.txtLibelle.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            d.txtBeneficiaire.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            d.txtBeneficiaire.Enabled = false;
            d.idfour = Convert.ToInt32(dgvFour.CurrentRow.Cells[0].Value);
            d.depensefour = true;
            txtMontant.Focus();
            d.ShowDialog();
            d.Close();
            FormFournisseur_Shown(null, null);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            FormFournisseurNew c = new FormFournisseurNew();
            c.txtNomFour.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            c.txtPersContact.Text = dgvFour.CurrentRow.Cells[3].Value.ToString();
            if (dgvFour.CurrentRow.Cells[4].Value.ToString().Substring(0, 1) == "+")
                c.txtTel.Text = dgvFour.CurrentRow.Cells[4].Value.ToString().Substring(1);
            else
                c.txtTel.Text = dgvFour.CurrentRow.Cells[4].Value.ToString();
            c.txtEmail.Text = dgvFour.CurrentRow.Cells[5].Value.ToString();
            c.txtNumCompte.Text = dgvFour.CurrentRow.Cells[6].Value.ToString();
            c.txtIntitule.Text = dgvFour.CurrentRow.Cells[7].Value.ToString();
            c.txtCodeSwift.Text = dgvFour.CurrentRow.Cells[8].Value.ToString();
            c.txtBanque.Text = dgvFour.CurrentRow.Cells[9].Value.ToString();
            c.txtPays.Text = dgvFour.CurrentRow.Cells[10].Value.ToString();
            c.idpays = Convert.ToInt32(dgvFour.CurrentRow.Cells[11].Value.ToString());
            c.Text = string.Format("{0}-{1}", dgvFour.CurrentRow.Cells[0].Value.ToString(), c.Text);
            c.dgvPays.Visible = false;
            c.btnAjouter.Enabled = false;
            c.btnModifier.Enabled = true;
            c.ShowDialog();
            c.Close();
            FormFournisseur_Shown(null, null);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormFournisseur_Shown(null, null);
        }

        private void dgvFour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            f.SelectionDGV(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            f.Supprimer(this);
            FormFournisseur_Shown(null, null);
        }
        FormJournalOperation j;
        private void btnFacture_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations fournisseur - LogiS", dgvFour.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            j.motif = "facturefour";
            f.JournalFour(Convert.ToInt32(dgvFour.CurrentRow.Cells[0].Value), j);
            j.ShowDialog();
            j.Close();
        }
        private void btnPayement_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations fournisseur - LogiS", dgvFour.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            j.motif = "payementfour";
            f.JournalFour(Convert.ToInt32(dgvFour.CurrentRow.Cells[0].Value), j);
            j.ShowDialog();
            j.Close();
        }

        private void btnSolde_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations fournisseur - LogiS", dgvFour.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            j.motif = "soldefour";
            f.JournalFour(Convert.ToInt32(dgvFour.CurrentRow.Cells[0].Value), j);
            j.ShowDialog();
            j.Close();
        }

        private void FormFournisseur_Shown(object sender, EventArgs e)
        {
            f.Afficher(txtNomFour, dgvFour);
            if (dgvFour.RowCount != 0)
            {
                for (int i = 0; i < dgvFour.RowCount; i++)
                {
                    if (Convert.ToDouble(dgvFour.Rows[i].Cells[1].Value) < 0)
                    {
                        dgvFour.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                        dgvFour.Rows[i].Cells[1].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        dgvFour.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                        dgvFour.Rows[i].Cells[1].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
            }
        }

        private void btnBanque_Click(object sender, EventArgs e)
        {
            FormT_BancaireNew t = new FormT_BancaireNew();
            t.txtOperation.Text = "sortie";
            FormFournisseur_Shown(null, null);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FormFactureNew f = new FormFactureNew();
            f.txtFournisseur.Text = dgvFour.CurrentRow.Cells[2].Value.ToString();
            f.idfour = Convert.ToInt32(dgvFour.CurrentRow.Cells[0].Value);
        }
    }
}
