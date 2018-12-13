using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Andrei";
            string lastName = "Gandila";

            //string.Compare
            Console.WriteLine(string.Compare(firstName, lastName));
            Console.WriteLine(string.Compare(lastName, lastName));
            Console.WriteLine(string.Compare(lastName, firstName));

            //string.Concat
            string fullName = string.Concat(firstName," ", lastName);
            Console.WriteLine($"FullName: {fullName}");

            //string.Insert
            Console.WriteLine(fullName.Insert(7, "M. "));

            //string.Split
            string quote = "Amat victoria curam";
            string[] quoteWords = quote.Split(' ');
            foreach(var word in quoteWords)
            {
                Console.WriteLine(word);
            }

            //string.Contains
            string[] urls = { "www.superbet.ro", "www.publicbet.ro", "www.luckybet.org" };
            foreach(var str in urls)
            {
                if (str.Contains("bet"))
                    Console.WriteLine("Malicious url: {0}", str);
            }

            //string.Trim
            string text = "!!!!!!Ce greu e sa alegi un exemplu pentru textul de fata, chiar n-am inspiratie!!!!";
            string trimmedText = text.Trim('!');
            Console.WriteLine($"{text}\n{trimmedText}");

            //string.ToUpper, string.ToLower
            string anotherText = "Stringurile sunt destul de INTERESANTE";
            Console.Write($"{anotherText.ToUpper()}\n{anotherText.ToLower()}\n");

            //string.ToCharArray
            char[] spelledFirstName = firstName.ToCharArray();
            Console.WriteLine("Let's spell my first name: ");
            foreach(var i in spelledFirstName)
            {
                Console.WriteLine(i);
            }


        }
    }
}
