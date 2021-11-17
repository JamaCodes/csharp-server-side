using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            AskForGuess("guess a number between 1-50!");

            void AskForGuess(string question)
            {
                int answer = 0;
                // int gueses = 4;

                while (answer != 32)
                {
                    if (answer != 32)
                    {
                        Console.Write($"{question}:  ");
                        answer = int.Parse(Console.ReadLine());
                    }
                    if (answer == 32)
                    {
                        Console.WriteLine("bih you guessed it! GRAAAH GRAHHH");
                    }
                    if (answer > 32)
                    {
                        Console.WriteLine("bih you guessed wrong! GRAAAH GRAHHH");
                        Console.Write($"{question}:  ");
                        answer = int.Parse(Console.ReadLine());
                    }
                     if (answer < 32)
                    {
                        Console.WriteLine("wrong! GRAAAH GRAHHH");
                        Console.Write($"{question}:  ");
                        answer = int.Parse(Console.ReadLine());
                    }


                }

            }
        }
     }
}
