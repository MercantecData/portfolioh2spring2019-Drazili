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
            Console.ReadLine();
        }
    }
}
