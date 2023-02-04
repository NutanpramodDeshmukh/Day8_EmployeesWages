using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageSwitchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent = random.Next(0, 3);
            int dayHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            int partimeHour = 4;

            switch (isPresent)
            {
                case 0:
                    Console.WriteLine(name + " is Absent");
                    Console.WriteLine("Daily Wage" +dailyWage);
                    break;

                case 1:
                    Console.WriteLine(name + " is Present");
                    dailyWage = dayHour * wagePerHour;
                    Console.WriteLine("Daily Wage" + dailyWage);
                    break;

                case 2:
                    Console.WriteLine(name + " is Present for half day ");
                    dailyWage = partimeHour * wagePerHour;
                    Console.WriteLine("Daily Wage" + dailyWage);
                    break;

            }
        }
    }
}
