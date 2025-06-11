namespace SereneStore
{
    partial class mainmenu
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
            this.lblnamabarang = new System.Windows.Forms.Label();
            this.txtbhargabarang = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblhargabarang = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtbstok = new System.Windows.Forms.TextBox();
            this.txtbnamabarang = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnamabarang
            // 
            this.lblnamabarang.AutoSize = true;
            this.lblnamabarang.Location = new System.Drawing.Point(42, 113);
            this.lblnamabarang.Name = "lblnamabarang";
            this.lblnamabarang.Size = new System.Drawing.Size(111, 20);
            this.lblnamabarang.TabIndex = 0;
            this.lblnamabarang.Text = "Nama Barang:";
            // 
            // txtbhargabarang
            // 
            this.txtbhargabarang.Location = new System.Drawing.Point(169, 157);
            this.txtbhargabarang.Name = "txtbhargabarang";
            this.txtbhargabarang.Size = new System.Drawing.Size(163, 26);
            this.txtbhargabarang.TabIndex = 1;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(46, 276);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(70, 40);
            this.btncreate.TabIndex = 3;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lblhargabarang
            // 
            this.lblhargabarang.AutoSize = true;
            this.lblhargabarang.Location = new System.Drawing.Point(42, 157);
            this.lblhargabarang.Name = "lblhargabarang";
            this.lblhargabarang.Size = new System.Drawing.Size(109, 20);
            this.lblhargabarang.TabIndex = 0;
            this.lblhargabarang.Text = "Harga Barang";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(42, 208);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(98, 20);
            this.lbladdress.TabIndex = 0;
            this.lbladdress.Text = "Stok Barang";
            // 
            // txtbstok
            // 
            this.txtbstok.Location = new System.Drawing.Point(169, 205);
            this.txtbstok.Multiline = true;
            this.txtbstok.Name = "txtbstok";
            this.txtbstok.Size = new System.Drawing.Size(163, 35);
            this.txtbstok.TabIndex = 1;
            // 
            // txtbnamabarang
            // 
            this.txtbnamabarang.Location = new System.Drawing.Point(169, 107);
            this.txtbnamabarang.Name = "txtbnamabarang";
            this.txtbnamabarang.Size = new System.Drawing.Size(163, 26);
            this.txtbnamabarang.TabIndex = 1;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(240, 276);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(73, 40);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(46, 327);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(267, 40);
            this.btnbuy.TabIndex = 3;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(628, 300);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbstok);
            this.Controls.Add(this.txtbnamabarang);
            this.Controls.Add(this.txtbhargabarang);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblhargabarang);
            this.Controls.Add(this.lblnamabarang);
            this.Name = "mainmenu";
            this.Text = "xxxxxxxxxxxx";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamabarang;
        private System.Windows.Forms.TextBox txtbhargabarang;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lblhargabarang;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtbstok;
        private System.Windows.Forms.TextBox txtbnamabarang;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}