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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }
        public bool facturation, ajout_succes;
        ClassService s = new ClassService();
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            s.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            s.Modifier(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            s.Supprimer(this);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            ajout_succes = true;
            this.Hide();
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetService.Service' table. You can move, or remove it, as needed.
            //this.serviceTableAdapter.Fill(this.dataSetService.Service);

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            s.Afficher(txtNom, dgvService);
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvService.RowCount != 0)
                btnValider.Enabled = true;
        }
    }
}
