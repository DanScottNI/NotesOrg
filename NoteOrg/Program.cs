using System;
using NoteOrg.Interfaces;
using SimpleInjector;

namespace NoteOrg
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            Bootstrap boot = new Bootstrap(container);

            IApplication app = container.GetInstance<IApplication>();

            app.Execute(container);
        }
    }
}