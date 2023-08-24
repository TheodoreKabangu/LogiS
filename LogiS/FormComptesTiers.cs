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
    public partial class FormComptesTiers : Form
    {
        public FormComptesTiers()
        {
            InitializeComponent();
            for (int i = 0; i < dgvTiers.ColumnCount; i++)
            {
                if (i != 1)
                    dgvTiers.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassTiers t = new ClassTiers();
        private void FormComptesTiers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTiers.Tiers' table. You can move, or remove it, as needed.
            //this.tiersTableAdapter.Fill(this.dataSetTiers.Tiers);
            t.Cloturer();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            new FormCompteTiersNew().ShowDialog();
            FormComptesTiers_Shown(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FormCompteTiersNew t = new FormCompteTiersNew();
            t.Text = string.Format("{0}-{1}", dgvTiers.CurrentRow.Cells[0].Value, t.Text);
            t.txtNom.Text = dgvTiers.CurrentRow.Cells[2].Value.ToString();
            if (dgvTiers.CurrentRow.Cells[3].Value.ToString().Substring(0, 1) == "+")
                t.txtTel.Text = dgvTiers.CurrentRow.Cells[3].Value.ToString().Substring(1);
            else
                t.txtTel.Text = dgvTiers.CurrentRow.Cells[3].Value.ToString();
            t.btnAjouter.Enabled = false;
            t.btnModifier.Enabled = true;
            t.ShowDialog();
            t.Close();
            FormComptesTiers_Shown(null, null);
        }

        private void dgvTiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.SelectionDGV(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormComptesTiers_Shown(null, null);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            t.Supprimer(this);
            FormComptesTiers_Shown(null, null);
        }
        FormTiersOperationNew op;
        private void btnCreance_Click(object sender, EventArgs e)
        {
            op = new FormTiersOperationNew();
            op.txtTypeOperation.Text = "créance";
            op.chbOperation.Text = "Décaisser";
            op.txtTiers.Text = string.Format("{0}, {1}", dgvTiers.CurrentRow.Cells[0].Value, dgvTiers.CurrentRow.Cells[2].Value);
            op.btnAjouter.Enabled = true;
            op.btnModifier.Enabled = false;
            op.txtMontant.Focus();           
            op.ShowDialog();
            op.Close();
            FormComptesTiers_Shown(null, null);
        }

        private void btnDette_Click(object sender, EventArgs e)
        {
            op = new FormTiersOperationNew();
            op.txtTypeOperation.Text = "dette";
            op.chbOperation.Text = "Encaisser";
            op.txtTiers.Text = string.Format("{0}, {1}", dgvTiers.CurrentRow.Cells[0].Value, dgvTiers.CurrentRow.Cells[2].Value);
            op.btnAjouter.Enabled = true;
            op.btnModifier.Enabled = false;
            op.txtMontant.Focus();
            op.ShowDialog();
            op.Close();
            FormComptesTiers_Shown(null, null);
        }

        private void btnVoirDetails_Click(object sender, EventArgs e)
        {
            FormJournalOperation j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations tiers - LogiS", dgvTiers.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvTiers.CurrentRow.Cells[2].Value.ToString();
            j.motif = "soldetiers";
            t.JournalTiers(Convert.ToInt32(dgvTiers.CurrentRow.Cells[0].Value), j);
            j.dgv.Columns[3].Visible = true;
            j.dgv.Columns[4].Visible = true;
            j.dgv.Columns[5].Visible = true;
            j.ShowDialog();
            j.Close();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            new FormTiersOperation().ShowDialog();
        }

        private void FormComptesTiers_Shown(object sender, EventArgs e)
        {
            t.Afficher(txtNom, dgvTiers);
            if (dgvTiers.RowCount != 0)
            {
                for (int i = 0; i < dgvTiers.RowCount; i++)
                {
                    if (Convert.ToDouble(dgvTiers.Rows[i].Cells[1].Value) < 0)
                    {
                        dgvTiers.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                        dgvTiers.Rows[i].Cells[1].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        dgvTiers.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                        dgvTiers.Rows[i].Cells[1].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
            }
        }
    }
}
