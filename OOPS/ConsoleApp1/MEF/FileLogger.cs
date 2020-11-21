using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MEF
{
    [Export]
    public class FileLogger : ILogger
    {
        public string Message{ get; set; }
    }
}
