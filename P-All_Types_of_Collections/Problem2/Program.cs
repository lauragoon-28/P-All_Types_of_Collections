using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a list that will hold all of the users grades.  Keep prompting the user if they have another grade to enter 
             until they say 'no'.  Once you have all of the inputs, use a for each loop to iterate through the list and calculate 
            the average.  Output the users grade average.*/

            List<double> grades = new List<double>();

            string answerDone = "no";
            double grade = 0;
            while (answerDone != "yes")
            {
                Console.WriteLine("Please enter one of your grades.");
                string answer = Console.ReadLine();

                while (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine("Invalid answer. Please enter a number");
                    answer = Console.ReadLine();
                }

                grades.Add(grade);

                Console.WriteLine("Are you finished entering all of your grades?");
                answerDone = Console.ReadLine();
            }

            double sumGrade = 0;
            foreach (double currentGrade in grades)
            {
                sumGrade = sumGrade + currentGrade;
            }
            double averageScore = sumGrade / grades.Count;

            Console.WriteLine($"Your grade average is {averageScore.ToString("N2")}.");


        }
    }
}
