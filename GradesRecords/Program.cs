using System.Security.Principal;

namespace GradesRecords;

class Program
{
    static void Main(string[] args)
    {
        int gradesNum = 8;
        double[] grades = new double[gradesNum];

        double validNumber;

        Console.Clear();
        Console.WriteLine("Please enter 8 grades to validate");

        for (int i = 0; i < gradesNum; i++)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Input cannot be empty or just spaces.");
                    continue;
                }

                if (double.TryParse(input, out validNumber) && validNumber >= 0 && validNumber <= 100)
                {
                    grades[i] = validNumber;
                    break;
                }
                Console.WriteLine("Error: Please enter a valid number between 0 and 100");
            }
        }

        double highest = grades.Max();
        double lowest = grades.Min();
        double average = grades.Average();

        for (int i = 0; i < gradesNum; i++)
        {
            Console.Write("\n" + grades[i] + ", ");
        }

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Highest grade: {highest}");
        Console.WriteLine($"Lowest grade: {lowest}");
        Console.WriteLine($"Average: {average:F2}");

    }
}
