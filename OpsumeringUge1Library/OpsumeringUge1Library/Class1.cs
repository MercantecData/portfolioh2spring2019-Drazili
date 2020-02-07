using System;
using System.Collections.Generic;

namespace OpsumeringUge1Library
{
    public class User
    {
        private string login;
        private string password;
        private Job Job;

        public bool isAdmin()
        {
            Console.WriteLine("Are you Admin? I don't know.");
            return false;
        }
    }

    public class Admin : User
    {
        public void changePassword(User user, string newPassword)
        {

        }
    }

    public class Registry
    {
        private List<User> users;
        private List<Admin> admins;

        public void AddNewUser(User user)
        {
            Console.WriteLine("New user added");
        }
        public bool Login(string login, string password)
        {
            Console.WriteLine("Logging in...");
            return true;
        }
    }

    public abstract class Job
    {
        public abstract int GetMonthlyPay();
    }

    public class HourlyPaidJob : Job
    {
        private int hourlyPay;

        public HourlyPaidJob(int pay)
        {
            this.hourlyPay = pay;
        }

        public override int GetMonthlyPay()
        {
            int a = hourlyPay * 7 * 30;
            Console.WriteLine("I earn " + a + " points a month");
            return a;
        }
    }

    public class DailyPaidJob : Job
    {
        private int dailyPay;

        public DailyPaidJob(int pay)
        {
            this.dailyPay = pay;
        }

        public override int GetMonthlyPay()
        {
            int a = dailyPay * 30;
            Console.WriteLine("I earn " + a + " points a month");
            return a;
        }
    }
}
