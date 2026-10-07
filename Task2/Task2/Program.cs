using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter your name: ");
            String Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your grade: ");
            int Grade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your average: ");
            double Average = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender: ");
            char Gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Welcome {Name}\nAge: {Age}\nGrade: {Grade}" +
                $"\nAverage: {Average}\nGender: {Gender}\n");


            Console.WriteLine("Uppercase: " + Name.ToUpper());
            Console.WriteLine("Lowercase: " + Name.ToLower());
            Console.WriteLine("First Letter: " + Name[0]);


            Console.WriteLine("Original avg: " + Average);
            Console.WriteLine("Bonus Marks: 5");
            Average = Average + 5;
            Console.WriteLine("New Average: "+Average);

            if (Average >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            if (Age >= 18)
            {
                Console.WriteLine("Adult: " + true);
            }
            else
            {
                Console.WriteLine("Adult: "+false);
            }

        }
    }
}
