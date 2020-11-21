using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MEF
{
    public class MEFContainer 
    {
        private static CompositionContainer compositionContainer = null;
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public static void SetupContainer<T>(T p)
        {
            log.Debug("SetupContainer - start");
            MEFContainer.Container.SatisfyImportsOnce(p);
            log.Debug("SetupContainer - end");
        }
        public static CompositionContainer Container
        {
            get
            {
                if (compositionContainer == null)
                {
                    var directoryCatalog =
                    new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly());
                    compositionContainer = new CompositionContainer(directoryCatalog);                    
                }

                return compositionContainer;

            }

        }

    }
}

