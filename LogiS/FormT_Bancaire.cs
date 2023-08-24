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
    public partial class FormT_Bancaire : Form
    {
        public FormT_Bancaire()
        {
            InitializeComponent();
        }
        ClassT_Bancaire t = new ClassT_Bancaire();
        public string poste = "";
        private void FormT_Bancaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTransact.TransactionB' table. You can move, or remove it, as needed.
            //this.transactionBTableAdapter.Fill(this.dataSetTransact.TransactionB);
            t.Cloturer();
        }
        FormT_BancaireNew op;
        private void btnEntree_Click(object sender, EventArgs e)
        {
            op = new FormT_BancaireNew();
            op.txtOperation.Text = "entrée";
            op.dtpDate.Select();
            op.ShowDialog();
            op.Close();

        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            op = new FormT_BancaireNew();
            op.txtOperation.Text = "sortie";
            op.dtpDate.Select();
            op.ShowDialog();
            op.Close();
            FormT_Bancaire_Shown(null, null);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Même procédure pour Recette et Depense.
            op = new FormT_BancaireNew();
            op.Text = string.Format("{0}-{1}", dgvTransact.CurrentRow.Cells[0].Value, op.Text); 
            op.txtOperation.Text = dgvTransact.CurrentRow.Cells[6].Value.ToString();
            op.dtpDate.Text = dgvTransact.CurrentRow.Cells[1].Value.ToString();
            op.txtMontant.Text = dgvTransact.CurrentRow.Cells[2].Value.ToString();
            op.txtLibelle.Text = dgvTransact.CurrentRow.Cells[3].Value.ToString();
            op.dtpDate.Select();
            op.btnAjouter.Enabled = false;
            op.btnModifier.Enabled = true;
            op.ShowDialog();
            btnModifier.Enabled = false;
            FormT_Bancaire_Shown(null, null);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            t.Supprimer(this);
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            if (dgvTransact.RowCount != 0) 
                t.VoirFichier(this);
            btnVoir.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormT_Bancaire_Shown(null, null);
        }

        private void FormT_Bancaire_Shown(object sender, EventArgs e)
        {
            t.Afficher(this, "recherche");
        }

        private void dgvTransact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.SelectionDGV(this);
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMontant.Text != "")
            {
                t.Afficher(this, cbo.Text.ToLower());
            }
        }
        public string numcompte = "";
        private void cboCompte_DropDown(object sender, EventArgs e)
        {
            t.ChargerCombo(cboCompte, "intitulecompte");
        }

        private void cboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            numcompte = t.NumCompte(cboCompte.Text);
            dtpDateDe.Select();
        }
        public int idcaisse;
        private void btnMessage_Click(object sender, EventArgs e)
        {
            t.SignalerAdmin(Convert.ToInt32(dgvTransact.CurrentRow.Cells[0].Value), idcaisse);
        }
    }
}
