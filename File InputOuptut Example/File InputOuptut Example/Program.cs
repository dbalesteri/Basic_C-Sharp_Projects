using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_InputOuptut_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine());
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //get desktop path to write files to desktop
            using (StreamWriter file = new StreamWriter(desktopPath + @"\log.txt", true)) //use streamwriter and using to manage memory and append the user entered text to text file on desktop
            {
                file.WriteLine(number); //append to file
            }
            Console.WriteLine("Thank you, your file can be found at: Desktop\\log.txt");
            Console.ReadLine();
        }
    }
}
