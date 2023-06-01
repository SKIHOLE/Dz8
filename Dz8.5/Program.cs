using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дату народження (у форматі ДД.ММ.РРРР):");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime birthday))
            {
                DateTime currentDate = DateTime.Today;
                DateTime nextBirthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);
                if (nextBirthday < currentDate)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                int daysUntilNextBirthday = (nextBirthday - currentDate).Days;
                Console.WriteLine("Кількість днів до наступного дня народження: " + daysUntilNextBirthday);
            }

            else
            {
                Console.WriteLine("Неправильний формат дати!");
            }

            Console.ReadLine();
        }
    }
}
