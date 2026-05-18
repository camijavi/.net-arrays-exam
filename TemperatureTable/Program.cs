namespace TemperatureTable;

class Program
{
    static void Main(string[] args)
    {

        int days = 5;
        int schedules = 2;
        double[,] temperatures = new double[days, schedules];

        Console.Clear();
        for (int s = 0; s < schedules; s++)
        {
            if (s == 0)
            {
                Console.WriteLine("\nPlease enter the temperatures for the MORNING:");
            }
            else
            {
                Console.WriteLine("\nPlease enter the temperatures for the EVENING:");
            }
            for (int d = 0; d < days; d++)
            {
                Console.Write($"Day {d + 1}:  ");

                while (!double.TryParse(Console.ReadLine(), out temperatures[d, s]))
                {
                    Console.Write("Invalid entry. Please enter a number: ");
                }
            }
        }

        // se definen las variables para calcular las estadísticas globales
        double maximaGlobal = double.MinValue;
        double minimaGlobal = double.MaxValue;
        double sumaTotal = 0;

        Console.WriteLine("\n\n--- TEMPERATURE SUMMARY ---");

        Console.WriteLine("\nAverage temperature of each day:");
        for (int d = 0; d < days; d++)
        {
            double manana = temperatures[d, 0];
            double tarde = temperatures[d, 1];

            // Cálculos del día
            double dayAverage = (manana + tarde) / 2.0;
            Console.WriteLine($"- Day {d + 1}: {dayAverage}°C");

            // Acumuladores para globales
            sumaTotal += manana + tarde;
            maximaGlobal = Math.Max(maximaGlobal, Math.Max(manana, tarde));
            minimaGlobal = Math.Min(minimaGlobal, Math.Min(manana, tarde));
        }

        double GlobalAverage = sumaTotal / (days * schedules);

        Console.WriteLine("\nEstadísticas Generales:");
        Console.WriteLine($"> Average Temperature: {GlobalAverage:F1}°C");
        Console.WriteLine($"> Highest Temperature: {maximaGlobal}°C");
        Console.WriteLine($"> Lowest Temperature: {minimaGlobal}°C");
    }
}