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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }
        ClassConnexion c = new ClassConnexion();
        FormConnexion cn = new FormConnexion();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevision_Click(object sender, EventArgs e)
        {
            cn.poste = "manager";
            cn.Show();
            this.Hide();
        }

        private void btnTresorerie_Click(object sender, EventArgs e)
        {
            cn.poste = "tresorerie";
            c.ChargerCombo(cn);
            cn.Show();
            this.Hide();
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            cn.poste = "factura";
            c.ChargerCombo(cn);
            cn.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            cn.poste = "stock";
            cn.Show();
            this.Hide();
        }

        private void btnColis_Click(object sender, EventArgs e)
        {
            cn.poste = "colis";
            cn.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            cn.poste = "admin";
            cn.Show();
            this.Hide();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            cn.poste = "depot";
            c.ChargerCombo(cn);
            cn.Show();
            this.Hide();
        }
    }
}
