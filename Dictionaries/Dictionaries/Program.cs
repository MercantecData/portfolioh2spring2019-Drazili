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

            Console.WriteLine("\n\n");

            Person p1 = new Person("Mig", 666);
            Person p2 = new Person("Dig", 420);
            Person p3 = new Person("Sig", 69);

            Dictionary<Person, bool> personDictionary = new Dictionary<Person, bool>();

            stringToInt[p1] = false;
            stringToInt[p2] = false;
            stringToInt[p3] = false;

            Console.ReadLine();
        }

        public class Person
        {
            string name;
            int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
