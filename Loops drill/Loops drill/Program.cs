using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Loops_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1
            string[] stringArray = { "5: ", "10: ", "15: " };

            Console.WriteLine("input some text.");
            string value = Console.ReadLine();

            for (byte i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + value;
            }

            foreach (string text in stringArray)
            {
                Console.WriteLine(text);
            }

            //step 2 - 3
            while (true)
            {
                Console.WriteLine("Forever");
                break;
            }
            Console.ReadLine();


            //step 4 
            byte a = 0;
            StringBuilder output = new StringBuilder();
            while (a < 100)
            {
                if (a == 0)
                {
                    output.Append('o');
                }
                else if (a == 55)
                {
                    output.Insert(a - 1, 'W');
                }
                else if (a == 56)
                {
                    output.Insert(a - 1, 'h');
                }
                else if (a == 57)
                {
                    output.Insert(a - 1, 'o');
                }
                else
                {
                    output.Insert(a - 1, '.');
                }

                Console.WriteLine(output);
                a++;
                Thread.Sleep(20);
            }


            //step 5
            while (1 <= a)
            {
                output.Remove(Math.Max(a - 2, 0), 1);
                a--;
                Console.WriteLine(output);
                Thread.Sleep(20);
            }

            //step 6 - 8
            List<string> colors = new List<string> { "Red", "Blue", "Yellow", "Orange", "Green" };

            Console.WriteLine("There is a list of 5 colors, try to guess one.");
            value = Console.ReadLine();
            bool correctcolor = false;

            while (!correctcolor)
            {
                for (int i = 0; i < colors.Count; i++)
                {
                    if (colors[i].Contains(value))
                    {
                        Console.WriteLine("You guessed the " + Convert.ToString(i + 1) + "'s place");
                        correctcolor = true;
                        Console.ReadLine();
                        break;
                    }
                }
                if (!correctcolor)
                {
                    Console.WriteLine("Incorrect, try again.");
                    value = Console.ReadLine();
                }
            }

            //step 9 - 10
            List<string> morecolors = new List<string> { "Teal", "Pink", "Brown", "Grey", "Pink" };

            Console.WriteLine("Here is another list of 5 colors for you to guess, however there is a pair of identical colors this time.");
            value = Console.ReadLine();

            bool othercorrectcolor = false;

            while (!othercorrectcolor)
            {
                for (int i = 0; i < morecolors.Count; i++)
                {
                    if (morecolors[i].Contains(value))
                    {
                        Console.WriteLine("You guessed the " + Convert.ToString(i + 1) + "'s place");
                        othercorrectcolor = true;
                    }
                }
                if (!othercorrectcolor)
                {
                    Console.WriteLine("Incorrect, try again.");
                    value = Console.ReadLine();
                }
            }
            Console.ReadLine();

            //step 11
            Console.WriteLine("This following list is of food items, and we will see if there are any repeats.");
            Console.ReadLine();

            List<string> fooditems = new List<string> { "Burgers", "Blueberries", "Oreos", "Bananas", "Blueberries" };
            List<string> foodrepeat = new List<string>();
            foreach (string food in fooditems)
            {
                if (foodrepeat.Contains(food))
                {
                    Console.WriteLine(food + " is a repeat.");
                }
                else
                {
                    Console.WriteLine(food + " is new to the list.");

                }
                foodrepeat.Add(food);
            }



            Console.ReadLine();
        }
    }
}
