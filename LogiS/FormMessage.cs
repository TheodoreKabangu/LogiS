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
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }
        ClassMessagerie m = new ClassMessagerie();
        private void FormMessage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {

        }

        private void FormMessage_Shown(object sender, EventArgs e)
        {
            m.Afficher(this);
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            
            //FormMessageNew 
            m.ModifierLu(this);
        }

        private void dgvMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m.SelectionDGV(this);
        }
    }
}
