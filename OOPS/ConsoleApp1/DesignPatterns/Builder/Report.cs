using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Builder
{
    public class Report
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer{ get; set; }

        public override string ToString()
        {
            return $"{Header} - {Body} - {Footer}";
        }
    }
}
