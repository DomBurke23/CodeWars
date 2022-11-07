using System.Globalization;

namespace TitleCase;

public class TitleCaseProgram
{
    static void Main(string[] args)
    {
    }

    public static string TitleCaseV1(string title, string minorWords = "")
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

    static string FirstToUpper(string input)
    {
        var s = input.ToCharArray();
        s[0] = Char.ToUpper(s[0]);
        return new String(s);
    }

    public static string TitleCase(string title, string minorWords = "")
    {
        if (String.IsNullOrEmpty(title)) return title;

        var titleWords = title.Split(' ')
            .Select(w => w.ToLower());

        var minWords = (minorWords ?? "").Split(' ')
            .Select(w => w.ToLower());

        return FirstToUpper(String.Join(" ",
            titleWords.Select(w => minWords.Contains(w) ? w : FirstToUpper(w))));
    }
}