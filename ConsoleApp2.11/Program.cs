using System;

namespace ConsoleApp2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            bool isNumberFound = false;
                
            int startingNumber = 2;          
            int degree = 2;
            int amountOfDegree = 0;        
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
