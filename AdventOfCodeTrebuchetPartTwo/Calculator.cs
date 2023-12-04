using AdventOfCodeTrebuchetPartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeTrebuchetPartTwo
{
    public class Calculator
    {
        public static void CalculateSum(List<Coordinates> coordinates)
        {
            var sum = 0;
            foreach (var cord in coordinates)
            {
                Console.WriteLine($"Coordinates: {cord.Coords}");
                sum += cord.Coords;
            }
            Console.WriteLine(sum);
        }

        public static void CalculateUpdatedCoordinatesSum(List<Coordinates> coordinates)
        {
            var sum = 0;
            foreach (var cord in coordinates)
            {
                Console.WriteLine($"Coordinates: {cord.UpdatedCords}");
                sum += cord.UpdatedCords;
            }
            Console.WriteLine(sum);
        }
    }
}
