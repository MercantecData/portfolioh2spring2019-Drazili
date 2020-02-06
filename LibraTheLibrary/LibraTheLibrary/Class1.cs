using System;

namespace LibraTheLibrary
{
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

    public class Computer
    {
        string mærke;
        CPU cpu;
        GPU gpu;
        RAM ram;

        public void Tænde()
        {
            Console.WriteLine("Turn me on, baby");
        }

        public void Sluk()
        {
            Console.WriteLine("RIP me");
        }

        public void Dvale()
        {
            Console.WriteLine("See ya later, alligator");
        }
    }

    public class Stationær : Computer
    {
        Kabinet kabinet;
        string skærmSocket;
        string lanSocket;

        public void Customize()
        {
            Console.WriteLine("Pimp me up, daddy");
        }

        public void JoinMasterRace()
        {
            Console.WriteLine("Glorious PC master race!");
        }
    }

    public class Bærbar : Computer
    {
        string skærmSocket;
        Skærm internSkærm;
        string lanSocket;
        Touchpad touchpad;
        Charger charger;

        public void KlapSammen()
        {
            Console.WriteLine("Harder!");
        }
    }

    public class Mobiltelefon : Computer
    {
        Skærm internSkærm;
        Cover cover;
        Charger Charger;

        public void PutILommen()
        {
            Console.WriteLine("You like that, don't you?");
        }
    }

    public class Konsol : Computer
    {
        string skærmSocket;
        string lanSocket;
        Controller controller;

        public void JoinPeasants()
        {
            Console.WriteLine("Filthy console peasant");
        }
    }

    public class BilComputer : Computer
    {
        GPS gps;
        string producent;
        int sensors;

        public double TjekAfstand()
        {
            Console.WriteLine("YOU'RE TOO CLOSE!! IDIOT!!");
            return 1.1;
        }
    }

    public class GPU
    {
        string mærke;
        string socket;
        bool doVR;
    }

    public class CPU
    {
        string mærke;
        string socket;
        int cores;
    }

    public class RAM
    {
        string mærke;
        string socket;
        int ram;
    }

    public class Kabinet
    {
        string mærke;
        string størrelse;
        int farve;

        public bool Open()
        {
            Console.WriteLine("It eats you, for it was a mimic all along");
            return true;
        }

        public void GetRidOf()
        {
            Console.WriteLine("You can't! It's cursed!!");
        }
    }

    public class Touchpad
    {
        string mærke;
        string størrelse;
        double sensitivity;

        public void Click()
        {
            Console.WriteLine("Why're you hitting yourself?");
        }
    }

    public class Skærm
    {
        string mærke;
        string størrelse;
        bool touch;

        public void DESTROY()
        {
            Console.WriteLine("ANNIHILATED!!!");
        }
    }

    public class Cover
    {
        string mærke;
        string materiale;
        int farve;

        public void Equipped()
        {
            Console.WriteLine("Zumm!");
        }
    }

    public class Charger
    {
        string mærke;
        string farve;
        double volt;

        public bool Unplug()
        {
            Console.WriteLine("YOINK!");
            return true;
        }
    }

    public class Controller
    {
        string mærke;
        string form;
        string[] kompabilitet;

        public void KastUdAfVindue()
        {
            Console.WriteLine("YEEET!!");
        }

        public bool Sluk()
        {
            Console.WriteLine("Turn me off, so you can turn me on again *wink*");
            return false;
        }
    }

    public class GPS
    {
        string mærke;
        double precision;
        double Energiforbrug;

        public double[] FåPosition(int precision)
        {
            Console.WriteLine("Enhance!");
            return new double[2];
        }
    }
}
