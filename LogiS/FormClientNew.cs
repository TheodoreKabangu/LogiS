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
    public partial class FormClientNew : Form
    {
        public FormClientNew()
        {
            InitializeComponent();
        }
        ClassClient c = new ClassClient();
        private void FormClientNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClient.Client' table. You can move, or remove it, as needed.
            
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            c.TestValeurEntier(txtTel);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            c.Annuler(this);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            c.Enregistrer(this);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            c.Modifier(this);
        }
    }
}
