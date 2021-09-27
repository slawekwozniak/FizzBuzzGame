using System;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine("*** Witaj w grze FizzBuzz ***");

            while (true)
            {
                Console.WriteLine(fizzBuzz.GetResult(GetNumber()));

                Console.WriteLine("Czy chcesz kontynuować grę? Jeśli tak to naciśnij \'T\'");
                if (Console.ReadLine().ToUpper() != "T") break;
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                Console.WriteLine("\nPodaj liczbę całkowitą:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłowe dane.");
                }
            }
        }
    }
}
