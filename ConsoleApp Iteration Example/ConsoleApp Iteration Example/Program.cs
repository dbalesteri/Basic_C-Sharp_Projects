using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Iteration_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] titles = { "Dr. ", "Your Majesty ", "Professor ", "Capitan ", "Chef ", "President " };
            Console.WriteLine("Hello! Please enter your name and be transformed:");
            string name = Console.ReadLine();
            name = char.ToUpper(name[0]) + name.Substring(1);

            for (int i = 0; i < titles.Length; i++) // assignment part one
            {
                titles[i] = titles[i] + name;
            }

            Console.WriteLine("Like the sound of any of these?\n");
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }

            Console.WriteLine("\nWell you could be one!\nFor instance, enter a number out of 100 that represents an average of how much people like you:");
            decimal approval = Convert.ToDecimal(Console.ReadLine());
            bool validAnswer = false;
            while (!validAnswer) // assignment part two, create infinite loop by valid answer always false, then fixed it
            {
                if (approval <= 100 && approval >= 0)
                {
                    validAnswer = true;
                } else
                {
                    Console.WriteLine("Please enter a number on a scale of 0-100 as instructed:");
                    approval = Convert.ToDecimal(Console.ReadLine());
                }
            }
            

            decimal[] ratings = { 40, 47.9m, 49.4m, 55.1m, 60.9m};
            int[] president = { 45, 44, 43, 42, 41 };
            bool likeable = false;

            Console.WriteLine("\nAccording to statistics found on Wikipedia:\n");
            for (int j = 0; j < ratings.Length; j++) // assignment part 3, use "<" in loop (along with many other cases in project)
            {
                if (approval > ratings[j])
                {
                    Console.WriteLine("You're more likeable than the average approval rating (" + ratings[j] + ") of president number: " + president[j]);
                    likeable = true;
                }
                
            }

            if (!likeable)
            {
                Console.WriteLine("Yikes! Sadly, you're not more likeable than the average approval ratings of the last 5 presidents.\nHope is not lost, let's try something else.\nEnter your age:");
            } else
            {
                Console.WriteLine("\nSo you could have a career in politics and be President " + name + "!");
                Console.WriteLine("\nOr if that doesn't interest you, enter your age:");
            }

            int age = Convert.ToInt32(Console.ReadLine());

            int[] ages = { 18, 17, 59, 25, 57 };
            string[] royalty = { "Queen Victoria", "King Henry VIII", "King Edward VII", "Queen Elizabeth II", "King George IV" };
            bool young = false;

            Console.WriteLine("In comparison to British royals:\n");
            for (int k = 0; k <= ages.Length - 1; k++) // assignment part 3, use "<=" in loop
            {
                if (age == ages[k])
                {
                    Console.WriteLine("You're the same age " + royalty[k] + " was when they ascended to the throne at the age of " + ages[k] + ".");
                    young = true;
                } else if (age < ages[k])
                {
                    Console.WriteLine("You're younger than " + royalty[k] + " was when they ascended to the throne at the age of " + ages[k] + ".");
                    young = true;
                } 
            }

            if (!young && likeable)
            {
                Console.WriteLine("\nWell " + name + ", not to any fault of your own, you're not younger than anyone in my selected data of British royals.");
                Console.WriteLine("Youth isn't everything though. At least you're likeable and can maybe still be in politics!");
                Console.WriteLine("Let's try one last thing!");
            }
            else if (young && likeable)
            {
                Console.WriteLine("\nSee, " + name + "? You're still young enough to be royalty at any time!\nPlus, you're super likeable. You just have to find the kingdom for you, the people definitely follow your lead!");
                Console.WriteLine("President? King or Queen? The options are practically limitless.\nHow about we check one last thing?");
            } else if (young && !likeable)
            {
                Console.WriteLine("\nSee, " + name + "? You're still young enough to be royalty at any time!\nYou may not be likeable enough to be President, but who needs likeablitity when you can command?");
                Console.WriteLine("Let's try one last thing instead to keep more options open for you.");
            } else
            {
                Console.WriteLine("\nWell " + name + ", not to any fault of your own, you're not younger than anyone in my selected data of British royals.");
                Console.WriteLine("Youth may not be everything, but you should definitely work on getting more people to like you.\nTrust me, I'm a console.");
                Console.WriteLine("If you likely won't be President or King or Queen, let's try one last thing instead.");
            }

            List<string> qualities = new List<string>() { "mighty", "vast", "infinite", "beautiful", "restless", "uncharted", "raging", "tranquil", "mysterious", "damned", "radiant", "relentless", "secretive", "home", "unfathomable" };

            Console.WriteLine("\nGive me a word you would use to describe the ocean:"); //assignment part four, using input text to search through string list
            string adjective = Console.ReadLine();
            bool matching = false;

            for (int l = 0; l < qualities.Count; l++)
            {
                if (adjective == qualities[l])
                {
                    Console.WriteLine("\nCongratulations Capitan " + name + "!\nThat word is index " + l + " on my list of 15 words used by sea Capitans to describe the ocean.");
                    matching = true;
                    break;
                }
            }

            if (!matching)
            {
                Console.WriteLine("\nMaybe the sea isn't for you.\nIn determining if you'd be a boat Captain,\nyour answer did not coincide with any on my list of 15 words used by sea Capitans to describe the ocean.");
            }

            Console.WriteLine("\nBefore we get to your results, I have a quick little game!");
            Console.WriteLine("\nPress enter to continue!");
            Console.ReadLine();
            Console.Clear();

            List<string> flips = new List<string>();
            List<int> indicies = new List<int>();
            Random random = new Random();
            int randomNum;
            bool psychic = false;
            int counter = 0;
            while (counter < 10)
            {
                randomNum = random.Next(0, 2);
                if (randomNum == 0)
                {
                    flips.Add("heads");
                } else
                {
                    flips.Add("tails");
                }
                counter++;
            }

            Console.WriteLine("I just flipped a coin 10 times.\nCan you guess which side it landed on more times?\nGuess \"heads\" or \"tails\":"); // assignment part 5, at least two identical strings, user input to search
            string guess = Console.ReadLine().ToLower();
            if (guess != "heads" && guess != "tails")
            {
                Console.WriteLine("I told you to guess heads or tails.\nYou didn't do that, " + name + ".\nMoving on...");
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                for (int m = 0; m < flips.Count; m++)
                {
                    if (flips[m] == guess)
                    {
                        indicies.Add(m);
                        Console.WriteLine("It's a match at index: " + m);
                    }
                }

                List<string> checkAgainst = new List<string>(); // to satisfy assignment part 6, checking if there was ever a duplicate
                bool duplicateWord = false;
                Console.WriteLine("\nLet's go over the flips to double check that we had multiples of one side:\n");
                foreach (string flip in flips) // to satisfy assignment part 6, checking if there was ever a duplicate
                {

                    foreach (string check in checkAgainst)
                    {
                        if (check == flip)
                        {
                            duplicateWord = true;
                            Console.WriteLine(check + " has appeared at least once already so far!");
                            break;
                        }
                        else
                        {
                            duplicateWord = false;
                        }
                    }
                    if (!duplicateWord)
                    {
                        checkAgainst.Add(flip);
                        Console.WriteLine(flip + " has not appeared yet in the list so far!");
                    }

                }

                Console.WriteLine("\nLet's evaluate our results:");
                if (indicies.Count == 0)
                {
                    Console.WriteLine("\nIt was never a match. Curse you probability!");
                }
                else
                {
                    Console.WriteLine("\nIt was a match " + indicies.Count + " times!");
                    if (indicies.Count > 5)
                    {
                        Console.WriteLine("You got it right over half the time! You could be psychic!");
                        psychic = true;
                    }
                    else if (indicies.Count == 5)
                    {
                        Console.WriteLine("50% ain't bad kid when it comes to random!");
                    }
                    else
                    {
                        Console.WriteLine("Well you didn't get it over half right, but who could predict that anyway?");
                    }
                }


                Console.WriteLine("\nThat was a fun little break.\nPress enter to continue on to your overall results!");
                Console.ReadLine();
                Console.Clear();
            }
            

            Console.Write("Here are your final analysis based on our interaction here today:\n\n");

            if (likeable && young && matching)
            {
                Console.WriteLine("Your potential is limitless. I salute you President, Majesty, and Capitan " + name + ".");
            } else if (likeable && young && !matching)
            {
                Console.WriteLine(name + ", you have great potential as a young enough to be royalty and likeable person.\nThe sea isn't for you and that's ok! Avoid that scurvy.");
            }
            else if (likeable && !young && matching)
            {
                Console.WriteLine(name + ", you have great potential as a politian or Captain.\nMost Presidents and Captains are older anyway. With age comes experience!");
            }
            else if (likeable && !young && !matching)
            {
                Console.WriteLine(name + ", you have some potential to be President as a likeable person. They're typically older which you also have in common\nThe sea isn't for youand that's ok! Avoid that scurvy.");
            }
            else if (!likeable && young && matching)
            {
                Console.WriteLine(name + ", you have great potential to be ruler of people and command the sea. You may not be likeable but great things await you!");
            }
            else if (!likeable && young && !matching)
            {
                Console.WriteLine(name + ", you have some potential to be in a place in power as a ruler. You won't be winning popularity contests to get there though.\nThe sea isn't for you and that's ok! Avoid that scurvy.");
            }
            else if (!likeable && !young && matching)
            {
                Console.WriteLine(name + ", you old salty sea dog.\nYou may border on the line of pirate, as age and popularity aren't on your side. At least the sea will always in your heart.");
            } else
            {
                Console.WriteLine("Come on, " +name + ". Really? Let's talk about this. Either you're:\nA) A developer testing every outcome\nB) A completionist trying to get every ending by lying on answers\nC) An unlikeable, old, landlubber\n\nLet's hope it's not C.");
            }

            if (age > 99)
            {
                Console.WriteLine("\nI almost forgot to mention, wow you're old.");
            }


            if (psychic)
            {
                Console.WriteLine("\nBut what do I know anyway. And at least no matter what, you're psychic!\nThat's it, thank you!");
            } else
            {
                Console.WriteLine("\nBut what do I know anyway. Too bad you didn't turn out to be psychic, wou'dve been cool to meet a psychic.\nThat's it, thank you!");
            }
            Console.WriteLine("\nPress enter to close");
            Console.ReadLine();

        }
    }
}
