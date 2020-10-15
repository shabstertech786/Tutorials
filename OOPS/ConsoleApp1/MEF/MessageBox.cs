using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MEF
{
    [Export()]
    public class MessageBox
    {
        
        public string MyMessage{
            get{ return "this is my example message"; }
        }
    }
}
