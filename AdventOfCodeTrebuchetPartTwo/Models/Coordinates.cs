using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeTrebuchetPartTwo.Models
{
    public class Coordinates
    {
        public string MixedCoordinates { get; set; }
        public int Coords { get; set; } = 0;

        public int UpdatedCords { get; set; } = 0;

        public Coordinates(string mixedCoordintes)
        {
            MixedCoordinates = mixedCoordintes;
            Coords = GetCords(mixedCoordintes);
            UpdatedCords = GetRealCoordinates(mixedCoordintes);
        }

        private static int GetCords(string mixedCoordinates)
        {
            string numbers = "";
            foreach (var symbol in mixedCoordinates)
            {
                if (Char.IsDigit(symbol))
                {
                    numbers += symbol.ToString();
                }
            }
            if (numbers.Length == 0 || !Char.IsDigit(numbers[0]))
            {
                return 0;
            }
            if (numbers.Length == 1)
            {
                return Convert.ToInt32(numbers + numbers);
            }

            var answer = Convert.ToInt32((numbers.Substring(0, 1) + numbers.Substring(numbers.Length - 1)));
            return answer;
        }

        private static int GetRealCoordinates(string mixedCoordinates)
        {
            string numbers = "";

            for (int i = 0; i < mixedCoordinates.Length; i++)
            {
                var length = mixedCoordinates.Substring(i).Length;
                if (char.IsDigit(mixedCoordinates[i]))
                {
                    numbers += mixedCoordinates[i].ToString();
                }
                 if (mixedCoordinates.Substring(i).Length >= 3)
                {
                    if (mixedCoordinates[i] == 'o' && (mixedCoordinates.Substring(i, 3)) == "one")
                    {
                        numbers += "1";
                    }
                    else if (mixedCoordinates[i] == 't' && (mixedCoordinates.Substring(i, 3)) == "two")
                    {
                        numbers += "2";
                    }
                    else if (mixedCoordinates[i] == 's' && (mixedCoordinates.Substring(i, 3)) == "six")
                    {
                        numbers += "6";
                    }
                }
                if (mixedCoordinates.Substring(i).Length >= 4)
                {
                    if (mixedCoordinates[i] == 'f' && (mixedCoordinates.Substring(i, 4)) == "four")
                    {
                        numbers += "4";
                    }
                    else if (mixedCoordinates[i] == 'f' && (mixedCoordinates.Substring(i, 4)) == "five")
                    {
                        numbers += "5";
                    }
                    else if (mixedCoordinates[i] == 'n' && (mixedCoordinates.Substring(i, 4)) == "nine")
                    {
                        numbers += "9";
                    }
                }
                if (mixedCoordinates.Substring(i).Length >= 5)
                {
                    if (mixedCoordinates[i] == 't' && (mixedCoordinates.Substring(i, 5)) == "three")
                    {
                        numbers += "3";
                    }
                    else if (mixedCoordinates[i] == 's' && (mixedCoordinates.Substring(i, 5)) == "seven")
                    {
                        numbers += "7";
                    }
                    else if (mixedCoordinates[i] == 'e' && (mixedCoordinates.Substring(i, 5)) == "eight")
                    {
                        numbers += "8";
                    }
                }
            }
            if (numbers.Length == 0 || !Char.IsDigit(numbers[0]))
            {
                return 0;
            }
            if (numbers.Length == 1)
            {
                return Convert.ToInt32(numbers + numbers);
            }
            var answer = Convert.ToInt32((numbers.Substring(0, 1) + numbers.Substring(numbers.Length - 1)));
            return answer;
        }
    }
}
