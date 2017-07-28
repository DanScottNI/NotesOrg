using System;
using System.Collections.Generic;
using System.Text;
using NoteOrg.Core.Services;
using NoteOrg.Core.Services.Interfaces;
using NoteOrg.Interfaces;
using SimpleInjector;

namespace NoteOrg
{
    internal class Bootstrap
    {
        public Bootstrap(Container container)
        {
            container.Register<INotesService, NotesService>();
            container.Register<IApplication, Application>();
        }

    }
}
