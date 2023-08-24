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
    public partial class FormRecette : Form
    {
        public FormRecette()
        {
            InitializeComponent();
            for (int i = 0; i < dgvRecette.ColumnCount; i++)
            {
                if(i != 2)
                    dgvRecette.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassRecette r = new ClassRecette();
        public string poste = "";
        public int idcaisse;
        private void FormRecette_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvRecette_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r.SelectionDGV(this);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            FormRecetteNew cc = new FormRecetteNew();
            cc.idcaisse = idcaisse;
            cc.ShowDialog();
            cc.Close();
            lblSolde.Text = r.Solde(idcaisse);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormRecette_Shown(null, null);
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            r.TestValeurFloat(txtMontant);
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMontant.Text != "")
            {
                if (cbo.Text == "Min")
                {
                    r.Afficher(this, "min");
                }
                else
                {
                    r.Afficher(this, "max");
                }
            }
        }

        private void FormRecette_Shown(object sender, EventArgs e)
        {
            r.Cloturer();
            r.Afficher(this, "recherche");
            lblSolde.Text = r.Solde(idcaisse);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (poste == "tresorerie")
            {
                if (dgvRecette.CurrentRow.Cells[6].Value.ToString() == "RAS")
                {
                    r.Supprimer(this);
                    FormRecette_Shown(null, null);
                }
                else
                    MessageBox.Show("Seul l'administrateur peut mettre à jour une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                r.Supprimer(this);
                FormRecette_Shown(null, null);
            }            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (poste == "tresorerie")
            {
                if (dgvRecette.CurrentRow.Cells[6].Value.ToString() == "RAS")
                {
                    FormRecetteNew c = new FormRecetteNew();
                    c.Text = string.Format("{0}-{1}", dgvRecette.CurrentRow.Cells[0].Value, c.Text);
                    c.dtpDate.Text = dgvRecette.CurrentRow.Cells[1].Value.ToString();
                    c.txtMontant.Text = dgvRecette.CurrentRow.Cells[2].Value.ToString();
                    c.txtLibelle.Text = dgvRecette.CurrentRow.Cells[3].Value.ToString();

                    c.btnAjouter.Enabled = false;
                    c.btnModifier.Enabled = true;

                    c.ShowDialog();
                    c.Close();
                    FormRecette_Shown(null, null);
                }
                else
                    MessageBox.Show("Seul l'administrateur peut mettre à jour une opération déjà validée", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormRecetteNew c = new FormRecetteNew();
                c.Text = string.Format("{0}-{1}", dgvRecette.CurrentRow.Cells[0].Value, c.Text);
                c.dtpDate.Text = dgvRecette.CurrentRow.Cells[1].Value.ToString();
                c.txtMontant.Text = dgvRecette.CurrentRow.Cells[2].Value.ToString();
                c.txtLibelle.Text = dgvRecette.CurrentRow.Cells[3].Value.ToString();

                c.btnAjouter.Enabled = false;
                c.btnModifier.Enabled = true;

                c.ShowDialog();
                c.Close();
                FormRecette_Shown(null, null);
            }
            
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            if (dgvRecette.RowCount != 0) 
                r.VoirFichier();
            btnVoir.Enabled = false;
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            r.SignalerAdmin(Convert.ToInt32(dgvRecette.CurrentRow.Cells[0].Value), idcaisse);
        }
    }
}
