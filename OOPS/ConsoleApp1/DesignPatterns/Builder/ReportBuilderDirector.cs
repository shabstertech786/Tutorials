using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Builder
{
    public class ReportBuilderDirector
    {
        private readonly IReportBuilder reportBuilder;
        public ReportBuilderDirector(IReportBuilder reportBuilder)
        {
            this.reportBuilder = reportBuilder;
        }

        public void BuildReport()
        {
            this.reportBuilder.BuildHeader().BuildBody().BuildFooter();            
        }
    }
}
