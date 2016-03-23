using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Kosti
    {
        // Defining public propertie and constructing a list
        public int Kosteusarvo { get; set; }
        List<int> Kosteusarvot = new List<int>();

        // Checking kosteusarvo counts and printing default line "Kosti alkutilassa.." or when some values have been set, printing "Kosti toiminnassa" text
        public void Default()
        {
            if (Kosteusarvot.Count == 0)
            {
                Console.WriteLine("Kosti on alkutilassa, ei arvoja");
            }
            else
            {
                Console.WriteLine("Kosti on toiminnassa");
            }
        
        }
        // Adding a value to kosteusarvo and printing it
        public void AddValue(int kosteusarvo)
        {
            Kosteusarvo = kosteusarvo;
            Kosteusarvot.Add(kosteusarvo);
            Console.WriteLine("Kosti on ottanut vastaan arvon: " + kosteusarvo);
        }
        // Reseting values and printing that its been reseted
        public void Reset()
        {
            Kosteusarvot.Clear();
            Console.WriteLine("Kosti on nollattu");
        }
        // Checking minimum value and printing it
        public void Min()
        {
            Console.WriteLine("Kosti minimi: " + Kosteusarvot.Min());
        }
        // Checking maximum value and printing it
        public void Max()
        {
            Console.WriteLine("Kosti maksimi: " + Kosteusarvot.Max());
        }
    }
}
