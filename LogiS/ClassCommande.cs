using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogiS
{
    class ClassCommande: ClassGen
    {
        #region Opérations
        public void SelectionStock(FormCommandeNew c, FormStockRecherche s)
        {
            //if (f.dgvProduit.RowCount != 0)
            //{
            //    f.txtProduit.Text = f.dgvProduit.CurrentRow.Cells[2].Value.ToString();
            //    f.dgvProduit.Visible = false;
            //    ps.Afficher(f.txtProduit, s.dgvStock);
            //    if (s.dgvStock.RowCount != 0)
            //    {
            //        s.facturation = true;
            //        s.txtProduit.Enabled = false;
            //        s.btnAfficher.Enabled = false;
            //        s.ShowDialog();
            //        if (s.ajout_succes)
            //        {
            //            if (f.dgvFacture.RowCount == 0)
            //            {
            //                f.dgvFacture.Rows.Add();
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvStock.CurrentRow.Cells[0].Value;
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = string.Format("{0}, {1} kg, {2} m3", f.txtProduit.Text, s.dgvStock.CurrentRow.Cells[2].Value, s.dgvStock.CurrentRow.Cells[3].Value);
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = s.dgvStock.CurrentRow.Cells[5].Value;
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = s.dgvStock.CurrentRow.Cells[6].Value;
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value) * Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value);

            //                //Total
            //                f.dgvFacture.Rows.Add();
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
            //                f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
            //                for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
            //                {
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
            //                }
            //            }
            //            else
            //            {
            //                f.stock_existe = false;
            //                for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
            //                {
            //                    if (s.dgvStock.CurrentRow.Cells[0].Value.ToString() == f.dgvFacture.Rows[i].Cells[0].Value.ToString())
            //                    {
            //                        f.stock_existe = true;
            //                        i += f.dgvFacture.RowCount;
            //                    }
            //                }
            //                if (!f.stock_existe)
            //                {
            //                    f.dgvFacture.Rows.RemoveAt(f.dgvFacture.RowCount - 1);

            //                    f.dgvFacture.Rows.Add();
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = s.dgvStock.CurrentRow.Cells[0].Value;
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = string.Format("{0}, {1} kg, {2} m3", f.txtProduit.Text, s.dgvStock.CurrentRow.Cells[2].Value, s.dgvStock.CurrentRow.Cells[3].Value);
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = s.dgvStock.CurrentRow.Cells[5].Value;
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = s.dgvStock.CurrentRow.Cells[6].Value;
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value) * Convert.ToInt32(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value);

            //                    //Total
            //                    f.dgvFacture.Rows.Add();
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.ForeColor = Color.MediumBlue;
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[0].Value = "";
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[1].Value = "Total général";
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[2].Value = "";
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[3].Value = "";
            //                    f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = 0;
            //                    for (int i = 0; i < f.dgvFacture.RowCount - 1; i++)
            //                    {
            //                        f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value = Convert.ToDouble(f.dgvFacture.Rows[f.dgvFacture.RowCount - 1].Cells[4].Value) + Convert.ToDouble(f.dgvFacture.Rows[i].Cells[4].Value);
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Le stock sélectionné existe déjà sur cette facture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    f.txtProduit.Focus();
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Désolé! Ce produit n'existe pas en stock", "Requête", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        f.txtProduit.Clear();
            //        f.txtProduit.Focus();
            //    }
            //}
        }
        #endregion
    }
}
