using MidtermTest;
using System;

    public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() {1,0,4,1,8,1,7,8,9};
        DataAnalyser test = new DataAnalyser(list);
        test.Strategy = new MinMaxSummary();
        test.Summarise();
        test.AddNumber(1);
        test.AddNumber(2);
        test.AddNumber(3);
        test.Strategy = new AverageSummary();
        test.Summarise();
        Console.ReadLine();


    }
}