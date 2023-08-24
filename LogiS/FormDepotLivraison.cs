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
    public partial class FormDepotLivraison : Form
    {
        public FormDepotLivraison()
        {
            InitializeComponent();
        }
        public int iddepot, idstock;
        public string operation;
        ClassStock s = new ClassStock();
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (operation == "sortie")
                s.Enregistrer(this);
            else if (operation == "retour")
                s.RetourEnStock(this);
        }
    }
}
