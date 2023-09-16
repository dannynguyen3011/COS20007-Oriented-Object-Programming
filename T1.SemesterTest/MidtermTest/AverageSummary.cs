using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest
{
    public class AverageSummary :SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Your average is:" + Average(numbers));
        }
        public float Average(List<int> numbers)
        {
            int sum = 0;
            for ( int i = 0; i < numbers.Count; i++ )
            {
                sum += numbers[i];

            }
            float avr = (float)sum / numbers.Count;
            return avr;
        }

    }
    
}
