using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSakutinBook.TaskPractice.CSharpBasics
{
    internal class ArrayPractice
    {
        //Задача 1
        //Объявите переменную, которая хранит массив, тип
        //элементов у которого string и поместите туда ссылку
        //на новый массив с типом элементов string,
        //размерностью в 5 элементов.
        //Далее, через оператор индексации,
        //проинициализируйте каждый элемент.
        public void FirstTask()
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Иванов";
            stringArray[1] = "Иван";
            stringArray[2] = "Иванович";
            stringArray[3] = "C# - программист";
            stringArray[4] = "Разработчик игр";
        }

        //Задача 2
        //Напишите программу, которая выведет все элементы массива.
        public void SecondTask()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 15;
            numbers[2] = 2;

            Console.WriteLine("Массив: ");

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Элемент [{i+1}] = {numbers[i]}");
            }
        }

        //Задача 3
        //Напишите программу, которая выведет сумму всех элементов массива.
        public void ThirdTask()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 15;
            numbers[2] = 2;

            int numberSumm = 0;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Элемент [{i + 1}] = {numbers[i]}");
                numberSumm = numberSumm + numbers[i];
            }

            Console.WriteLine($"Сумма всех элементов массива: {numberSumm}");
        }

        //Задача 4
        //Напишите программу, которая выведет максимальное число в массиве.
        public void FourthTask()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 15;
            numbers[2] = 2;

            int maxNumber = numbers[0];

            Console.WriteLine("Массив: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Элемент [{i + 1}] = {numbers[i]}");
                
                if(numbers[i] > maxNumber )
                {
                    maxNumber = numbers[i];
                }

            }

            Console.WriteLine($"Макисмальное число в массиве: {maxNumber}");
        }

    }
}
