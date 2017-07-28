using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteOrg.Core.Objects;
using NoteOrg.Core.Services.Interfaces;
using NoteOrg.Interfaces;
using SimpleInjector;

namespace NoteOrg
{
    public class Application : IApplication
    {
        private readonly INotesService notes;

        public Application(INotesService notes)
        {
            this.notes = notes;
        }

        public int Execute(Container container)
        {
            var workbooks = this.notes.GetAllWorkbooks();

            if (!workbooks.Any())
            {
                Console.WriteLine("You don't have any workbooks available.");
                Console.WriteLine("Enter the name of your first workbooks:");
                var workbookName = Console.ReadLine();

                Workbook bk = new Workbook();
                bk.WorkbookName = workbookName;
                notes.Create(bk);
            }
            else
            {
                Console.WriteLine("The following workbooks exist:");

                foreach (var w in workbooks)
                {
                    Console.WriteLine(w.WorkbookName);
                }
            }

            return 0;
        }
    }
}
