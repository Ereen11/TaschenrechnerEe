namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbZahl1 = new System.Windows.Forms.TextBox();
            this.txtbZahl2 = new System.Windows.Forms.TextBox();
            this.txtbergebnis = new System.Windows.Forms.TextBox();
            this.btngleich = new System.Windows.Forms.Button();
            this.listbOperationen = new System.Windows.Forms.ListBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnkomma = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.PYG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbZahl1
            // 
            this.txtbZahl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbZahl1.Location = new System.Drawing.Point(40, 118);
            this.txtbZahl1.MaxLength = 30;
            this.txtbZahl1.Name = "txtbZahl1";
            this.txtbZahl1.ReadOnly = true;
            this.txtbZahl1.Size = new System.Drawing.Size(72, 27);
            this.txtbZahl1.TabIndex = 0;
            this.txtbZahl1.Click += new System.EventHandler(this.txtbZahl1_Click);
            // 
            // txtbZahl2
            // 
            this.txtbZahl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbZahl2.Location = new System.Drawing.Point(191, 118);
            this.txtbZahl2.MaxLength = 30;
            this.txtbZahl2.Name = "txtbZahl2";
            this.txtbZahl2.ReadOnly = true;
            this.txtbZahl2.Size = new System.Drawing.Size(75, 27);
            this.txtbZahl2.TabIndex = 1;
            this.txtbZahl2.Click += new System.EventHandler(this.txtbZahl2_Click);
            // 
            // txtbergebnis
            // 
            this.txtbergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbergebnis.Location = new System.Drawing.Point(40, 61);
            this.txtbergebnis.Name = "txtbergebnis";
            this.txtbergebnis.ReadOnly = true;
            this.txtbergebnis.Size = new System.Drawing.Size(318, 27);
            this.txtbergebnis.TabIndex = 2;
            // 
            // btngleich
            // 
            this.btngleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngleich.Location = new System.Drawing.Point(297, 118);
            this.btngleich.Name = "btngleich";
            this.btngleich.Size = new System.Drawing.Size(61, 29);
            this.btngleich.TabIndex = 3;
            this.btngleich.Text = "=";
            this.btngleich.UseVisualStyleBackColor = true;
            this.btngleich.Click += new System.EventHandler(this.btngleich_Click);
            // 
            // listbOperationen
            // 
            this.listbOperationen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbOperationen.FormattingEnabled = true;
            this.listbOperationen.ItemHeight = 22;
            this.listbOperationen.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            ":"});
            this.listbOperationen.Location = new System.Drawing.Point(129, 118);
            this.listbOperationen.Name = "listbOperationen";
            this.listbOperationen.ScrollAlwaysVisible = true;
            this.listbOperationen.Size = new System.Drawing.Size(47, 26);
            this.listbOperationen.TabIndex = 4;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(40, 188);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 27);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(149, 187);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 27);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(262, 187);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 27);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(262, 229);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 27);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(40, 276);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 27);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(40, 229);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 27);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(149, 229);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 27);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(149, 276);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 27);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(262, 276);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 27);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(149, 318);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 27);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnkomma
            // 
            this.btnkomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkomma.Location = new System.Drawing.Point(262, 318);
            this.btnkomma.Name = "btnkomma";
            this.btnkomma.Size = new System.Drawing.Size(75, 27);
            this.btnkomma.TabIndex = 15;
            this.btnkomma.Text = ",";
            this.btnkomma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnkomma.UseVisualStyleBackColor = true;
            this.btnkomma.Click += new System.EventHandler(this.btnkomma_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(40, 318);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 27);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click_1);
            // 
            // btnWurzel
            // 
            this.btnWurzel.Location = new System.Drawing.Point(149, 351);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(75, 23);
            this.btnWurzel.TabIndex = 17;
            this.btnWurzel.Text = "✔";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // PYG
            // 
            this.PYG.Location = new System.Drawing.Point(262, 351);
            this.PYG.Name = "PYG";
            this.PYG.Size = new System.Drawing.Size(75, 23);
            this.PYG.TabIndex = 18;
            this.PYG.Text = "Pythagoras";
            this.PYG.UseVisualStyleBackColor = true;
            this.PYG.Click += new System.EventHandler(this.PYG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(392, 446);
            this.Controls.Add(this.PYG);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnkomma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.listbOperationen);
            this.Controls.Add(this.btngleich);
            this.Controls.Add(this.txtbergebnis);
            this.Controls.Add(this.txtbZahl2);
            this.Controls.Add(this.txtbZahl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taschenrechner Eren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbZahl1;
        private System.Windows.Forms.TextBox txtbZahl2;
        private System.Windows.Forms.TextBox txtbergebnis;
        private System.Windows.Forms.Button btngleich;
        private System.Windows.Forms.ListBox listbOperationen;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnkomma;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnWurzel;
        private System.Windows.Forms.Button PYG;
    }
}

