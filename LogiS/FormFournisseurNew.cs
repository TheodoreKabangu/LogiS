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
    public partial class FormFournisseurNew : Form
    {
        public FormFournisseurNew()
        {
            InitializeComponent();
        }

        private void FormFournisseurNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPays.Pays' table. You can move, or remove it, as needed.
            //this.paysTableAdapter.Fill(this.dataSetPays.Pays);
        }
        ClassFournisseur f = new ClassFournisseur();
        ClassPays p = new ClassPays();
        public int idpays;
        private void txtPays_TextChanged(object sender, EventArgs e)
        {
            if(txtPays.Text != "")
            {
                p.Afficher(txtPays, dgvPays);
                if (dgvPays.RowCount > 0)
                {
                    dgvPays.BringToFront();
                    dgvPays.Visible = true;
                }
                else
                    dgvPays.Visible = false;
            }
            else
            {
                dgvPays.DataSource = null;
                dgvPays.Visible = false;
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            f.TestValeurEntier(txtTel);
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            new FormPays().ShowDialog();
        }

        private void dgvPays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPays.RowCount != 0)
            {
                txtPays.Text = dgvPays.CurrentRow.Cells[1].Value.ToString();
                idpays = Convert.ToInt32(dgvPays.CurrentRow.Cells[0].Value.ToString());
                dgvPays.Visible = false;
                txtPays.Enabled = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtPays.Enabled)
                MessageBox.Show("Pays inexistant dans le système! Sélectionnez un pays existant ou ajoutez-en un nouveau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                f.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            f.Modifier(this);
        }
    }
}
