using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.Model
{
    public class Password
    {
        public int PasswordID { get; set; }
        public int UserPassword { get; set; }
        public string PasswordType { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
