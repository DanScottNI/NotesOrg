using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteOrg.Core.EntityFramework;
using NoteOrg.Core.Objects;
using NoteOrg.Core.Services.Interfaces;

namespace NoteOrg.Core.Services
{
    public class NotesService : INotesService
    {
        private readonly NotesContext context;

        public NotesService()
        {
            this.context = new NotesContext();

            this.context.Database.EnsureCreated();
        }

        public void Create(Workbook obj)
        {
            this.context.Attach(obj);
            this.context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this.context.SaveChanges();
        }

        public IEnumerable<Workbook> GetAllWorkbooks()
        {
            return this.context.Workbooks;
        }
    }
}
