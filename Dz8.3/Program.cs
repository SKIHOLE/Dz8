using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz8._3
{
    enum EmployeePosition
    {
        Manager = 160,
        Developer = 180,
        Salesperson = 150,
        HR = 160,
        Accountant = 160
    }
    class Accountant
    {
        public bool AskForBonus(EmployeePosition worker, int hours)
        {
            if ((int)worker<=hours)
            {
                return true;
            }
            else return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напишіть кількість проработанних годин");
            int.TryParse(Console.ReadLine(), out int Hour);
            Console.WriteLine("виберіть вашу посаду");
            int pos = 0;
            foreach (EmployeePosition position in Enum.GetValues(typeof(EmployeePosition)))
            {
                Console.WriteLine($"{(int)position}= {position}");
            }

            
            if (int.TryParse(Console.ReadLine(), out int positionCode))
            {
                if (Enum.IsDefined(typeof(EmployeePosition), positionCode))
                {
                    EmployeePosition selectedPosition = (EmployeePosition)positionCode;
                    Accountant accountant = new Accountant();
                    bool isEligibleForBonus = accountant.AskForBonus(selectedPosition, Hour);
                    Console.WriteLine(isEligibleForBonus ? "Вам належить премія." : "Вам не належить премія.");
                }
                else
                {
                    Console.WriteLine("Недійсний код посади.");
                }
            }
            else
            {
                Console.WriteLine("Недійсний код посади.");
            }
        }
    }
    }
