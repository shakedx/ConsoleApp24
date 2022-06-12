using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
