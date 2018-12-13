using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    public enum Gender
    {
        female = 0, male
    }
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            string gender;

            
            do {
                Console.Write("Year: "); year = int.Parse(Console.ReadLine());
                if (year < 0 || year > DateTime.Today.Year)
                    Console.WriteLine($"Introduceti un an valid intre 0 si {DateTime.Today.Year}");
            } while (year<0 || year > DateTime.Today.Year);
            do {
                Console.Write("Month: "); month = int.Parse(Console.ReadLine());
                if (month < 1 || month >12)
                    Console.WriteLine($"Introduceti numarul corestunzator lunii [1-12]");
            } while (month<1 || month>12);

            do {
                Console.Write("Day: "); day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 31)
                    Console.WriteLine($"Introduceti numarul corestunzator zilei de nastere [1-31]");
            } while (day<1 || day>31);

            Console.Write("Gender[M/F]: "); gender = Console.ReadLine();


            DateTime dateOfBirth = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;
            //AgeCalculator method calling with two object's type arguments
            AgeCalculator(dateOfBirth, currentDate);
            int? gen;
            if (gender == "M" || gender == "m")
            {
                gen = (int)Gender.male;
            }
            else if (gender == "F" || gender == "f")
            {
                gen = (int)Gender.female;
            }
            else gen = null;

            if (gen.HasValue)
            {
                if (gen == 1)
                {
                    if (DateTime.Today.Year - dateOfBirth.Year >= 65)
                        Console.WriteLine("Retired");
                    else
                        Console.WriteLine("He will retire at 65 years old");
                }
                if (gen == 0)
                {
                    {
                        if (DateTime.Today.Year - dateOfBirth.Year >= 63)
                            Console.WriteLine("Retired");
                        else
                            Console.WriteLine("She will retire at 63 years old");
                    }
                }
            }
            else Console.WriteLine("Invalid Gender!");




        }
        //method for calculation of complete age (years, months, days)
        public static void AgeCalculator(DateTime dateOfBirth, DateTime currentDate)
        {
            int nrYears = 0;
            int nrMonths = 0;
            int nrDays = 0;
            nrDays = currentDate.Day - dateOfBirth.Day;
            nrMonths = currentDate.Month - dateOfBirth.Month;
            nrYears = currentDate.Year - dateOfBirth.Year;
            if (nrDays < 0)
            {
                nrDays += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                nrMonths--;
                if (nrMonths < 0)
                {
                    nrMonths += 12;
                    nrYears--;
                }
            }
            if (nrMonths < 0)
            {
                nrMonths += 12;
                nrYears--;
            }
            Console.WriteLine($"{nrYears} de ani, {nrMonths} luni, {nrDays} zile");
        }
    }
}
