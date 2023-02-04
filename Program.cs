using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalHour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent;
            int dayHour = 8;
            int wagePerHour = 20;
            int partimeHour = 4;
            int dayPerMonth = 20;
            int totalHour = 0;


            for (int i = 0; i < dayPerMonth; i++)
            {
                isPresent = random.Next(0, 3);
                switch (isPresent)
                {
                    case 0:
                        totalHour += 0;
                        break;


                    case 1:
                        totalHour += dayHour;
                        break;


                    case 2:
                        totalHour += partimeHour;
                        break;

                }

            }

            int monthlyWage = totalHour * wagePerHour;
            Console.WriteLine(name+ "Monthly wage" +monthlyWage);

        }
    }
    }
}
