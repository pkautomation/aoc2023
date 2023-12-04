using Shared;
using System.Text.RegularExpressions;

var puzzle = FileReader.ReadFile();
var totalScore = 0;
var totalScore2 = 0;


int GetMaxValue(string row, maxValues color)
{
    var blueRegex = new Regex("[0-9]+ blue");
    var redRegex = new Regex("[0-9]+ red");
    var greenRegex = new Regex("[0-9]+ green");

    int maxScore = 0;
    MatchCollection matches = null;

    switch(color)
    {
        case maxValues.BLUE:
            matches = blueRegex.Matches(row);
            break;
        case maxValues.GREEN:
            matches = greenRegex.Matches(row);
            break;
        case maxValues.RED:
            matches = redRegex.Matches(row);
            break;
    }

    foreach (Match match in matches!) {
        var colorValue = int.Parse(match.Value.ToString().Split(' ').First());
        if (colorValue > maxScore) maxScore = colorValue;
    }

    return maxScore;
}


for(int i = 0; i < 100; i++)
{
    var rowScore = i + 1;
    var blueMaxVal = GetMaxValue(puzzle[i], maxValues.BLUE);
    var redMaxVal = GetMaxValue(puzzle[i], maxValues.RED);
    var greenMaxVal = GetMaxValue(puzzle[i], maxValues.GREEN);

    totalScore2 += blueMaxVal * redMaxVal * greenMaxVal;
    if (blueMaxVal <= (int)maxValues.BLUE && redMaxVal <= (int)maxValues.RED && greenMaxVal <= (int)maxValues.GREEN) totalScore += rowScore;
}


Console.WriteLine(totalScore);
Console.WriteLine(totalScore2);

enum maxValues
{
    BLUE = 14,
    GREEN = 13,
    RED = 12
};