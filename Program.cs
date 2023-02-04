using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage");
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent = random.Next(0, 2);

            if (isPresent == 0)
            {
                Console.WriteLine(name + " is Absent");
            }
            else
            {
                Console.WriteLine(name + " is Present");
            }
        }
    }
}
