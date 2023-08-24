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
    public partial class FormTiersOperation : Form
    {
        public FormTiersOperation()
        {
            InitializeComponent();
        }
        ClassTiers t = new ClassTiers();
        private void FormTiersOperation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetOperationTiers.OperationTiers' table. You can move, or remove it, as needed.
            //this.operationTiersTableAdapter.Fill(this.dataSetOperationTiers.OperationTiers);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            FormTiersOperationNew op = new FormTiersOperationNew();
            op.Text = string.Format("{0}-{1}", dgvOperation.CurrentRow.Cells[0].Value, op.Text); 
            op.txtTypeOperation.Text = dgvOperation.CurrentRow.Cells[6].Value.ToString();
            if (op.txtTypeOperation.Text=="dette")
                op.chbOperation.Text = "Encaisser";
            else
                op.chbOperation.Text = "Décaisser";
            op.txtTiers.Text = string.Format("{0}, {1}", dgvOperation.CurrentRow.Cells[7].Value, dgvOperation.CurrentRow.Cells[8].Value);
            op.txtMontant.Text = Convert.ToDouble(dgvOperation.CurrentRow.Cells[2].Value).ToString();
            op.txtLibelle.Text = dgvOperation.CurrentRow.Cells[3].Value.ToString();
            op.btnAjouter.Enabled = false;
            op.btnModifier.Enabled = true;
            op.txtMontant.Focus();
            op.ShowDialog();
            op.Close();
        }

        private void dgvOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t.SelectionDGV(this);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            t.Afficher(dtpDateDe, dtpDateA, dgvOperation);
            if(dgvOperation.RowCount != 0)
            {
                for (int i = 0; i < dgvOperation.RowCount; i++)
                {
                    if (dgvOperation.Rows[i].Cells[6].Value.ToString() == "dette")
                    {
                        dgvOperation.Rows[i].Cells[2].Style.BackColor = Color.IndianRed;
                        dgvOperation.Rows[i].Cells[2].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        dgvOperation.Rows[i].Cells[2].Style.BackColor = Color.LightSteelBlue;
                        dgvOperation.Rows[i].Cells[2].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
            }
        }

        private void FormTiersOperation_Shown(object sender, EventArgs e)
        {
            btnAfficher_Click(null, null);
        }

        private void btnVoir_Click(object sender, EventArgs e)
        {
            if (dgvOperation.RowCount != 0)
                t.VoirFichier();
            btnVoir.Enabled = false;
        }
    }
}
