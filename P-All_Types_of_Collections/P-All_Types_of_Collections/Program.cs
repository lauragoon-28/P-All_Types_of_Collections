using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) and the other will hold course 
             numbers (e.g. 3033, 3013, etc.).  Ask the user to input 3 for each, store them in the array.  Then use a different 
             loop to output the results to the user concatenated together (e.g. MIS3033, MATH3013).*/

            string[] subjects = new string[3];
            double[] courseNumbers = new double[3];

            Console.WriteLine("Enter a course subject.");
            subjects[0] = Console.ReadLine();

            Console.WriteLine("Enter a course subject.");
            subjects[1] = Console.ReadLine();

            Console.WriteLine("Enter a course subject.");
            subjects[2] = Console.ReadLine();

            Console.WriteLine("Enter the course numbers for the subject");
            while (double.TryParse(Console.ReadLine(), out courseNumbers[0]) == false)
            {
                Console.WriteLine("Invavlid input. Enter a new number.");
            }
            
            Console.WriteLine("Enter the course numbers for the subject");
            while (double.TryParse(Console.ReadLine(), out courseNumbers[1]) == false)
            {
                Console.WriteLine("Invavlid input. Enter a new number.");
            }

            Console.WriteLine("Enter the course numbers for the subject");
            while (double.TryParse(Console.ReadLine(), out courseNumbers[2]) == false)
            {
                Console.WriteLine("Invavlid input. Enter a new number.");
            }

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}{courseNumbers[i]}");
            }
        }
    }
}
