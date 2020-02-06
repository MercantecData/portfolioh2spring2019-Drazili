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
            Black black = new Black();
            White white = new White();
            Yellow yellow = new Yellow();
            Person[] people = new Person[3] { black, yellow, white };

            foreach (Person racist in people)
            {
                racist.nigger();
            }
            Console.WriteLine("");

            foreach (ISpycam racist in people)
            {
                racist.GetGender();
                racist.GetNationalitet();
                racist.GetReligion();
                Console.WriteLine("");
            }

            Personae[] personaes = new Personae[10]
            {
                new Personae("Aaliyah", 22, "kvinde"),
                new Personae("Frazer", 25, "Mand"),
                new Personae("Hollie", 99, "kvinde"),
                new Personae("Alexandria", 7, "kvinde"),
                new Personae("Richard", 16, "Mand"),
                new Personae("Jillian", 27, "Mand"),
                new Personae("Darin", 31, "Mand"),
                new Personae("Abid", 23, "kvinde"),
                new Personae("Gorgina", 12, "kvinde"),
                new Personae("Momina", 92, "kvinde")
            };


            Console.ReadKey();
        }
    }

    public interface ISpycam
    {
        void GetReligion();
        void GetNationalitet();
        void GetGender();
    }

    public abstract class Person
    {
        public abstract void nigger();
    }

    class Black : Person, ISpycam
    {
        public override void nigger()
        {
            Console.WriteLine("Yo, mah nigger!");
        }
        void ISpycam.GetReligion()
        {
            Console.WriteLine("I worship the motherfucking snakes on this motherfucking plane");
        }

        void ISpycam.GetNationalitet()
        {
            Console.WriteLine("Hey yo, I'm fucking american");
        }

        void ISpycam.GetGender()
        {
            Console.WriteLine("I'm a fucking guy, you blind fuck");
        }
    }

    class White : Person, ISpycam 
    {
        public override void nigger()
        {
            Console.WriteLine("Fuck you, you fucking nigger!");
        }

        void ISpycam.GetReligion()
        {
            Console.WriteLine("Praise the Godemperor of Mankind");
        }

        void ISpycam.GetNationalitet()
        {
            Console.WriteLine("2% indian, 27% african, 31% russian, 1% japanese and 39% cheese");
        }

        void ISpycam.GetGender()
        {
            Console.WriteLine("Did you just assume my gender!!!! *REEEEEEEE in the distance*");
        }
    }

    class Yellow : Person, ISpycam
    {
        public override void nigger()
        {
            Console.WriteLine("Ching chong, proper word is black persong *Nerdy sounds in the background*");
        }

        void ISpycam.GetReligion()
        {
            Console.WriteLine("Ching!");
        }

        void ISpycam.GetNationalitet()
        {
            Console.WriteLine("Chong");
        }

        void ISpycam.GetGender()
        {
            Console.WriteLine("Chong ching, ching");
        }
    }

    class Personae// : IComparable
    {
        string name;
        int age;
        string gender;

        public Personae(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        /*
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Personae personas = obj as Personae;
            if (personae != null)
                return this.Personae.CompareTo(personas.age);
        }
        */
    }
}
