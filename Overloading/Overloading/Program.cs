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

            Console.WriteLine("\n");

            Console.WriteLine(math.Subtract(9, 2));
            Console.WriteLine(math.Subtract(4.3F, 2.2F));
            Console.WriteLine(math.Subtract("5", "4"));

            Console.WriteLine("\n");

            Console.WriteLine(math.Multiply(4, 2));
            Console.WriteLine(math.Multiply(1.3F, 2.2F));
            Console.WriteLine(math.Multiply("3,1", "3"));

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

            //---------------------------------------------------------------------------

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public float Subtract(float a, float b)
            {
                return a - b;
            }

            public string Subtract(string a, string b)
            {
                return (Convert.ToDouble(a) - Convert.ToDouble(b)).ToString();
            }

            //---------------------------------------------------------------------------

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public float Multiply(float a, float b)
            {
                return a * b;
            }

            public string Multiply(string a, string b)
            {
                return (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString();
            }
        }
    }
}
