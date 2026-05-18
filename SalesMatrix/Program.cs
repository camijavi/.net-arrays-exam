namespace SalesMatrix;

class Program
{
    static void Main(string[] args)
    {
        int products = 3;
        int weeks = 4;
        double totalSales = 0;
        double[,] sales = new double[products, weeks];

        Console.Clear();

        for (int p = 0; p < products; p++)
        {
            Console.WriteLine($"\nPlease enter the sales for PRODUCT {p + 1}: ");
            for (int w = 0; w < weeks; w++)
            {
                Console.Write($"Week {w + 1}: ");

                while (!double.TryParse(Console.ReadLine(), out sales[p, w]))
                {
                    Console.Write("Invalid entry. Please enter a number: ");
                }
                totalSales += sales[p, w];
            }
        }

        Console.WriteLine("\n\n--- SALES MATRIX ---");

        for (int p = 0; p < products; p++)
        {
            Console.Write($"Product {p + 1,-2} |");

            double productTotal = 0;

            for (int w = 0; w < weeks; w++)
            {
                productTotal += sales[p, w];
            }

            Console.WriteLine($" {productTotal,12:C} |");
        }

        Console.WriteLine($"> Total Sales (All Products): {totalSales:C}");

    }
}
