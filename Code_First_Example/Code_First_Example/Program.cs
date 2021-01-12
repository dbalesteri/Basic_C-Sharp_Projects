using System;
using System.Data.Entity;

namespace Code_First_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Console.WriteLine("Student Database\n\nEnter in the name of a new student:");
                string sName = Console.ReadLine();
                var student = new Student() { StudentName = sName };

                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine(sName + " has been added. Thank you.");
                Console.ReadKey();
            }
        }
    }
}
