using NoteBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard
{
    class NoteBoardDbContext:DbContext
    {
        public NoteBoardDbContext() : base("Server=DESKTOP-Q21DV4G\\DENEME; Database=NoteBoardDb; uid=sa; pwd=123")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<User>()
                .HasMany(a => a.Passwords)
                .WithRequired(a => a.User)
                .HasForeignKey(a => a.UserID);
            modelBuilder.Entity<User>()
                .HasMany(a => a.Notes)
                .WithRequired(a => a.User)
                .HasForeignKey(a => a.UserID);
        }
    }
}
