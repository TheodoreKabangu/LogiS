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
    public partial class FormPays : Form
    {
        public FormPays()
        {
            InitializeComponent();
        }
        ClassPays p = new ClassPays();
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            p.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            p.Enregistrer(this);           
        }

        private void dgvPays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p.SelectionDGV(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            p.Afficher(txtPays, dgvPays);
        }

        private void FormPays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPays.Pays' table. You can move, or remove it, as needed.
            //this.paysTableAdapter.Fill(this.dataSetPays.Pays);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            p.Modifier(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            p.Supprimer(this);
        }
    }
}
