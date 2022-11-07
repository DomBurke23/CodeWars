using System.Globalization;

namespace TitleCase;

public class TitleCaseProgram
{
    static void Main(string[] args)
    {
    }

    public static string TitleCase(string title, string minorWords = "")
    {
        TextInfo textInfo = new CultureInfo("en-UK", false)
            .TextInfo;

        title = title.ToLower();
        if (minorWords == null) minorWords = "";
        minorWords = minorWords.ToLower();
        var titleList = title.Split(' ');
        var minorWordList = minorWords.Split(' ');

        var count = 0;
        foreach (var word in titleList)
        {
            if (count == 0)
            {
                titleList[count] = textInfo.ToTitleCase(word);
                count++;
                continue;
            }
            else if (minorWordList.Contains(word))
            {
                count++;
            }
            else
            {
                titleList[count] = textInfo.ToTitleCase(word);
                count++;
            }
        }

        string response = string.Join(" ", titleList);

        return response;
    }
}