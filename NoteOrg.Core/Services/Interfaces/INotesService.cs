using System;
using System.Collections.Generic;
using System.Text;
using NoteOrg.Core.Objects;

namespace NoteOrg.Core.Services.Interfaces
{
    public interface INotesService
    {
        IEnumerable<Workbook> GetAllWorkbooks();
        void Create(Workbook obj);
    }
}
