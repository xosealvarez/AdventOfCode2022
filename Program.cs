using AdventOfCode2022.Puzzles;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PuzzlesDay2 puzzle = new PuzzlesDay2(@"./Inputs/InputDay2.txt");
            Console.WriteLine("Part 1: " + puzzle.getPart1());
            Console.WriteLine("Part 2: " + puzzle.getPart2());

            Console.WriteLine("Hello, World!");
        }
    }
}