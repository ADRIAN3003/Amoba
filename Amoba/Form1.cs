using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amoba
{
    public partial class frmBeallitasok : Form
    {
        public frmBeallitasok()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbKorokSzama_CheckedChanged(object sender, EventArgs e)
        {
            tbKorokSzama.Enabled = cbKorokSzama.Checked;
        }

        private void btnKezdes_Click(object sender, EventArgs e)
        {
            if (tbJatekos1.Text.Length == 0 || tbJatekos2.Text.Length == 0)
            {
                MessageBox.Show("Nem adtál meg játékosnevet!");
            }
            else if (tbJatekos1.Text == tbJatekos2.Text)
            {
                MessageBox.Show("A két játékosnév egyezik!");
            } 
            else
            {
                this.Hide();
                frmJatek frmJatek = new frmJatek(tbJatekos1.Text, tbJatekos2.Text, cbKorokSzama.Checked ? Convert.ToInt32(tbKorokSzama.Text) : 0);
                frmJatek.Show();
            }
        }
    }
}
