using System;
using System.Collections.Generic;

namespace Array_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            bool select = false;
            while (select == false)
            {
                string[] nameArray = { "Jim", "Rachel", "Kevin", "Sarah" };


                Console.WriteLine("\n Select one of the names: \n\nFor Jim - Enter 0 \nFor Rachel - Enter 1 \nFor Kevin - Enter 2 \nFor Sarah - Enter 3");
                string a = Console.ReadLine();
                int index = Convert.ToInt16(a);


                if (index <= 3)
                {
                    Console.WriteLine("\n\nThe name you have selected is " + nameArray[index]);
                    select = true;

                    bool select2 = false;


                    while (select2 == false)
                    {
                        int[] intArray = { 2, 4, 6, 8, 10 };


                        Console.WriteLine("\n Select one of the numbers: For the number 2 - Enter 0 \nFor the number 4 - Enter 1 \nFor the number 6 - Enter 2 \nFor the number 8 - Enter 3 \nFor the number 10 - enter 4 ");
                        string y = Console.ReadLine();
                        int index2 = Convert.ToInt16(y);


                        if (index2 <= 4)
                        {

                            Console.WriteLine("\n\nYou have the selected the number " + intArray[index2]);
                            select2 = true;

                            bool select3 = false;
                            while (select3 == false)
                            {
                                List<string> food = new List<string>();
                                food.Add("Apples");
                                food.Add("Crackers");
                                food.Add("Chips");
                                food.Add("Sandwiches");
                                int length3 = (food.Count);

                                Console.WriteLine("\nSelect one of the food options: For Apples - Enter 0\nFor Crackers - Enter 1\nFor chips - Enter 2\nFor Sandwiches - Enter 3");
                                string b = Console.ReadLine();
                                int index3 = Convert.ToInt16(b);

                                if (index3 <= 3)
                                {
                                    Console.WriteLine("\n\nYou have chosen " + food[index3]);
                                    select = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n\nSelection error. Choose again.\n\n");
                                    select3 = false;
                                }
                            }

                        }

                        else
                        {
                            Console.WriteLine("\n\nSelection error. Choose again.\n\n");
                            select = false;
                        };
                    }
                }

                else
                {
                    Console.WriteLine("\n\nSelection error. Choose again.\n\n");
                    select = false;
                };
            }
            Console.ReadLine();
        }
    }
}
