using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_Stringbuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's build a story together.");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            name = char.ToUpper(name[0]) + name.Substring(1);
            Console.WriteLine("Thanks! What's your favorite place?");
            string place = Console.ReadLine();
            Console.WriteLine("Thanks! What's an adjective to describe yourself?");
            string adjective = Console.ReadLine().ToLower();
            Console.WriteLine("Thanks! What's something you'd exclaim in surprise?");
            string exclaimed = Console.ReadLine().ToUpper();
            Console.WriteLine("Thank you! Finally, what's a favorite saying of yours? No need to put quotation marks!");
            string saying = Console.ReadLine();

            Console.WriteLine("Thank you! Press enter to view your story:");
            Console.ReadLine();
            Console.Clear();
            StringBuilder story = new StringBuilder();

            story.Append("One dark and stormy night, " + name + " was home alone watching scary movies.\n\n");
            story.Append("Normally, " + name + " is very " + adjective + ". However, there was noise from the cellar and this made " + name + " very frightened instead.\n\n");
            story.Append(name + "'s first thought was \"I didn't know I had a cellar\". That made " + name + "'s situation that much more spooky. \n\n" + name + " shuddered and wished to be at " + place + " instead, which is much nicer.\n\n");
            story.Append(name + " decided to investigate. Approaching the cellar door, " + name + " could hear strange noises within. \n\nCarefully opening the creaking door, suddenly rats poured out! \"" + exclaimed + "!\" exclaimed " + name + " in surprise.\n\n");
            story.Append("Walking inside the dusty room, " + name + " noticed a fortune cookie sitting on a lone stool under an eerie cone of light.\n\n");
            story.Append("Approaching it cautiously, " + name + " knew there was only one thing to do: eat it. \n\n" + name + " cracked it open and inside the fortune read: \"" + saying + "\".\n\n");
            story.Append("And in moment, all was suddenly right with the world.\n\n");
            story.Append("--End of story. Thanks for reading!");

            Console.WriteLine(story);
            Console.ReadLine();


        }
    }
}
