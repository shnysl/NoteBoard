using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.Model
{
    class Login
    {
        NoteBoardDbContext db;
        public static User u = new User();
        public bool Giris(string kAdi, int sifre)
        {
                db = new NoteBoardDbContext();
                User user = db.Users.Single(a => a.UserName == kAdi);
                int ID = db.Passwords.Where(a => a.UserID == user.UserID).Max(a => a.PasswordID);
                Password password = db.Passwords.Single(a => a.PasswordID == ID);
                if (password.UserPassword == sifre)
                {
                u = user;
                    return true;

                }
                else
                {
                    return false;
                }
        }

        public User AktifKullanici()
        {
            return u;
        }

    }
}
