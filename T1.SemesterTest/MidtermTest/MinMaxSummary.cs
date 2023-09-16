using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest
{
    public class MinMaxSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Write your minimum number: " + Minimum(numbers) + "\nWrite your maximum number:" + Maximum(numbers));

        }
        private int Minimum(List<int> numbers) 
        {
            return numbers.Min();
        }

        private int Maximum(List<int> numbers)
        {
            return numbers.Max();
        }

    }
}
