using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Day3;

public class MyFunctions
{
    public static void PrintMap(char[,] map)
    {
        for (int i = 0; i < map.GetLength(0) - 1; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < map.GetLength(1) - 1; j++)
            {
                Console.Write(map[i, j]);
            }
        }
    }

    public static bool IsNumber(char[,] map, int x, int y)
    {
        return int.TryParse(map[x, y].ToString(), out _);
    }

    public static bool IsSymbol(char[,] map, int x, int y)
    {
        var regexForSymbol = new Regex("[^a-z.0-9]");
        return regexForSymbol.IsMatch(map[x, y].ToString());
    }

    public static bool NumberHasSymbolNeighbor(char[,] map, int x, int y, int numberLength)
    {
        //petla gorny rzad
        // z lewej
        // z prawej
        // petla dolny rzad

        return false;
    }



}
