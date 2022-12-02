using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Puzzles
{
    public class PuzzlesDay1
    {
        private readonly string[] _input;
        private List<int> _sumCaloriesByElf = new List<int>();

        public PuzzlesDay1(string inputFilePath)
        {
            _input = System.IO.File.ReadAllLines(inputFilePath);
        }

        public int getPart1()
        {
            int numCalories = 0;
            
            _sumCaloriesByElf.Add(0);

            foreach (string line in _input)
            {
                if(line.Equals(string.Empty))
                {
                    _sumCaloriesByElf.Add(0);
                }
                else
                {
                    numCalories = Convert.ToInt32(line);
                    _sumCaloriesByElf[_sumCaloriesByElf.Count-1] += numCalories;
                }
            }

            _sumCaloriesByElf.Sort();
            _sumCaloriesByElf.Reverse();

            return _sumCaloriesByElf[0];
        }

        public int getPart2()
        {
            return _sumCaloriesByElf[0] + _sumCaloriesByElf[1] + _sumCaloriesByElf[2];
        }
    }
}
