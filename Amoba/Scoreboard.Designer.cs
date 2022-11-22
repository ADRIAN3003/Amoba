
namespace Amoba
{
    partial class Scoreboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblJatekos1 = new System.Windows.Forms.Label();
            this.lblJatekos2 = new System.Windows.Forms.Label();
            this.lblJatekosEgyPont = new System.Windows.Forms.Label();
            this.lblJatekosKettoPont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard";
            // 
            // lblJatekos1
            // 
            this.lblJatekos1.AutoSize = true;
            this.lblJatekos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJatekos1.Location = new System.Drawing.Point(75, 98);
            this.lblJatekos1.Name = "lblJatekos1";
            this.lblJatekos1.Size = new System.Drawing.Size(105, 25);
            this.lblJatekos1.TabIndex = 1;
            this.lblJatekos1.Text = "Jatekos 1";
            // 
            // lblJatekos2
            // 
            this.lblJatekos2.AutoSize = true;
            this.lblJatekos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJatekos2.Location = new System.Drawing.Point(75, 166);
            this.lblJatekos2.Name = "lblJatekos2";
            this.lblJatekos2.Size = new System.Drawing.Size(105, 25);
            this.lblJatekos2.TabIndex = 2;
            this.lblJatekos2.Text = "Jatekos 2";
            // 
            // lblJatekosEgyPont
            // 
            this.lblJatekosEgyPont.AutoSize = true;
            this.lblJatekosEgyPont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJatekosEgyPont.Location = new System.Drawing.Point(230, 98);
            this.lblJatekosEgyPont.Name = "lblJatekosEgyPont";
            this.lblJatekosEgyPont.Size = new System.Drawing.Size(153, 25);
            this.lblJatekosEgyPont.TabIndex = 3;
            this.lblJatekosEgyPont.Text = "Jatekos 1 pont";
            // 
            // lblJatekosKettoPont
            // 
            this.lblJatekosKettoPont.AutoSize = true;
            this.lblJatekosKettoPont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJatekosKettoPont.Location = new System.Drawing.Point(230, 166);
            this.lblJatekosKettoPont.Name = "lblJatekosKettoPont";
            this.lblJatekosKettoPont.Size = new System.Drawing.Size(153, 25);
            this.lblJatekosKettoPont.TabIndex = 4;
            this.lblJatekosKettoPont.Text = "Jatekos 2 pont";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 473);
            this.Controls.Add(this.lblJatekosKettoPont);
            this.Controls.Add(this.lblJatekosEgyPont);
            this.Controls.Add(this.lblJatekos2);
            this.Controls.Add(this.lblJatekos1);
            this.Controls.Add(this.label1);
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJatekos1;
        private System.Windows.Forms.Label lblJatekos2;
        private System.Windows.Forms.Label lblJatekosEgyPont;
        private System.Windows.Forms.Label lblJatekosKettoPont;
    }
}