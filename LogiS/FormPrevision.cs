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
    public partial class FormPrevision : Form
    {
        public FormPrevision()
        {
            InitializeComponent();
            for (int i = 0; i < dgvCharge.ColumnCount; i++)
            {
                dgvCharge.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvPrev.ColumnCount; i++)
            {
                dgvPrev.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
        ClassPrevision p = new ClassPrevision();
        public bool recherche;
        private void FormPrevision_Shown(object sender, EventArgs e)
        {
            if (recherche)
                new FormPrevisionRecherche().ShowDialog();
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            new FormPays().ShowDialog();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            new FormProduit().ShowDialog();
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            p.AjouterCharge(this);
        }

        private void chbCharge_Click(object sender, EventArgs e)
        {
            if (chbCharge.Checked)
            {
                txtCharge.Enabled = true;
                txtCharge.Focus();
            }
            else
            {
                txtCharge.Clear();
                txtCharge.Enabled = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            p.Annuler(this);
        }
        ClassPays pa = new ClassPays();
        private void txtPays_TextChanged(object sender, EventArgs e)
        {
            p.ChargerListe(txtPays, dgvPays, "pays");
            if(txtPays.Text =="")
            {
                lblMonnaie.Text = txtTaux.Text = "";
            }
        }

        private void dgvPays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p.SelectionLigne(this, "pays");
        }

        private void FormPrevision_Load(object sender, EventArgs e)
        {
            
        }

        private void txtProduit_TextChanged(object sender, EventArgs e)
        {
            p.ChargerListe(txtProduit, dgvProduit, "produit");
        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p.SelectionLigne(this, "produit");
        }
        private void dgvPrev_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dgvPrev.CurrentCell.Value) >= 0)
                    p.CalculLigne(this);
                else
                {
                    MessageBox.Show("Valeur négative non autorisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvPrev.CurrentCell.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La valeur saisie est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvPrev.CurrentCell.Value = 0;
            }            
        }

        private void txtTaux_TextChanged(object sender, EventArgs e)
        {
            p.TestTaux(txtTaux);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            p.Enregistrer(this);
        }

        private void dgvCharge_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dgvCharge.CurrentRow.Cells[2].Value) >= 0)
                {
                    p.CalculerCharge(this);
                }
                else
                {
                    MessageBox.Show("Valeur négative non autorisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCharge.CurrentCell.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La valeur saisie est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvCharge.CurrentCell.Value = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculVolume_Click(object sender, EventArgs e)
        {
            p.CalculerParVolume(this, new FormPrevisionParVolume());
        }
    }
}
