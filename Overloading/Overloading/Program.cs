using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine(math.Add(1, 2));
            Console.WriteLine(math.Add(1.3F, 2.2F));
            Console.WriteLine(math.Add("5", "4"));

            Console.ReadLine();
        }

        public class Math
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public float Add(float a, float b)
            {
                return a + b;
            }

            public string Add(string a, string b)
            {
                return (Convert.ToDouble(a) + Convert.ToDouble(b)).ToString();
            }
        }
    }
}
