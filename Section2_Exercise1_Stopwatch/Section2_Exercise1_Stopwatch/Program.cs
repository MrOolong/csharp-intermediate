using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Section2_Exercise1_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to start the timer
            
            // prompt user to stop the timer
        }
    }

    public class Stopwatch
    {
        public void Start()
        {
            //DateTime start = new DateTime();
            //DateTime stop = new DateTime();

            var dateTime = new DateTime();
            var start = DateTime.Now;
            start.AddSeconds();
            // 
        }

        public void Stop()
        {

        }
    }
}
