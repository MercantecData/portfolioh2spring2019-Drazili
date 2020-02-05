using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void DelOne();
        public delegate float DelTwo();
        public delegate void DelThree(string a, string b, int c);

        static void Main(string[] args)
        {
            Delegatos delegator = new Delegatos();
            DelOne dele1 = delegator.Uno;
            DelTwo dele2 = delegator.Dos;
            DelThree dele3 = delegator.Tress;

            dele1();
            Console.WriteLine(dele2());
            dele3("1", "2", 3);

            Console.ReadLine();
        }
    }

    class Delegatos
    {
        public void Uno()
        {
            Console.WriteLine("1");
        }

        public float Dos()
        {
            return 2.2F;
        }

        public void Tress(string a, string b, int c)
        {
            Console.WriteLine(a + " plus " + b + " = " + c);
        }
    }
}
