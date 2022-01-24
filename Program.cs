// See https://aka.ms/new-console-template for more information
using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play the guessing game! What number am I thinking?");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

           
            System.Random r = new Random();

            int x = r.Next(100) +1;

             bool GuessedCorrectly = false;
                    Console.WriteLine("Enter your difficulty level - Easy/Medium/Hard/Cheater");
                    string level = Console.ReadLine().ToLower();

                    if (level == "easy"){
                for (int i = 1;i <= 8; i++)

                {

                   

                      Console.Write("ATTEMPT " + i + " (You have " + (8-i) + " attempts left)" + ": Enter the your number: ");

                      int n = Convert.ToInt32(Console.ReadLine());

                      if (n == x)

                      {

                            Console.WriteLine("Congrats! You have guessed the number correctly");

                            GuessedCorrectly = true;

                            break;

                      }
                       int diff = (int)(Math.Abs(x - n));
                       bool higher = false;
                       if(x > n)
                       higher = true;
                       {
                           if (higher == false)
                           Console.WriteLine("Your guess " + n + " is high!");
                           else
                           Console.WriteLine("Your guess " + n + " is low!");
                       }
                       if (GuessedCorrectly == false && i == 8)

                {

                      Console.WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + x);

                }

        }

                    }

                    else if (level == "medium"){
                for (int i = 1;i <= 6; i++)

                {

                   

                      Console.Write("ATTEMPT " + i + " (You have " + (6-i) + " attempts left)" + ": Enter the your number: ");

                      int n = Convert.ToInt32(Console.ReadLine());

                      if (n == x)

                      {

                            Console.WriteLine("Congrats! You have guessed the number correctly");

                            GuessedCorrectly = true;

                            break;

                      }
                       int diff = (int)(Math.Abs(x - n));
                       bool higher = false;
                       if(x > n)
                       higher = true;
                       {
                           if (higher == false)
                           Console.WriteLine("Your guess " + n + " is high!");
                           else
                           Console.WriteLine("Your guess " + n + " is low!");
                       }
                       if (GuessedCorrectly == false && i == 6)

                {

                      Console.WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + x);

                }

        }

                    }
                    if (level == "hard"){
                for (int i = 1;i <= 4; i++)

                {

                   

                      Console.Write("ATTEMPT " + i + " (You have " + (4-i) + " attempts left)" + ": Enter the your number: ");

                      int n = Convert.ToInt32(Console.ReadLine());

                      if (n == x)

                      {

                            Console.WriteLine("Congrats! You have guessed the number correctly");

                            GuessedCorrectly = true;

                            break;

                      }
                       int diff = (int)(Math.Abs(x - n));
                       bool higher = false;
                       if(x > n)
                       higher = true;
                       {
                           if (higher == false)
                           Console.WriteLine("Your guess " + n + " is high!");
                           else
                           Console.WriteLine("Your guess " + n + " is low!");
                       }
                       if (GuessedCorrectly == false && i == 4)

                {

                      Console.WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + x);

                }

        }

                    }

                    if (level == "cheater"){
                for (int i = 1;i == i; i++)

                {

                   

                      Console.Write("ATTEMPT " + i + ": Enter the your number: ");

                      int n = Convert.ToInt32(Console.ReadLine());

                      if (n == x)

                      {

                            Console.WriteLine("Congrats! You have guessed the number correctly");

                            GuessedCorrectly = true;

                            break;

                      }
                       int diff = (int)(Math.Abs(x - n));
                       bool higher = false;
                       if(x > n)
                       higher = true;
                       {
                           if (higher == false)
                           Console.WriteLine("Your guess " + n + " is high!");
                           else
                           Console.WriteLine("Your guess " + n + " is low!");
                       }
                       if (GuessedCorrectly == false && i == 100)

                {

                      Console.WriteLine("Unfortunately you did not guess it correctly after 100 attempts. The correct number is: " + x);

                }

        }

                    }
        }


    


    }
}