using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Builder
{
    public interface IReportBuilder{
        IReportBuilder BuildHeader();
        IReportBuilder BuildBody();
        IReportBuilder BuildFooter();
        Report GetReport();
    }
    public class ReportBuilder : IReportBuilder
    {
        private readonly Report report;
        public ReportBuilder()
        {
            report = new Report();
        }

        public IReportBuilder BuildHeader()
        {
            report.Header = "this is header";
            return this;
            
        }

        public IReportBuilder BuildBody(){
            report.Body = "this is body";
            return this;
        }

        public IReportBuilder BuildFooter(){
            report.Footer = "this is footer";
            return this;
        }

        public Report GetReport()
        {
            return report;
        }
    }
}
