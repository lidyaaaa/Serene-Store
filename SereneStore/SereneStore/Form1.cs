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
    
    public partial class Form1 : Form
    {
        SereneStoreEntities db = new SereneStoreEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsRemembered)
            {
                // Langsung masuk ke main menu
                mainmenu main = new mainmenu();
                main.Show();
                this.Hide();
            }
        }
        void Login()
        {
            var email = txtbemail.Text;
            var nama = txtbnama.Text;
            var pass = txtbpass.Text;
            var data = db.DataUser.FirstOrDefault(x => x.Nama == nama && x.Password == pass);
            if (data != null)
            {
                Properties.Settings.Default.nama = txtbnama.Text;
                Properties.Settings.Default.IsRemembered = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("Welcome " + data.Nama);
                mainmenu main = new mainmenu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register regist = new register();
            regist.ShowDialog();
        }
    }
}
