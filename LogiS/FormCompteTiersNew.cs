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
    public partial class FormCompteTiersNew : Form
    {
        public FormCompteTiersNew()
        {
            InitializeComponent();
        }

        private void FormTiers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTiers.Tiers' table. You can move, or remove it, as needed.
            //this.tiersTableAdapter.Fill(this.dataSetTiers.Tiers);

        }
        ClassTiers t = new ClassTiers();
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            t.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            t.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            t.Modifier(this);
        }
    }
}
