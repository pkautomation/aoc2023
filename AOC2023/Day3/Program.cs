using Day3;
using Shared;

var puzzle = FileReader.ReadFile();
var totalScore = 0;

var engineMap = new char[puzzle.Count + 2, puzzle[0].Length + 2];

for (int i = 0; i < puzzle.Count + 1; i++)
{
    for (int j = 0; j < puzzle[0].Length + 1; j++)
    {
        engineMap[i, j] = '.';
    }
}

for  (int i = 1; i < puzzle.Count; i++)
{
    for (int j = 1; j < puzzle[0].Length; j++)
    {
        engineMap[i, j] = puzzle[i - 1][j - 1];
    }
}

MyFunctions.PrintMap(engineMap);

Console.WriteLine();
Console.WriteLine(totalScore);

