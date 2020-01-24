using System;
using System.Collections.Generic;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var randomNum = rnd.Next(0, 2);
            String[] computerChoices = { "rock", "paper", "scissors" };
            var computerChoice = computerChoices[randomNum];

            string playerChoice = "";

            Console.WriteLine("Rock, Paper, or Scissors?");
            System.Console.WriteLine("Choice: ");
            playerChoice = Console.ReadLine().ToLower();

            System.Console.WriteLine($"Your Choice was {playerChoice}");
            System.Console.WriteLine($"Computer Choice was {computerChoice}");

            if (playerChoice == computerChoice)
            {
                System.Console.WriteLine("You Tied!");
            }
            else if
           (playerChoice == "rock" && computerChoice == "paper" || playerChoice == "paper" && computerChoice == "scissors" || playerChoice == "scissors" && computerChoice == "rock")
            {
                System.Console.WriteLine("Sorry you Loose, Computer Wins");
            }
            else if
          (playerChoice == "rock" && computerChoice == "scissors" || playerChoice == "paper" && computerChoice == "rock" || playerChoice == "scissors" && computerChoice == "paper")
            {
                System.Console.WriteLine("Great Scott!! You are a Genious! You WIN!!");
            }
            else
                System.Console.WriteLine("invalid answer");
        }



    }
}

