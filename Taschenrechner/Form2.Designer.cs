namespace Taschenrechner
{
    partial class Form2
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
            this.txtzahl1 = new System.Windows.Forms.TextBox();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.lblergebnis = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtzahl1
            // 
            this.txtzahl1.Location = new System.Drawing.Point(51, 116);
            this.txtzahl1.MaxLength = 20;
            this.txtzahl1.Name = "txtzahl1";
            this.txtzahl1.Size = new System.Drawing.Size(225, 20);
            this.txtzahl1.TabIndex = 1;
            // 
            // btnWurzel
            // 
            this.btnWurzel.Location = new System.Drawing.Point(122, 78);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(75, 23);
            this.btnWurzel.TabIndex = 2;
            this.btnWurzel.Text = "✔";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // lblergebnis
            // 
            this.lblergebnis.AutoSize = true;
            this.lblergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblergebnis.Location = new System.Drawing.Point(53, 183);
            this.lblergebnis.Name = "lblergebnis";
            this.lblergebnis.Size = new System.Drawing.Size(33, 36);
            this.lblergebnis.TabIndex = 4;
            this.lblergebnis.Text = "..";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(56, 22);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(235, 35);
            this.lblTitel.TabIndex = 5;
            this.lblTitel.Text = "Wurzelrechung";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(336, 409);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblergebnis);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.txtzahl1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Wurzelfunktion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtzahl1;
        private System.Windows.Forms.Button btnWurzel;
        private System.Windows.Forms.Label lblergebnis;
        private System.Windows.Forms.Label lblTitel;
    }
}