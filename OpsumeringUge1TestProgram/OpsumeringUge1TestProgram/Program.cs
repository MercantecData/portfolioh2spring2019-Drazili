using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpsumeringUge1Library;

namespace OpsumeringUge1TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Registry registry = new Registry();
            User user1 = new User();
            Admin admin1 = new Admin();
            Job[] jobs = new Job[2] { new HourlyPaidJob(6), new DailyPaidJob(35)};


            registry.Login("lol", "kage");
            registry.AddNewUser(admin1);
            user1.isAdmin();
            admin1.changePassword(user1, "Nigger");

            foreach (Job job in jobs)
            {
                job.GetMonthlyPay();
            }

            Console.ReadLine();
        }
    }
}
