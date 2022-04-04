using System;

namespace ConsoleApp2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Цикл работает пока искомое число не найдено
            bool isNumberFound = false;

            //Число с которого идет отсчет
            int startingNumber = 2;

            //Степень в которую возводим число
            int degree = 2;

            //Подсчет количество степеней
            int amountOfDegree = 0;

            //Число, которое нужно превысить
            int numberToGetOver = random.Next(0,1000);

            while (!isNumberFound)
            {
                startingNumber *= degree;
                amountOfDegree++;
                if (startingNumber > numberToGetOver)
                {
                    amountOfDegree++;
                    Console.WriteLine("Число которое загадали: " + numberToGetOver);
                    Console.WriteLine("Количество степеней двойки: " + amountOfDegree);
                    Console.WriteLine("Степень двойки , превосходящее число: " + startingNumber);
                    break;
                }
            }
        }
    }
}
