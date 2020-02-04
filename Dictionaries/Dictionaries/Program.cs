using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stringToInt = new Dictionary<string, int>();

            int i = 0;
            while (i<10)
            {
                i++;
                stringToInt[i.ToString()] = i;
                Console.WriteLine(stringToInt[i.ToString()]);
            }

            Console.WriteLine("\n\n");

            Dictionary<float, bool> floatToBool = new Dictionary<float, bool>();

            bool b = false;
            float f = 0.0F;
            while (f < 1)
            {
                b = !b;
                f += 0.1F;
                floatToBool[f] = b;
                Console.WriteLine(floatToBool[f]);
            }

            Console.ReadLine();
        }
    }
}
