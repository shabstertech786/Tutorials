using ConsoleApp1.MEF;
using ConsoleApp1.OOPS;
using ConsoleApp1.SOLID.DIP;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp1.Unity
{
    public class Container
    {
       private static  IUnityContainer unityContainer;
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
       public static IUnityContainer UnityContainer
       {
          get
          {
            if(unityContainer == null)
            {
                unityContainer = new UnityContainer();
            }

             return unityContainer;
          }

       }

       public static void InitialiseContainer()
       {
            RegisterTypes();
       }
       public static void RegisterTypes()
       {
            log.Debug("RegisterTypes - start");
            UnityContainer.RegisterType<Student, AverageStudent>();
            UnityContainer.RegisterType<Student, BrilliantStudent>("Brilliant Student");
            UnityContainer.RegisterType<ILogger, FileLogger>();
            unityContainer.RegisterType<IEmployeeManager, EmployeeManager>();
            UnityContainer.RegisterType<ILogger, DbLogger>("DbLogger");
            log.Debug("RegisterTypes - end");
        }
    }
}
