

using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace FizzBuzzProject
{
    class Program
    {
        static void Main()
        {

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            var newCalculator = new FizzBuzz();

            string printLetters = "Welcome to FizzBuzzBlitz!\n" +
                                  "Printing rules ";

            foreach (var _char in printLetters)
            {
                Thread.Sleep(30);
                Console.Write(_char);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(1000);
            }
            Console.Clear();

            Console.WriteLine("Welcome to FizzBuzzBlitz!");
            string printLetters2 = "You will first enter a number!\n" +
                                   "Then the program will tell you the answer!\n" +
                                   "If the number is divisable by only 3 it will return 'Fizz'!\n" +
                                   "If the number is divisable by only 5 it will return 'Buzz'!\n" +
                                   "If the number is divisable by 3 and 5 it will return 'FizzBuzz'!\n" +
                                   "If the number is divisable by neither 3 or 5 it will return 'Blitz'!" +
                                   "Press the 'enter' or 'return' key to start!";
                                   

            foreach (var _char in printLetters2)
            {
                Thread.Sleep(30);
                Console.Write(_char);
            }
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome to FizzBuzzBlitz!\n" +
                              "You will first enter a number!\n" +
                              "Then the program will tell you the answer!\n" +
                              "If the number is divisable by only 3 it will return 'Fizz'!\n" +
                              "If the number is divisable by only 5 it will return 'Buzz'!\n" +
                              "If the number is divisable by 3 and 5 it will return 'FizzBuzz'!" +
                              "If the number is divisable by neither 3 or 5 it will return 'Blitz'!");

            string printLetters4 = "Connecting to a server ";

            foreach (var _char in printLetters4)
            {
                Thread.Sleep(30);
                Console.Write(_char);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Welcome to FizzBuzzBlitz!\n" +
                              "You will first enter a number!\n" +
                              "Then the program will tell you the answer!\n" +
                              "If the number is divisable by only 3 it will return 'Fizz'!\n" +
                              "If the number is divisable by only 5 it will return 'Buzz'!\n" +
                              "If the number is divisable by 3 and 5 it will return 'FizzBuzz'!\n" +
                              "If the number is divisable by neither 3 or 5 it will return 'Blitz'!");

            string printLetters3 = "Enter the number you want to test: ";

            foreach (var _char in printLetters3)
            {
                Thread.Sleep(30);
                Console.Write(_char);
            }

            while (true)
            {
                try
                {
                    

                    var userNumberInput = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"The answer is ");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(". ");
                    }
                    Console.Write(newCalculator.FizzBuzzCalculator(userNumberInput) + "!");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.Write("Exiting program ");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(". ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The format was incorrect! Please enter a number!");
                }

                Console.WriteLine("Would you like to try again? yes/no");
                while (true)
                {
                    var userRepeatNumberInput = Console.ReadLine();
                    if (userRepeatNumberInput.ToLower() == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to FizzBuzzBlitz!\n" +
                                          "You will first enter a number!\n" +
                                          "Then the program will tell you the answer!\n" +
                                          "If the number is divisable by only 3 it will return 'Fizz'!\n" +
                                          "If the number is divisable by only 5 it will return 'Buzz'!\n" +
                                          "If the number is divisable by 3 and 5 it will return 'FizzBuzz'!\n" +
                                          "If the number is divisable by neither 3 or 5 it will return 'Blitz'!");
                        Console.Write("Ok, great! ");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(". ");
                        }
                        Console.Clear();
                        Console.WriteLine("Welcome to FizzBuzzBlitz!\n" +
                                          "You will first enter a number!\n" +
                                          "Then the program will tell you the answer!\n" +
                                          "If the number is divisable by only 3 it will return 'Fizz'!\n" +
                                          "If the number is divisable by only 5 it will return 'Buzz'!\n" +
                                          "If the number is divisable by 3 and 5 it will return 'FizzBuzz'!\n" +
                                          "If the number is divisable by neither 3 or 5 it will return 'Blitz'!");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number you want to test: ");
                        break;
                    }
                    else if (userRepeatNumberInput.ToLower() == "no")
                    {
                        Console.WriteLine("Ok, bye :(");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Ok ");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(". ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Not a correct answer! Would you like to try again? yes/no");
                        
                    }
                }

                
                

            }
            
        }
    }
}