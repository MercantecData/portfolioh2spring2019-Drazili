using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3] { new Black(), new White(), new Yellow() };

            foreach (Person racist in people)
            {
                racist.nigger();
            }
            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        public abstract void nigger();
    }

    class Black : Person
    {
        public override void nigger()
        {
            Console.WriteLine("Yo, mah nigger!");
        }
    }

    class White : Person
    {
        public override void nigger()
        {
            Console.WriteLine("Fuck you, you fucking nigger!");
        }
    }

    class Yellow : Person
    {
        public override void nigger()
        {
            Console.WriteLine("Ching chong, proper word is black persong *Nerdy sounds in the background*");
        }
    }
}
