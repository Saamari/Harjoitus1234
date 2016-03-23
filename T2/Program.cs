using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
      

        // Main program begins
        static void Main(string[] args)
        {
            // Constructing new object Kosti
            Kosti kosti = new Kosti();
            // Display all "commands" below in that order
            kosti.Default();
            kosti.AddValue(75);
            kosti.Min();
            kosti.Max();
            kosti.Default();
            kosti.AddValue(80);
            kosti.Min();
            kosti.Max();
            kosti.Reset();
            kosti.Default();
            kosti.AddValue(70);
            kosti.Min();
            kosti.Max();





        }

    }
}