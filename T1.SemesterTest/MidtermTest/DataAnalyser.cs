using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy;

        public SummaryStrategy Strategy
        {

            get { return _strategy; }
            set { _strategy = value; }
        }

        public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
        {
            _numbers = numbers;
            _strategy = strategy;
        }
        public DataAnalyser(List<int> numbers) 
        {
            
            _numbers = numbers;
            _strategy = new AverageSummary();
        }
        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }


    }
}
