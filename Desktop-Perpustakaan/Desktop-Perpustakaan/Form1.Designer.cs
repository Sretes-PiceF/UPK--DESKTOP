namespace Desktop_Perpustakaan
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tMasuk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 459);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(307, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 459);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(322, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 459);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(307, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 459);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.tMasuk);
            this.panel5.Controls.Add(this.tPassword);
            this.panel5.Controls.Add(this.tUsername);
            this.panel5.Location = new System.Drawing.Point(335, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 162);
            this.panel5.TabIndex = 1;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(24, 48);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(163, 20);
            this.tUsername.TabIndex = 0;
            this.tUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(24, 97);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(163, 20);
            this.tPassword.TabIndex = 1;
            // 
            // tMasuk
            // 
            this.tMasuk.Location = new System.Drawing.Point(69, 131);
            this.tMasuk.Name = "tMasuk";
            this.tMasuk.Size = new System.Drawing.Size(75, 23);
            this.tMasuk.TabIndex = 2;
            this.tMasuk.Text = "button1";
            this.tMasuk.UseVisualStyleBackColor = true;
            this.tMasuk.Click += new System.EventHandler(this.tMasuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Button tMasuk;
    }
}