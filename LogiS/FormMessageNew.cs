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
    public partial class FormMessageNew : Form
    {
        public FormMessageNew()
        {
            InitializeComponent();
        }
        public int expediteur, destinataire;
        ClassMessagerie m = new ClassMessagerie();
        private void btnFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFichier.Text = dlg.FileName;
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            m.Envoyer(this);
        }

    }
}
