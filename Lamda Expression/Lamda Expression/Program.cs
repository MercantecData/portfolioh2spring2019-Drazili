using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expression
{
    public delegate int DelegateOne(int number);
    public delegate double DelegateTwo(double a, double b, double c);
    public delegate string DelegateThree();
    class Program
    {
        static void Main(string[] args)
        {
            DelegateOne En = (x) => x * 2;
            Console.WriteLine(En(12));

            DelegateTwo To = (x, y, z) => x + y + z;
            Console.WriteLine(To(2,4,6));

            DelegateThree Tre = () => "Hello World";
            Console.WriteLine(Tre());

            Console.ReadLine();
        }
    }
}
