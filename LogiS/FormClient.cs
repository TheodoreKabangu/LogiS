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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            for (int i = 0; i < dgvClient.ColumnCount; i++)
            {
                dgvClient.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        ClassClient cc = new ClassClient();
        public string poste = "";
        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClient.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.dataSetClient.Client);           
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            new FormClientNew().ShowDialog();
            FormClient_Shown(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FormClientNew c = new FormClientNew();
            c.Text = string.Format("{0}-{1}", dgvClient.CurrentRow.Cells[0].Value, c.Text);
            c.txtNom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            if (dgvClient.CurrentRow.Cells[3].Value.ToString().Substring(0, 1) == "+")
                c.txtTel.Text = dgvClient.CurrentRow.Cells[3].Value.ToString().Substring(1);
            else
                c.txtTel.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            c.txtEmail.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();

            c.btnAjouter.Enabled = false;
            c.btnModifier.Enabled = true;

            c.ShowDialog();
            c.Close();
            FormClient_Shown(null, null);
        }

        private void FormClient_Shown(object sender, EventArgs e)
        {
            cc.Afficher(txtNom, dgvClient);
            if (dgvClient.RowCount != 0)
            {
                for (int i = 0; i < dgvClient.RowCount; i++)
                {
                    if (Convert.ToDouble(dgvClient.Rows[i].Cells[1].Value) < 0)
                    {
                        dgvClient.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                        dgvClient.Rows[i].Cells[1].Style.SelectionBackColor = Color.IndianRed;
                    }
                    else
                    {
                        dgvClient.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                        dgvClient.Rows[i].Cells[1].Style.SelectionBackColor = Color.LightSteelBlue;
                    }
                }
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FormClient_Shown(null, null);
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cc.SelectionDGV(this);
        }
        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMontant.Text != "")
            {
                FormClient_Shown(null, null);
                if (cbo.Text == "Min")
                {
                    for (int i = dgvClient.RowCount - 1; i >= 0; i--)
                    {
                        if (Convert.ToDouble(dgvClient.Rows[i].Cells[1].Value) < Convert.ToDouble(txtMontant.Text))
                            dgvClient.Rows.RemoveAt(dgvClient.Rows[i].Index);
                    }
                }
                else
                {
                    for (int i = dgvClient.RowCount - 1; i >= 0; i--)
                    {
                        if (Convert.ToDouble(dgvClient.Rows[i].Cells[1].Value) > Convert.ToDouble(txtMontant.Text))
                            dgvClient.Rows.RemoveAt(dgvClient.Rows[i].Index);
                    }
                }
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            cc.TestValeurFloat(txtMontant);
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            FormRecetteNew cc = new FormRecetteNew();
            cc.txtLibelle.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            cc.txtPayeur.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            cc.txtPayeur.Enabled = false;
            cc.idclient = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value);
            cc.recetteclient = true;
            txtMontant.Focus();
            cc.ShowDialog();
            cc.Close();
            FormClient_Shown(null, null);
        }
        FormJournalOperation j;
        private void btnFacture_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations client - LogiS", dgvClient.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            j.motif = "factureclient";
            cc.JournalClient(Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value), j);
            j.dgv.Columns[3].HeaderText = "Facture";
            j.dgv.Columns[3].Visible = true;
            j.ShowDialog();
            j.Close();
        }

        private void btnPayement_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations client - LogiS", dgvClient.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            j.motif = "payementclient";
            cc.JournalClient(Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value), j);
            j.dgv.Columns[4].HeaderText = "Payement";
            j.dgv.Columns[4].Visible = true;
            j.ShowDialog();
            j.Close();
        }

        private void btnSolde_Click(object sender, EventArgs e)
        {
            j = new FormJournalOperation();
            j.Text = string.Format("{0}-Opérations client - LogiS", dgvClient.CurrentRow.Cells[0].Value);
            j.txtNom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            j.motif = "soldeclient";
            cc.JournalClient(Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value), j);
            
            j.dgv.Columns[3].HeaderText = "Facture";
            j.dgv.Columns[4].HeaderText = "Payement";
            j.dgv.Columns[3].Visible = true;
            j.dgv.Columns[4].Visible = true;
            j.dgv.Columns[5].Visible = true;
            j.ShowDialog();
            j.Close();
        }

        private void btnFacturer_Click(object sender, EventArgs e)
        {
            FormFacturationNew f = new FormFacturationNew();
            f.txtClient.Text = string.Format("{0}, {1}", dgvClient.CurrentRow.Cells[0].Value.ToString(), dgvClient.CurrentRow.Cells[2].Value.ToString());
            f.txtTypeFacture.Text = "définitive";
            f.btnEnregistrer.Enabled = true;
            f.ShowDialog();
            f.Close();
            FormClient_Shown(null, null);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cc.Supprimer(this);
            FormClient_Shown(null, null);
        }

        private void btnBanque_Click(object sender, EventArgs e)
        {
            FormT_BancaireNew t = new FormT_BancaireNew();
            t.txtOperation.Text = "entrée";
            t.txtLibelle.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            t.dtpDate.Select();
            t.ShowDialog();
            t.Close();
            FormClient_Shown(null, null);
        }
    }
}
