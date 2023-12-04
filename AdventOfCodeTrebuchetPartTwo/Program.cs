using System.Reflection;

namespace AdventOfCodeTrebuchetPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "Coordinates.txt");
            var coordinates = FileManager.ReadFile(FILE_PATH);
            Calculator.CalculateSum(coordinates);

            Console.WriteLine();

            Calculator.CalculateUpdatedCoordinatesSum(coordinates);
        }
    }
}