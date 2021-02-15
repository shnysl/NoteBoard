using NoteBoard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(@"..\..\Image\image1.jpg");
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                    Login login = new Login();
                    if (login.Giris(txtUserName.Text, Int32.Parse(mtxtPassword.Text)))
                    {
                        if (Login.u.Durum == true && Login.u.UserType == "user")
                        {
                            Form3 fr3 = new Form3();
                            fr3.Show();
                            txtUserName.Text = "";
                            mtxtPassword.Text = "";
                    }
                        else if (Login.u.UserType == "admin")
                        {
                        Form5 fr5 = new Form5();
                        fr5.Show();
                        txtUserName.Text = "";
                        mtxtPassword.Text = "";
                    }
                        else
                        {
                        MessageBox.Show("Kayıt İşleminiz henüz onaylanmamıştır.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                        txtUserName.Text = "";
                        mtxtPassword.Text = "";
                    }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Kuallnıcı Adı veya Şifre Hatalı");
                txtUserName.Text = "";
                mtxtPassword.Text = "";
            }

        }
    }
}
