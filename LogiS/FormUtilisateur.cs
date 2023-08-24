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
    public partial class FormUtilisateur : Form
    {
        public FormUtilisateur()
        {
            InitializeComponent();
        }
        ClassUser u = new ClassUser();
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            u.Annuler(this);
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            u.Enregistrer(this);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            u.Supprimer(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            u.Afficher(this);
        }

        private void cboPoste_DropDown(object sender, EventArgs e)
        {
            u.ChargerPoste(cboPoste);
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.RowCount != 0)
                btnSupprimer.Enabled = true;
        }

    }
}
