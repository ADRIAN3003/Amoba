using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTTDll;

namespace Amoba
{
    public partial class frmJatek : Form
    {
        string jatekos1;
        string jatekos2;
        int korok;
        TicTacToe game;
        int jelenlegiKor = 0;
        public frmJatek(string jatekos1, string jatekos2, int korok)
        {
            InitializeComponent();
            this.jatekos1 = jatekos1;
            this.jatekos2 = jatekos2;
            this.korok = korok;

            this.Text += " | " + jatekos1 + " - " + jatekos2;

            lblJatekos1.Text = jatekos1 + " (X)";
            lblJatekos2.Text = jatekos2 + " (O)";

            UjJatek();
        }

        private void frmJatek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            string[] soroszlop = btn.Name.Replace("button", "").Split('_');
            string kilep = game.KiLep();
            if (game.Lepes(Convert.ToInt32(soroszlop[0]), Convert.ToInt32(soroszlop[1])))
            {
                btn.Enabled = false;
                btn.Text = kilep == jatekos1 ? "X" : "O";
                lblKovetkezo.Text = game.KiLep() + " következik";
                if (game.KiLep() == jatekos1)
                {
                    lblJatekos1.ForeColor = Color.Green;
                    lblJatekos1.BackColor = Color.LightGreen;
                    lblJatekos2.ForeColor = Color.Black;
                    lblJatekos2.BackColor = SystemColors.Control;
                } 
                else
                {
                    lblJatekos2.ForeColor = Color.Green;
                    lblJatekos2.BackColor = Color.LightGreen;
                    lblJatekos1.ForeColor = Color.Black;
                    lblJatekos1.BackColor = SystemColors.Control;
                }
            }
            if (game.Gyozelem || game.Dontetlen)
            {
                if (game.Gyozelem)
                {
                    MessageBox.Show($"{game.Nyertes} Nyert");
                } 
                else
                {
                    MessageBox.Show("Döntetlen");
                }
                UjJatek();
            }
            btnScoreboard.Focus();
        }

        private void btnUjJatek_Click(object sender, EventArgs e)
        {
            UjJatek();
        }

        private void UjJatek()
        {
            if (korok == 0)
            {
                game = new TicTacToe(jatekos1, jatekos2);
                jelenlegiKor++;
                lblKorok.Text = jelenlegiKor + ". kör";
                lblKovetkezo.Text = game.KiLep() + " következik";

                foreach (Control item in groupBox1.Controls)
                {
                    if (item.Name.StartsWith("button"))
                    {
                        item.Enabled = true;
                        item.Text = "";
                    }
                }
            }
            else if (jelenlegiKor == korok)
            {
                MessageBox.Show("Játék vége!");
                Application.Exit();
            }
            else
            {
                game = new TicTacToe(jatekos1, jatekos2);
                jelenlegiKor++;
                lblKorok.Text = jelenlegiKor + ". kör";
                lblKovetkezo.Text = game.KiLep() + " következik";

                foreach (Control item in groupBox1.Controls)
                {
                    if (item.Name.StartsWith("button"))
                    {
                        item.Enabled = true;
                        item.Text = "";
                    }
                }
            }
            
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard score = new Scoreboard();
            score.ShowDialog();
        }
    }
}
