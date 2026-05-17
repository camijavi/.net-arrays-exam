namespace NumberSearch;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10] { 17, 1, 29, 17, 23, 13, 19, 29, 6, 27 };
        int validNumber;
        int rep = 0;

        Console.Clear();
        Console.WriteLine("Please input a number");

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
                break;
            }

            Console.WriteLine("Error: Please enter a valid whole number greater than 0.");
        }

        for (int i = 0; i < 10; i++)
        {
            if (validNumber == numbers[i])
            {
                rep++;
            }
        }

        if (rep > 0)
        {
            Console.WriteLine($"\nFound: The number {validNumber} is in the array");
        }
        else
        {
            Console.WriteLine($"\nNot found: The number {validNumber} does not exist in the array");
        }
    }
}
