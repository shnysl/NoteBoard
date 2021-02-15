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
    public partial class Form4 : Form
    {
        NoteBoardDbContext db;
        public Form4()
        {
            InitializeComponent();
            db = new NoteBoardDbContext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool arama = false;
            int ID = db.Passwords.Where(a => a.UserID == Login.u.UserID).Max(a => a.PasswordID);
            Password password = db.Passwords.Single(a => a.PasswordID == ID);
            var top = (from q in db.Passwords
                       where q.UserID == Login.u.UserID
                       orderby q.PasswordID descending
                       select q).Take(3);
            foreach (Password item in top)
            {
                if(item.UserPassword == Int32.Parse(txtNewPassword.Text))
                {
                    arama = true;
                }
            }
            if (Int32.Parse(txtOldPassword.Text) == password.UserPassword)
            {
                if (txtNewPassword.Text == txtNewPassword2.Text)
                {
                    if(arama == false)
                    {
                        Password newPassword = new Password();
                        newPassword.UserID = Login.u.UserID;
                        newPassword.UserPassword = Int32.Parse(txtNewPassword.Text);
                        db.Passwords.Add(newPassword);
                        db.SaveChanges();
                        MessageBox.Show("Şifre Değiştirildi.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifre kullanılan son 3 şifreden birisi olamaz, farklı bir şifre deneyinz.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler birbirinden farklı");
                }
            }
            else
            {
                MessageBox.Show("Şifreyi Hatalı.");
            }
        }
    }
}
