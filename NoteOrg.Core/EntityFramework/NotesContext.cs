using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NoteOrg.Core.Objects;

namespace NoteOrg.Core.EntityFramework
{
    public class NotesContext : DbContext
    {
        public NotesContext()
        {

        }

        public DbSet<Workbook> Workbooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./blog.db");
        }
    }
}
