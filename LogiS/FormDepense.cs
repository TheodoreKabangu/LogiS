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
    public partial class FormDepense : Form
    {
        public FormDepense()
        {
            InitializeComponent();
            for (int i = 0; i < dgvDepense.ColumnCount; i++)
            {
                if (i != 2)
                    dgvDepense.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassDepense d = new ClassDepense();
        public string poste= "";
        public int idcaisse;
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            FormDepenseNew cc = new FormDepenseNew();
            cc.solde = Convert.ToDouble(lblSolde.Text);
            cc.idcaisse = idcaisse;
            cc.ShowDialog();
            cc.Close();
            lblSolde.Text = d.Solde(idcaisse);
        }

        private void FormDepense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDepense.Depense' table. You can move, or remove it, as needed.
            //this.depenseTableAdapter.Fill(this.dataSetDepense.Depense);

        }

        private void FormDepense_Shown(object sender, EventArgs e)
        {
            d.Cloturer();
            d.Afficher(this, "recherche");
            lblSolde.Text = d.Solde(idcaisse);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormDepense_Shown(null, null);
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            d.TestValeurFloat(txtMontant);
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMontant.Text != "")
            {
                if (cbo.Text == "Min")
                {
                    d.Afficher(this, "min");
                }
                else
                {
                    d.Afficher(this, "max");
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (poste == "tresorerie")
            {
                if (dgvDepense.CurrentRow.Cells[6].Value.ToString() == "RAS")
                {
                    FormDepenseNew c = new FormDepenseNew();
                    c.Text = string.Format("{0}-{1}", dgvDepense.CurrentRow.Cells[0].Value, c.Text);
                    c.dtpDate.Text = dgvDepense.CurrentRow.Cells[1].Value.ToString();
                    c.txtMontant.Text = dgvDepense.CurrentRow.Cells[2].Value.ToString();
                    c.txtLibelle.Text = dgvDepense.CurrentRow.Cells[3].Value.ToString();

                    c.btnAjouter.Enabled = false;
                    c.btnModifier.Enabled = true;

                    c.ShowDialog();
                    c.Close();
                    FormDepense_Shown(null, null);
                }
                else
                    MessageBox.Show("Seul l'administrateur peut mettre à jour une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormDepenseNew c = new FormDepenseNew();
                c.Text = string.Format("{0}-{1}", dgvDepense.CurrentRow.Cells[0].Value, c.Text);
                c.dtpDate.Text = dgvDepense.CurrentRow.Cells[1].Value.ToString();
                c.txtMontant.Text = dgvDepense.CurrentRow.Cells[2].Value.ToString();
                c.txtLibelle.Text = dgvDepense.CurrentRow.Cells[3].Value.ToString();

                c.btnAjouter.Enabled = false;
                c.btnModifier.Enabled = true;

                c.ShowDialog();
                c.Close();
                FormDepense_Shown(null, null);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (poste == "tresorerie")
            {
                if (dgvDepense.CurrentRow.Cells[6].Value.ToString() == "RAS")
                {
                    d.Supprimer(this);
                    FormDepense_Shown(null, null);
                }
                else
                    MessageBox.Show("Seul l'administrateur peut mettre à jour une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                d.Supprimer(this);
                FormDepense_Shown(null, null);
            }
        }

        private void dgvDepense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d.SelectionDGV(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            if (dgvDepense.RowCount != 0) 
                d.VoirFichier();
            btnVoir.Enabled = false;
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            d.SignalerAdmin(Convert.ToInt32(dgvDepense.CurrentRow.Cells[0].Value), idcaisse);
        }
    }
}
