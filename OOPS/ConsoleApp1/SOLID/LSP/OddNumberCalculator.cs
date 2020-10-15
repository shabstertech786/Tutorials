using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.LSP
{
    public class OddNumberCalculator : SumCalculator
    {
        public OddNumberCalculator(int[] numbers) : base(numbers)
        {
            
        }
        public override int Calculate()
        {
            return _numbers.Where(x => x % 2 != 0).Sum();
        }
    }
}
