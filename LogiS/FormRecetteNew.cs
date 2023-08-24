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
    public partial class FormRecetteNew : Form
    {
        public FormRecetteNew()
        {
            InitializeComponent();

        }
        ClassClient c = new ClassClient();
        ClassRecette r = new ClassRecette();
        public int idcaisse,idclient;
        public bool recetteclient;
        private void FormRecetteNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClient.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.dataSetClient.Client);

        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            r.TestValeurFloat(txtMontant);
        }
        private void btnFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            r.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(recetteclient)
                r.AjouterRecette(this);
            else
                r.AjouterRecette(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            r.Modifier(this);
        }
    }
}
