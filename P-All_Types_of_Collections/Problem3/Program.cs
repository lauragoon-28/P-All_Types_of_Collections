using System;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a dictionary that will hold multiple values.  The key will be the course code (e.g. MIS3013, MIS3383, etc.) 
            and the values will be all of the students final grades (e.g. 0.95, 0.8, etc.).  Add at least 3 courses codes and at 
            least 3 grades in each one.  Calculate the average for each course code and output it to the user, make sure to 
            format it as a percent.
            If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior to adding it*/

            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();

            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(0.80);
            courseGrades["MIS3013"].Add(0.95);

            courseGrades.Add("MIS3383", new List<double>());
            courseGrades["MIS3383"].Add(0.80);
            courseGrades["MIS3383"].Add(0.70);
            courseGrades["MIS3383"].Add(0.98);

            courseGrades.Add("MIS3303", new List<double>());
            courseGrades["MIS3303"].Add(0.99);
            courseGrades["MIS3303"].Add(0.87);
            courseGrades["MIS3303"].Add(0.79);

        
            double sum = 0;
            double average = 0;
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];

                for (double i = 0; i < courseGrades.Count; i++)
                {
                    sum = sum + courseGrades[i];
                    average = sum / courseGrades.Count;
                }
                Console.WriteLine($"The average for {courseCode} is {average.ToString("P2")}");
            }


        }
    }
}
