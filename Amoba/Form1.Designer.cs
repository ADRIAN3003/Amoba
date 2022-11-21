
namespace Amoba
{
    partial class frmBeallitasok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJatekos1 = new System.Windows.Forms.Label();
            this.lblJatekos2 = new System.Windows.Forms.Label();
            this.tbJatekos1 = new System.Windows.Forms.TextBox();
            this.tbJatekos2 = new System.Windows.Forms.TextBox();
            this.cbKorokSzama = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKezdes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJatekos1
            // 
            this.lblJatekos1.AutoSize = true;
            this.lblJatekos1.Location = new System.Drawing.Point(35, 34);
            this.lblJatekos1.Name = "lblJatekos1";
            this.lblJatekos1.Size = new System.Drawing.Size(115, 20);
            this.lblJatekos1.TabIndex = 6;
            this.lblJatekos1.Text = "Játékos 1 ( X ):";
            // 
            // lblJatekos2
            // 
            this.lblJatekos2.AutoSize = true;
            this.lblJatekos2.Location = new System.Drawing.Point(35, 92);
            this.lblJatekos2.Name = "lblJatekos2";
            this.lblJatekos2.Size = new System.Drawing.Size(116, 20);
            this.lblJatekos2.TabIndex = 7;
            this.lblJatekos2.Text = "Játékos 2 ( O ):";
            // 
            // tbJatekos1
            // 
            this.tbJatekos1.Location = new System.Drawing.Point(176, 31);
            this.tbJatekos1.Name = "tbJatekos1";
            this.tbJatekos1.Size = new System.Drawing.Size(187, 26);
            this.tbJatekos1.TabIndex = 0;
            // 
            // tbJatekos2
            // 
            this.tbJatekos2.Location = new System.Drawing.Point(176, 89);
            this.tbJatekos2.Name = "tbJatekos2";
            this.tbJatekos2.Size = new System.Drawing.Size(187, 26);
            this.tbJatekos2.TabIndex = 1;
            // 
            // cbKorokSzama
            // 
            this.cbKorokSzama.AutoSize = true;
            this.cbKorokSzama.Location = new System.Drawing.Point(115, 155);
            this.cbKorokSzama.Name = "cbKorokSzama";
            this.cbKorokSzama.Size = new System.Drawing.Size(124, 24);
            this.cbKorokSzama.TabIndex = 2;
            this.cbKorokSzama.Text = "Körök száma:";
            this.cbKorokSzama.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(252, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btnKezdes
            // 
            this.btnKezdes.Location = new System.Drawing.Point(23, 196);
            this.btnKezdes.Name = "btnKezdes";
            this.btnKezdes.Size = new System.Drawing.Size(144, 45);
            this.btnKezdes.TabIndex = 4;
            this.btnKezdes.Text = "Kezdés";
            this.btnKezdes.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(231, 196);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(144, 45);
            this.btnKilepes.TabIndex = 5;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // frmBeallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKezdes);
            this.Controls.Add(this.cbKorokSzama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbJatekos2);
            this.Controls.Add(this.tbJatekos1);
            this.Controls.Add(this.lblJatekos2);
            this.Controls.Add(this.lblJatekos1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBeallitasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJatekos1;
        private System.Windows.Forms.Label lblJatekos2;
        private System.Windows.Forms.TextBox tbJatekos1;
        private System.Windows.Forms.TextBox tbJatekos2;
        private System.Windows.Forms.CheckBox cbKorokSzama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKezdes;
        private System.Windows.Forms.Button btnKilepes;
    }
}

