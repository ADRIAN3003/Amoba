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
    }
}
