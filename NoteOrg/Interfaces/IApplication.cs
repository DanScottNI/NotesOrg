using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;

namespace NoteOrg.Interfaces
{
    internal interface IApplication
    {
        int Execute(Container container);
    }
}
