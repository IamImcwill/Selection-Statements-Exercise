﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 36;

            //string input = Console.ReadLine();

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess == favNumber)
            {
                Console.WriteLine($"Lucky Guess!!!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine($"Too High!!!");
            }
            else
            {
                Console.WriteLine($"Too Low!!!");
            }
        }
    }
}
