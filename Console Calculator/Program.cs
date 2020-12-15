using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Calculator command:");

            //Issaugome ivesties duomenis
            string calculator = Console.ReadLine();

            //Filtruojame ivesta Stringa naudodami regex ir atsikratome Abeceles raidziu bei specialiu simboliu. Issaugome be tusciu saraso nariu.
            string[] numbersFromString = Regex.Split(calculator, @"[a-zA-Z!@#$%^&,.?:{}|\<>]");
            numbersFromString = numbersFromString.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //Paverciame sarasa atgal i stringa
            var backToString = string.Join("", numbersFromString);

            //atspausdiname pateikta filtruota stringa
            Console.WriteLine(backToString);

            //Magic time 
            DataTable finalExpression = new DataTable();
            Console.WriteLine(finalExpression.Compute(backToString, string.Empty));

            Console.ReadLine();
        }
    }
}