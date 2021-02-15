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
    public partial class Form2 : Form
    {
        NoteBoardDbContext db;
        public Form2()
        {
            InitializeComponent();
            db = new NoteBoardDbContext();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user1 = db.Users.SingleOrDefault(a => a.UserName == txtUserName.Text);
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtUserName.Text == "" || txtPassword2.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Zorunlu alanlar boş geçilemez.");
            }
            else
            {
                if (user1 == null)
                {
                    if (txtPassword.Text == txtPassword2.Text)
                    {
                        try
                        {
                            User user = new User();
                            user.FirtName = txtFirstName.Text;
                            user.LastName = txtLastName.Text;
                            user.UserType = "user";
                            user.UserName = txtUserName.Text;
                            user.Durum = false;
                            Password password = new Password();
                            password.UserPassword = Convert.ToInt32(txtPassword.Text);
                            password.PasswordType = "yeni";
                            user.Passwords.Add(password);
                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("Kayıt yapıldı");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Girilen şifreler aynı değil");
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı daha önce kullanılmış.");
                }
            }  
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword == null || txtPassword2 == null)
            {
                txtPassword.BackColor = Color.White;
                txtPassword2.BackColor = Color.White;
            }
            else if (txtPassword != null && txtPassword2 != null && txtPassword.Text != txtPassword2.Text)
            {
                txtPassword.BackColor = Color.Red;
                txtPassword2.BackColor = Color.Red;
            }
            else if (txtPassword != null && txtPassword2 != null && txtPassword.Text == txtPassword2.Text)
            {
                txtPassword.BackColor = Color.Green;
                txtPassword2.BackColor = Color.Green;
            }
        }
    }
}
