using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.Model
{
    public class Note
    {
        public int NoteID { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
