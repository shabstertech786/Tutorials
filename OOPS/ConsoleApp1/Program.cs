using ConsoleApp1.DesignPatterns.Builder;
using ConsoleApp1.DesignPatterns.Stretegy;
using ConsoleApp1.MEF;
using ConsoleApp1.OOPS;
using ConsoleApp1.SOLID;
using ConsoleApp1.SOLID.DIP;
using ConsoleApp1.SOLID.LSP;
using ConsoleApp1.SOLID.OCP;
using ConsoleApp1.Unity;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp1
{
    class Program
    {
       private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        static void Main(string[] args)
        {
            log.Debug("this is debug");

            Program p = new Program();
            MEFContainer.SetupContainer(p);
            log.Info("MEF setup");
            ////////////////////////////////
            //var unityContainer = new UnityContainer();
            //unityContainer.RegisterType<Student, AverageStudent>("AverageStudent");
            //unityContainer.RegisterType<Student, BrilliantStudent>("BrilliantStudent");
            //var student = unityContainer.Resolve<Student>("AverageStudent");
            Container.InitialiseContainer();
            log.Fatal("unity container initialised");
            ////Console.ReadLine();
            /////////////// SRP each individual ////////////////////////////
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
            Console.WriteLine(report.ToString());
            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);

            //////////////////////////////////////// OCP /////////////////////////////////
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SOLID.OCP.SeniorDevSalaryCalculator(new SOLID.OCP.DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new SOLID.OCP.JuniorDevSalaryCalculator(new SOLID.OCP.DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SOLID.OCP.SeniorDevSalaryCalculator(new SOLID.OCP.DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };

            var calculator = new SOLID.OCP.SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
            //////////////////////////////////// LSP ///////////////////////////////////////////
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            //SumCalculator sum = new SumCalculator(numbers);
            //Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            //Console.WriteLine();
            SumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            SumCalculator oddSum  = new OddNumberCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
            Console.WriteLine($"The sum of all the Odd numbers:  {oddSum.Calculate()}");
            //////////////////////////////// ISP //////////////////////////////////////////////

            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Executive });
            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
            Console.WriteLine(empManager.GetEmployee().ToString());

            /////////////////////////////////Builder Pattern //////////////////////
            var reportBuilder = new ReportBuilder();
            var director = new ReportBuilderDirector(reportBuilder);
            director.BuildReport();
            Console.WriteLine(reportBuilder.GetReport().ToString());
            //////////////////////////strategy pattern///////////////////////////////
            var reports = new List<DesignPatterns.Stretegy.DeveloperReport>
            {
                new DesignPatterns.Stretegy.DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DesignPatterns.Stretegy.DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DesignPatterns.Stretegy.DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DesignPatterns.Stretegy.DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };
            var calculatorContext = new DesignPatterns.Stretegy.SalaryCalculator(new DesignPatterns.Stretegy.JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.CalculateTotalSalaries(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
        }

    }
}
