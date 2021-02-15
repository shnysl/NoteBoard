using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.Model
{
    public class User
    {
        public User()
        {
            Notes = new HashSet<Note>();
            Passwords = new HashSet<Password>();
        }
        public int UserID { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string  UserName { get; set; }
        public string UserType { get; set; }
        public bool Durum { get; set; }
        public ICollection<Password> Passwords { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
