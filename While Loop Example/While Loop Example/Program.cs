using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Does the weather you're having match the weather I'm having?");
            Console.WriteLine("What's the weather like for you?");
            string yourWeather = Console.ReadLine().ToLower();
            string myWeather = "sunny";
            bool sameWeather = myWeather == yourWeather;

            if (sameWeather)
            {
                Console.WriteLine("Wow, we both have sunny weather!");
            } else
            {
                do
                {
                    switch (yourWeather)
                    {
                        case "rainy":
                            Console.WriteLine("It's not rainy here, but can you guess what kind of weather I'm having instead?");
                            yourWeather = Console.ReadLine().ToLower();
                            break;
                        case "cloudy":
                            Console.WriteLine("It's not cloudy here, but can you guess what kind of weather I'm having instead?");
                            yourWeather = Console.ReadLine().ToLower();
                            break;
                        case "foggy":
                            Console.WriteLine("It's not foggy here, but can you guess what kind of weather I'm having instead?");
                            yourWeather = Console.ReadLine().ToLower();
                            break;
                        case "snowy":
                            Console.WriteLine("It's not snowy here, but can you guess what kind of weather I'm having instead?");
                            yourWeather = Console.ReadLine().ToLower();
                            break;
                        case "sunny":
                            Console.WriteLine("You guessed it, it's sunny!");
                            sameWeather = true;
                            break;
                        default:
                            Console.WriteLine("It's not like that here, but can you guess what kind of weather I'm having instead?");
                            yourWeather = Console.ReadLine().ToLower();
                            break;
                    }
                }
                while (!sameWeather);
            }


            Console.WriteLine("Now just for fun, can you guess what the temperature is here?");
            int guess = Convert.ToInt32(Console.ReadLine());
            int temperature = 65;

            bool tempComparison = guess == temperature;

            while (!tempComparison)
            {
                switch (guess)
                {
                    case 62:
                        Console.WriteLine("Nope, it's not 62. It's a little warmer! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 63:
                        Console.WriteLine("Nope, it's not 63. It's a little warmer! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 64:
                        Console.WriteLine("Nope, it's not 64. It's a little warmer! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 65:
                        Console.WriteLine("Nailed it. It's 65 degrees and sunny!");
                        tempComparison = true;
                        break;
                    case 66:
                        Console.WriteLine("Nope, it's not 66. It's a little colder! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 67:
                        Console.WriteLine("Nope, it's not 67. It's a little colder! Try again:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Not quite! Hint: it's somewhere between 61 and 68.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}
