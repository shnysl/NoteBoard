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
    public partial class Form5 : Form
    {
        NoteBoardDbContext db;
        public Form5()
        {
            InitializeComponent();
            db = new NoteBoardDbContext();
        }

        public void Yenile()
        {
            listView1.Items.Clear();
            foreach (User item in db.Users)
            {
                string[] row = { item.FirtName.ToString(), item.LastName.ToString(), item.UserName.ToString(), item.Durum.ToString(), item.UserID.ToString() };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int ab = Int32.Parse(listView1.FocusedItem.SubItems[4].Text);
            User user = db.Users.Single(a => a.UserID == ab );
            if (MessageBox.Show("Kaydı onaylıyormusunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.Durum = true;
                db.SaveChanges();
            }
            Yenile();
            
        }
    }
}
