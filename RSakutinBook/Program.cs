using RSakutinBook.TaskPractice.CSharpBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSakutinBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayPractice arrayPractice = new ArrayPractice();

            Console.WriteLine("Практика массивов: ");

            Console.WriteLine("Задача 2:");
            arrayPractice.SecondTask();

            Console.WriteLine("\nЗадача 3:");
            arrayPractice.ThirdTask();

            Console.WriteLine("\nЗадача 4:");
            arrayPractice.FourthTask();

            Console.ReadKey();
        }
    }
}
