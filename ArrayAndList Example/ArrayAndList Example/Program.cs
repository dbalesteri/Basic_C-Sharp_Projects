using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] villainArray = { "Gollum", "Sauron", "Saruman", "Shelob", "The Witch-king of Angmar", "Smaug", "Gríma Wormtongue", "Mouth of Sauron", "Lurtz", "Grishnákh", };

            Console.WriteLine("Hello! I have an array of 10 villain's names you might recognize. \nEnter an index of the array (a number 0-9 in this case) to get one randomly printed to you!");

            bool moveOnVillain = false;

            while (!moveOnVillain)
            {
                Console.WriteLine("Your index choice:");
                int firstChoice = Convert.ToInt32(Console.ReadLine());
                if (firstChoice > villainArray.Length - 1)
                {
                    Console.WriteLine("You must choose a valid index of the array!");
                } else
                {
                    Console.WriteLine("\nSelected name: " + villainArray[firstChoice] + "\n");
                    bool validAnswer = false;
                    while (!validAnswer)
                    {
                        Console.WriteLine("Care to view another? Type \"yes\" or \"no\".");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "no")
                        {
                            moveOnVillain = true;
                            validAnswer = true;
                        }
                        else if (answer == "yes")
                        {
                            moveOnVillain = false;
                            validAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid answer. Please type \"yes\" or \"no\".\n");
                            validAnswer = false;
                        }
                    }
                }
            }

            int[] ringArray = { 3, 7, 9, 1 };
            string[] ringDesc = { "Three Rings for the Elven-kings under the sky", "Seven for the Dwarf lords in their halls of stone", "Nine for Mortal Men doomed to die", "One for the Dark Lord on his dark throne" };
            Console.Clear();
            Console.WriteLine("Moving on, I now have an array of 4 important numbers. \nEnter an index of the array (a number 0-3 in this case) to get one randomly printed to you!\n");

            bool moveOnNumber = false;

            while (!moveOnNumber)
            {
                Console.WriteLine("Your index choice:");
                int secondChoice = Convert.ToInt32(Console.ReadLine());
                if (secondChoice > ringArray.Length - 1)
                {
                    Console.WriteLine("You must choose a valid index of the array!");
                }
                else
                {
                    Console.WriteLine("\nNumber from array: " + ringArray[secondChoice]);
                    Console.WriteLine("\n\"" + ringDesc[secondChoice] + "\"\n");
                    bool validAnswer = false;
                    while (!validAnswer)
                    {
                        Console.WriteLine("Care to view another? Type \"yes\" or \"no\".");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "no")
                        {
                            moveOnNumber = true;
                            validAnswer = true;
                        }
                        else if (answer == "yes")
                        {
                            moveOnNumber = false;
                            validAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid answer. Please type \"yes\" or \"no\".\n");
                            validAnswer = false;
                        }
                    }
                }
            }
            Console.Clear();
            List<string> fellowshipList = new List<string>();
            fellowshipList.Add("Frodo Baggins");
            fellowshipList.Add("Gandalf the Grey");
            fellowshipList.Add("Samwise \"Sam\" Gamgee");
            fellowshipList.Add("Meriadoc \"Merry\" Brandybuck");
            fellowshipList.Add("Peregrin \"Pippin\" Took");
            fellowshipList.Add("Aragorn");
            fellowshipList.Add("Legolas");
            fellowshipList.Add("Gimli");
            fellowshipList.Add("Boromir");

            Console.WriteLine("Lastly, I have a list of names of 9 companions. \nEnter an index of the list (a number 0-8 in this case) to get one randomly printed to you!\n");

            bool moveOnList = false;

            while (!moveOnList)
            {
                Console.WriteLine("Your index choice:");
                int thirdChoice = Convert.ToInt32(Console.ReadLine());
                if (thirdChoice > fellowshipList.Count - 1)
                {
                    Console.WriteLine("You must choose a valid index of the list!");
                }
                else
                {
                    Console.WriteLine("\nSelected name: " + fellowshipList[thirdChoice] + "\n");
                    bool validAnswer = false;
                    while (!validAnswer)
                    {
                        Console.WriteLine("Care to view another? Type \"yes\" or \"no\".");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "no")
                        {
                            moveOnList = true;
                            validAnswer = true;
                        }
                        else if (answer == "yes")
                        {
                            moveOnList = false;
                            validAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid answer. Please type \"yes\" or \"no\".\n");
                            validAnswer = false;
                        }
                    }

                }
            }
            Console.Clear();
            Console.WriteLine("That's all! Press any key to exit.");
            Console.ReadLine();

        }
    }
}
