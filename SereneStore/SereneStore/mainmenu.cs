using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SereneStore
{
    public partial class mainmenu : Form
    {
        SereneStoreEntities db = new SereneStoreEntities();
        DataBarang data = new DataBarang();
        DataUser user = new DataUser();
        int id;
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            clear();
            this.ActiveControl = txtbnamabarang;
            LoadData();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtbnamabarang.Text = txtbhargabarang.Text = txtbstok.Text = "";
            btncreate.Text = "Save";
          
            user.UserId = 0;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            data.NamaBarang = txtbnamabarang.Text.Trim();
            data.HargaBarang = txtbhargabarang.Text.Trim();
            data.Stok = txtbstok.Text.Trim();
           
            db.DataBarang.Add(data);
            db.SaveChanges();
            clear();
            LoadData(); 
            MessageBox.Show("Data Berhasil Dibuat");
        }
        
        void LoadData()
        {
            var data = db.DataBarang.ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Columns["Hapus"] == null)
            {
                DataGridViewImageColumn btnHapus = new DataGridViewImageColumn
                {
                    Name = "Hapus",
                    HeaderText = "Aksi",
                    Image = Properties.Resources.Trash_Can,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(btnHapus);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                id = (int)row.Cells["Id"].Value;
                txtbnamabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                txtbhargabarang.Text = row.Cells["HargaBarang"].Value.ToString();
                txtbstok.Text = row.Cells["Stok"].Value.ToString();
                if (row.Cells["Hapus"].Selected)
                {
                    int id = (int)row.Cells["Id"].Value;
                    var msg = MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msg == DialogResult.Yes)
                    {
                        var data = db.DataBarang.FirstOrDefault(x => x.Id == id);
                        db.DataBarang.Remove(data);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var barang = db.DataBarang.FirstOrDefault(x => x.Id == id);
            barang.NamaBarang = txtbnamabarang.Text;
            barang.HargaBarang = txtbhargabarang.Text;
            barang.Stok = txtbstok.Text;
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Di Update");
            LoadData();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            transaksi transaksi = new transaksi();
            transaksi.ShowDialog();
            this.Hide();
        }
    }   
}

