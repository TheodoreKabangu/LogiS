using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LogiS
{
    public partial class FormJournalOperation : Form
    {
        public FormJournalOperation()
        {
            InitializeComponent();
        }
        ClassTiers t = new ClassTiers();
        ClassClient c = new ClassClient();
        ClassFournisseur f = new ClassFournisseur();
        private void CalculTotal(string motif)
        {
            if(dgv.RowCount != 0)
            {
                if (Convert.ToInt32(dgv.Rows[dgv.RowCount - 1].Cells[0].Value) == 0)
                    dgv.Rows.RemoveAt(dgv.RowCount - 1);
                dgv.Rows.Add();
                dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
                dgv.Rows[dgv.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                dgv.Rows[dgv.RowCount - 1].Cells[0].Value = "";
                dgv.Rows[dgv.RowCount - 1].Cells[1].Value = "Total";
                dgv.Rows[dgv.RowCount - 1].Cells[2].Value = "";
                dgv.Rows[dgv.RowCount - 1].Cells[3].Value = 0;
                dgv.Rows[dgv.RowCount - 1].Cells[4].Value = 0;
                dgv.Rows[dgv.RowCount - 1].Cells[5].Value = 0;
                
                if(motif == "créance")
                {
                    dgv.Rows[dgv.RowCount - 1].Cells[3].Value = 0;
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        dgv.Rows[dgv.RowCount - 1].Cells[3].Value = Convert.ToDouble(dgv.Rows[dgv.RowCount - 1].Cells[3].Value) + Convert.ToDouble(dgv.Rows[i].Cells[3].Value);
                    }                   
                }
                else if (motif == "dette")
                {
                    dgv.Rows[dgv.RowCount - 1].Cells[4].Value = 0;
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        dgv.Rows[dgv.RowCount - 1].Cells[4].Value = Convert.ToDouble(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) + Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
                    }
                }
                else
                {
                    dgv.Rows[dgv.RowCount - 1].Cells[3].Value = 0;
                    dgv.Rows[dgv.RowCount - 1].Cells[4].Value = 0;

                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        dgv.Rows[dgv.RowCount - 1].Cells[3].Value = Convert.ToDouble(dgv.Rows[dgv.RowCount - 1].Cells[3].Value) + Convert.ToDouble(dgv.Rows[i].Cells[3].Value);
                        dgv.Rows[dgv.RowCount - 1].Cells[4].Value = Convert.ToDouble(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) + Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
                    }
                    dgv.Rows[dgv.RowCount - 1].Cells[5].Value = Convert.ToDouble(dgv.Rows[dgv.RowCount - 2].Cells[5].Value);
                }
            }
        }

        public bool facturefour,
            factureclient,
            payementfour,
            payementclient,
            soldefour,
            soldeclient,
            soldetiers;
        public string motif = "", concerne="";

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            switch (motif)
            {
                case "facturefour": 
                    f.JournalFour(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("dette");
                    concerne = "fournisseur";
                    break;
                case "payementfour": 
                    f.JournalFour(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("créance");
                    concerne = "fournisseur";
                    break;
                case "soldefour": 
                    f.JournalFour(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("solde");
                    concerne = "fournisseur";
                    break;
                case "factureclient": 
                    c.JournalClient(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("créance");
                    concerne = "client";
                    break;
                case "payementclient": 
                    c.JournalClient(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("dette");
                    concerne = "client";
                    break;
                case "soldeclient": 
                    c.JournalClient(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("solde");
                    concerne = "client";
                    break;
                case "soldetiers": 
                    t.JournalTiers(Convert.ToInt32(this.Text.Substring(0, this.Text.IndexOf("-"))), this);
                    CalculTotal("solde");
                    concerne = "tiers";
                    break;
            }
        }
        ReportDataSource rs = new ReportDataSource();
        FormImpression imp = new FormImpression();
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //switch (motif)
            //{
            //    case "facturefour":
                    
            //        break;
            //    case "payementfour":
                    
            //        break;
            //    case "soldefour":
                    
            //        break;
            //    case "factureclient":
            //        c.ImprimerJournal(this, new FormImpression());
            //        break;
            //    case "payementclient":
            //        c.ImprimerJournal(this, new FormImpression());
            //        break;
            //    case "soldeclient":
            //        c.ImprimerJournal(this, new FormImpression());
            //        break;
            //    case "soldetiers":
                    
            //        break;
            //}
            imp.Text = "Journal Opérations - LogiS";

            List<JournalOperation> list = new List<JournalOperation>();
            list.Clear();

            for (int i = 0; i < dgv.RowCount; i++)
            {
                JournalOperation o = new JournalOperation
                {
                    id = i + 1,
                    date_jour = dgv.Rows[i].Cells[1].Value.ToString(),
                    libelle = dgv.Rows[i].Cells[2].Value.ToString(),
                    creance = dgv.Rows[i].Cells[3].Value.ToString(),
                    dette = dgv.Rows[i].Cells[4].Value.ToString(),
                    solde = dgv.Rows[i].Cells[5].Value.ToString(),
                };
                list.Add(o);
            }
            ReportParameter[] rparams = new ReportParameter[]
            {
              new ReportParameter("concerne", concerne),
              new ReportParameter("noms", txtNom.Text),
            };
            rs.Name = "DataSet1";
            rs.Value = list;
            imp.reportViewer1.LocalReport.DataSources.Clear();
            imp.reportViewer1.LocalReport.DataSources.Add(rs);
            imp.reportViewer1.LocalReport.ReportEmbeddedResource = "LogiS.rpJournalClient.rdlc";
            imp.reportViewer1.LocalReport.SetParameters(rparams);
            imp.ShowDialog();
        }
    }

    public partial class JournalOperation
    {
        public int id { get; set; }
        public string date_jour { get; set; }
        public string libelle { get; set; }
        public string creance { get; set; }
        public string dette { get; set; }
        public string solde { get; set; }
    }
    public partial class JournalCreance
    {
        public int id { get; set; }
        public string date_jour { get; set; }
        public string libelle { get; set; }
        public string creance { get; set; }
        public string dette { get; set; }
        public string solde { get; set; }
    }
}
