using Shared;
using System.Text.RegularExpressions;

var puzzle = FileReader.ReadFile();
int totalScore = 0;

foreach (var item in puzzle) {
    int score = ParseRowValue(item);
    totalScore += score;
}

Console.WriteLine(totalScore);

int ParseRowValue(string row)
{
    var regex = new Regex(@"(one|two|three|four|five|six|seven|eight|nine|[1-9])");
    var match = regex.Matches(row);
    var regex2 = new Regex(@"(one|two|three|four|five|six|seven|eight|nine|[1-9])", RegexOptions.RightToLeft);
    var match2 = regex2.Matches(row);

    string resString = string.Empty;

    if (int.TryParse(match[0].Value, out _))
    {
        resString += match[0].Value;
    } else
    {
        resString += ParseStringToInt(match[0].Value);
    }

    if (int.TryParse(match2[^1].Value, out _))
    {
        resString += match2[^1].Value;
    }
    else
    {
        resString += ParseStringToInt(match2[^1].Value);
    }

    var res = int.Parse(resString);

    return res;
}

int ParseStringToInt(string word)
{
    if (word == "one") return 1;
    if (word == "two") return 2;
    if (word == "three") return 3;
    if (word == "four") return 4;
    if (word == "five") return 5;
    if (word == "six") return 6;
    if (word == "seven") return 7;
    if (word == "eight") return 8;
    if (word == "nine") return 9;

    throw new InvalidCastException("could not find translation");
}