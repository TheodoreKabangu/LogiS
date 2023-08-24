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
    public partial class FormCommande : Form
    {
        public FormCommande()
        {
            InitializeComponent();
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCommande.Commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter.Fill(this.dataSetCommande.Commande);
            // TODO: This line of code loads data into the 'dataSetCommande.Commande' table. You can move, or remove it, as needed.
            //this.commandeTableAdapter.Fill(this.dataSetCommande.Commande);

        }

        private void btncmd_Click(object sender, EventArgs e)
        {
            new FormCmdDetail().ShowDialog();
        }

        private void btnEnvoi_Click(object sender, EventArgs e)
        {
            if (dgvCmd.CurrentRow.Cells[1].Value.ToString() == "brouillon")
            {
                new FormCmdDetail().ShowDialog();
            }
            else
                MessageBox.Show("La commande sélectionnée doit être au brouillon", "Statut commande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {

        }

        private void btnRecu_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
