namespace EvenOddNumCounter;

class Program
{
    static void Main(string[] args)
    {
        int validation = 10;
        int[] numbers = new int[validation];

        int evenNumCounter = 0;
        int oddNumCounter = 0;
        int addition = 0;

        int validNumber;

        Console.Clear();
        Console.WriteLine("Please enter 10 whole numbers");

        for (int i = 0; i < validation; i++)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Input cannot be empty or just spaces.");
                    continue;
                }

                if (int.TryParse(input, out validNumber) && validNumber > 0)
                {
                    numbers[i] = validNumber;
                    break;
                }
                Console.WriteLine("Error: Please enter a valid number ");
            }
        }


        for (int i = 0; i < validation; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumCounter++;
            }
            else
            {
                oddNumCounter++;
            }

            if (numbers[i] != 5)
            {
                addition += numbers[i];
            }
        }

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Total Even Numbers: {evenNumCounter}");
        Console.WriteLine($"Total Odd Numbers: {oddNumCounter}");
        Console.WriteLine($"The sum of all numbers (excluding 5): {addition}");
    }
}
