using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SereneStore
{
    public partial class register : Form
    {
        SereneStoreEntities db = new SereneStoreEntities();
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
        void regist()
        {
            DataUser d = new DataUser();
            d.Email = txtbemail.Text;
            d.Nama = txtbnama.Text;
            d.Password = txtbpass.Text;

            db.DataUser.Add(d);
            db.SaveChanges();
            MessageBox.Show("Daftar Berhasil");
            this.Close();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            regist();
        }
    }
}
