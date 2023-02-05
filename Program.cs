using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int isPresent;
            int dayHour = 8;
            int wagePerHour = 20;
            int partimeHour = 4;
            int dayPerMonth = 20;
            int totalHour = 0;
            int i = 0;

            while (totalHour <= 100 && i <= dayPerMonth)
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

                i++;

            }

            int monthlyWage = totalHour * wagePerHour;
            Console.WriteLine("Monthly wage=" + monthlyWage);

        }
    }
    }

