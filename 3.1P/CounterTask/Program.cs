using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    public class MainClass
    {
        private static void Main(string[] args)
        {
            Clock clock = new Clock();
            int i;
            /* 86400 = 24 hours */
            for (i= 0 ; i < 86400; i++)
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(clock.Time());
                clock.Tick();
            }
        
        }
        
        }
    }

