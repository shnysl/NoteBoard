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
    public partial class Form3 : Form
    {
        NoteBoardDbContext db;
        public Form3()
        {
            InitializeComponent();
            db = new NoteBoardDbContext();
        }

        public void DataDown()
        {
            lbNoteTitle.ValueMember = "NoteID";
            lbNoteTitle.DisplayMember = "NoteTitle";
            lbNoteTitle.DataSource = db.Notes.Where(a => a.UserID == Login.u.UserID).ToList();
            lbNoteTitle.SelectedIndex = -1;
        }

        public void DataDelete()
        {
            if (lbNoteTitle.SelectedValue != null)
            {
                int secim = Convert.ToInt32(lbNoteTitle.SelectedValue);
                Note note = db.Notes.Single(a => a.NoteID == secim);
                db.Notes.Remove(note);
                db.SaveChanges();
                txtTitle.Text = "";
                txtContent.Text = "";
                DataDown();
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            DataDown();
        }

        private void llblPasswordChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbNoteTitle.SelectedIndex == -1)
            {
                Note note = new Note();
                note.NoteTitle = txtTitle.Text;
                note.NoteContent = txtContent.Text;
                note.UserID = Login.u.UserID;
                db.Notes.Add(note);
                db.SaveChanges();
                DataDown();
                txtTitle.Text = "";
                txtContent.Text = "";
            }
            else
            {
                int secim = Convert.ToInt32(lbNoteTitle.SelectedValue);
                Note note = db.Notes.Single(a => a.NoteID == secim);
                note.NoteTitle = txtTitle.Text;
                note.NoteContent = txtContent.Text;
                db.SaveChanges();
                lbNoteTitle.SelectedIndex = -1;
                DataDown();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataDelete();
        }

        private void lbNoteTitle_Click(object sender, EventArgs e)
        {
            if (lbNoteTitle.SelectedValue != null)
            {
                txtTitle.Text = lbNoteTitle.Text;
                int secim = Convert.ToInt32(lbNoteTitle.SelectedValue);
                txtContent.Text = db.Notes.SingleOrDefault(a => a.NoteID == secim).NoteContent;
            }

        }
    }
}
