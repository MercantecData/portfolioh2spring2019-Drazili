using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public delegate int IntDelegate(int a, int b);
        public delegate float FloatDelegate(float a, float b);
        public delegate string StringDelegate(string a, string b);
        static void Main(string[] args)
        {
            Math math = new Math();

            IntDelegate IntOverload;
            IntOverload = math.Add;
            Console.WriteLine(IntOverload(2, 3));
            IntOverload = math.Subtract;
            Console.WriteLine(IntOverload(2, 3));
            IntOverload = math.Multiply;
            Console.WriteLine(IntOverload(2, 3));
            IntOverload = math.Divide;
            Console.WriteLine(IntOverload(2, 3));

            Console.WriteLine("\n");

            FloatDelegate FloatOverload;
            FloatOverload = math.Add;
            Console.WriteLine(FloatOverload(2.1F, 3.7F));
            FloatOverload = math.Subtract;
            Console.WriteLine(FloatOverload(2.1F, 3.7F));
            FloatOverload = math.Multiply;
            Console.WriteLine(FloatOverload(2.1F, 3.7F));
            FloatOverload = math.Divide;
            Console.WriteLine(FloatOverload(2.1F, 3.7F));

            Console.WriteLine("\n");

            StringDelegate StringOverload;
            StringOverload = math.Add;
            Console.WriteLine(StringOverload("7,1", "1,4"));
            StringOverload = math.Subtract;
            Console.WriteLine(StringOverload("7,1", "1,4"));
            StringOverload = math.Multiply;
            Console.WriteLine(StringOverload("7,1", "1,4"));
            StringOverload = math.Divide;
            Console.WriteLine(StringOverload("7,1", "1,4"));

            Console.WriteLine("\n");

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

            //---------------------------------------------------------------------------

            public int Divide(int a, int b)
            {
                return a / b;
            }

            public float Divide(float a, float b)
            {
                return a / b;
            }

            public string Divide(string a, string b)
            {
                return (Convert.ToDouble(a) / Convert.ToDouble(b)).ToString();
            }
        }
    }
}
