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
    public partial class FormCompteBancaire : Form
    {
        public FormCompteBancaire()
        {
            InitializeComponent();
        }
        ClassCompte c = new ClassCompte();
        private void FormCompteBancaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCompte.CompteBancaire' table. You can move, or remove it, as needed.
            //this.compteBancaireTableAdapter.Fill(this.dataSetCompte.CompteBancaire);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            c.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            c.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            c.Modifier(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            c.Supprimer(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            c.Afficher(txtLibelle, dgvCompte);
        }

        private void dgvCompte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c.SelectionDGV(this);
        }
    }
}
