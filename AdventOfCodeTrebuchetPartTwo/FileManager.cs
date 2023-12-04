using AdventOfCodeTrebuchetPartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeTrebuchetPartTwo
{
    public static class FileManager
    {
        public static List<Coordinates> ReadFile(string path)
        {
            var result = "";
            List<Coordinates> coordinates = new List<Coordinates>();
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            foreach (string line in result.Split(Environment.NewLine))
            {
                coordinates.Add(new Coordinates(line));
            }

            return coordinates;
        }
    }
}
