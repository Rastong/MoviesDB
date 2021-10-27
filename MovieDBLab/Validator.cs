using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    class Validator
    {
        //
        public static double GetNumber()
        {
            double result = 0;

            while(true)
            {
                try
                {
                    result = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number. Try again.");
                }
            }

            return result;
        }

        public static double GetNumber(double min, double max)
        {
            double result = 0;
            while (true)
            {
                result = GetNumber();
                if(result < min || result > max)
                {
                    Console.WriteLine($"That value is too low, please enter a number between {min} and {max}");
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public static bool getContinue()
        {
            bool result = true;

            while(true)
            {
                Console.WriteLine("Would you like to keep running the program? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if(choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }

        public static bool getContinue(string message)
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }

        public static int getRandom(int x)
        {
            Random rando = new Random();
            return rando.Next(1, x);
        }

        public static int getRandom(int min,int x)
        {
            Random rando = new Random();
            return rando.Next(min, x);
        }

        public static bool isAbove(int value, int min)
        {
            if (value > min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isAboveOrEqual(int value, int min)
        {
            if (value >= min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetString()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim().ToLower();
                if(input.Length > 0)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Did not understand. Please try again.");
                }
            }
        }

        public static string StringBetweenTwoOption(string option1, string option2)
        {
            while (true)
            {
                string input = GetString();
                if(input == option1)
                {
                    return input;
                }
                else if(input == option2)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Not an option, please try again.");
                }
            }
        }
        public static bool CompareToList(string input,List<string> options)
        {
            bool Valid = false;
            foreach(string s in options)
            {
                if (s == input)
                {
                    Valid = true;
                }
            }
            return Valid;
        }
    }
}
