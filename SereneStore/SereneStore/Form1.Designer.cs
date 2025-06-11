namespace SereneStore
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
            this.txtbemail = new System.Windows.Forms.TextBox();
            this.txtbnama = new System.Windows.Forms.TextBox();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtbpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbemail
            // 
            this.txtbemail.Location = new System.Drawing.Point(391, 107);
            this.txtbemail.Name = "txtbemail";
            this.txtbemail.Size = new System.Drawing.Size(213, 26);
            this.txtbemail.TabIndex = 0;
            // 
            // txtbnama
            // 
            this.txtbnama.Location = new System.Drawing.Point(391, 178);
            this.txtbnama.Name = "txtbnama";
            this.txtbnama.Size = new System.Drawing.Size(213, 26);
            this.txtbnama.TabIndex = 0;
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(209, 178);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(51, 20);
            this.lblnama.TabIndex = 1;
            this.lblnama.Text = "Nama";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(209, 110);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            // 
            // txtbpass
            // 
            this.txtbpass.Location = new System.Drawing.Point(391, 248);
            this.txtbpass.Name = "txtbpass";
            this.txtbpass.Size = new System.Drawing.Size(213, 26);
            this.txtbpass.TabIndex = 0;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(209, 251);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(78, 20);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(521, 323);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 33);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(531, 373);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Daftar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Belum Punya Akun?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.txtbpass);
            this.Controls.Add(this.txtbnama);
            this.Controls.Add(this.txtbemail);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbemail;
        private System.Windows.Forms.TextBox txtbnama;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtbpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

