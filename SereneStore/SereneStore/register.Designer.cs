namespace SereneStore
{
    partial class register
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
            this.txtbemail = new System.Windows.Forms.TextBox();
            this.txtbnama = new System.Windows.Forms.TextBox();
            this.txtbpass = new System.Windows.Forms.TextBox();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.btndaftar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbemail
            // 
            this.txtbemail.Location = new System.Drawing.Point(392, 142);
            this.txtbemail.Name = "txtbemail";
            this.txtbemail.Size = new System.Drawing.Size(229, 26);
            this.txtbemail.TabIndex = 0;
            // 
            // txtbnama
            // 
            this.txtbnama.Location = new System.Drawing.Point(392, 196);
            this.txtbnama.Name = "txtbnama";
            this.txtbnama.Size = new System.Drawing.Size(229, 26);
            this.txtbnama.TabIndex = 0;
            // 
            // txtbpass
            // 
            this.txtbpass.Location = new System.Drawing.Point(392, 264);
            this.txtbpass.Name = "txtbpass";
            this.txtbpass.Size = new System.Drawing.Size(229, 26);
            this.txtbpass.TabIndex = 0;
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(228, 202);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(51, 20);
            this.lblnama.TabIndex = 1;
            this.lblnama.Text = "Nama";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(228, 145);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(228, 264);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(78, 20);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // btndaftar
            // 
            this.btndaftar.Location = new System.Drawing.Point(546, 323);
            this.btndaftar.Name = "btndaftar";
            this.btndaftar.Size = new System.Drawing.Size(75, 45);
            this.btndaftar.TabIndex = 2;
            this.btndaftar.Text = "Daftar";
            this.btndaftar.UseVisualStyleBackColor = true;
            this.btndaftar.Click += new System.EventHandler(this.btndaftar_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndaftar);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.txtbpass);
            this.Controls.Add(this.txtbnama);
            this.Controls.Add(this.txtbemail);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbemail;
        private System.Windows.Forms.TextBox txtbnama;
        private System.Windows.Forms.TextBox txtbpass;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btndaftar;
    }
}