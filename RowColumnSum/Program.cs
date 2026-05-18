namespace RowColumnSum;

class Program
{
    static void Main(string[] args)
    // 0.0 
    //
    //
    {
        int rows = 3;
        int columns = 3;
        int[,] matrix = new int[rows, columns];
        int DiagonalSum = 0;


        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {

                Console.Write($"Value for [{r},{c}]: ");

                while (true)
                {
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Error: Input cannot be empty or just spaces.");
                        continue;
                    }

                    if (int.TryParse(input, out matrix[r, c]) && matrix[r, c] > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Error: Please enter a valid whole number greater than 0.");
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            DiagonalSum += matrix[i, i];
        }

        Console.WriteLine("--- SUM OF ROWS ---");
        for (int r = 0; r < rows; r++)
        {
            int RowSum = 0;

            for (int c = 0; c < columns; c++)
            {
                RowSum += matrix[r, c];
            }

            Console.WriteLine($"Total of the Row {r}: {RowSum}");
        }

        Console.WriteLine("--- SUM OF COLUMNS ---");
        for (int c = 0; c < columns; c++)
        {
            int ColumnSum = 0;

            for (int r = 0; r < rows; r++)
            {
                ColumnSum += matrix[r, c];
            }

            Console.WriteLine($"Total of the Row {c}: {ColumnSum}");
        }

    }
}
