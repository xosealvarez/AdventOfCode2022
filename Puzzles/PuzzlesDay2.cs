using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Puzzles
{
    public class PuzzlesDay2
    {
        private readonly string[] _input;
        private string[] _oponentShapes = { "A", "B", "C" };
        private string[] _myShapes = { "X", "Y", "Z" };

        public PuzzlesDay2(string inputFilePath)
        {
            _input = System.IO.File.ReadAllLines(inputFilePath);
        }

        public int getPart1()
        {
            int score = 0;

            foreach (string line in _input)
            {
                var shapes = line.Split();                
                score += GetTotalScorePart1(shapes[0], shapes[1]);
            }

            return score;
        }

        private int GetTotalScorePart1(string oponentShape, string myShape)
        {
            return GetScoreByShape(myShape, _myShapes) + GetScoreWinner(oponentShape, myShape);
        }

        private int GetScoreByShape(string shape, string[] shapes)
        {
            return Array.IndexOf(shapes, shape) + 1;
        }

        private int GetScoreWinner(string oponentShape, string myShape)
        {
            var oponentIndex = Array.IndexOf(_oponentShapes, oponentShape);
            var myIndex = Array.IndexOf(_myShapes, myShape);

            if (oponentIndex == myIndex)
            {
                return 3;
            }
            else if (((oponentIndex + 2) % 3) ==  myIndex)
            {
                return 0;
            }
            else
            {
                return 6;
            }
        }

        public int getPart2()
        {
            int score = 0;

            foreach (string line in _input)
            {
                var shapes = line.Split();
                score += GetTotalScorePart2(shapes[0], shapes[1]);
            }

            return score;
        }

        private int GetTotalScorePart2(string oponentShape, string roundEnd)
        {
            if(roundEnd == "Y")
            {
                return GetScoreByShape(oponentShape, _oponentShapes) + 3;
            }
            else if (roundEnd == "X") 
            {
                var oponentIndex = Array.IndexOf(_oponentShapes, oponentShape);
                return GetScoreByShape(_myShapes[((oponentIndex+2)%3)], _myShapes) + 0;
            }
            else
            {
                var oponentIndex = Array.IndexOf(_oponentShapes, oponentShape);
                return GetScoreByShape(_myShapes[(oponentIndex + 1) % 3], _myShapes) + 6;
            }
        }
    }
}
