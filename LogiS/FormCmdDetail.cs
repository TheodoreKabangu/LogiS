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
    public partial class FormCmdDetail : Form
    {
        public FormCmdDetail()
        {
            InitializeComponent();
        }

        private void FormCmdDetail_Load(object sender, EventArgs e)
        {
             string cmd = @"SELECT cl.id, cl.idstock, p.nomcommercial, cl.qtecom, cl.qte_envoye, cl.qte_arrive, cl.qte_entre
             FROM   CommandeLigne AS cl INNER JOIN
             ProduitStock AS s ON cl.idstock = s.idstock INNER JOIN
             Produit AS p ON p.idproduit = s.idproduit";

        }
    }
}
