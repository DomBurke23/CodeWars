namespace TenPinBowling;

public class TenPinBowlingProgram
{
    static void Main(string[] args)
    {
    }

    public static int BowlingScore(string input)
    {
        int score = 0;
        int rollIndex = 0;
        var rolls = input.Replace(" ", "").ToCharArray().Select(c => c.ToString()).ToArray();
        var maxRolls = rolls.Length;

        for (int frame = 0; frame < 10 && rollIndex < maxRolls; frame++)
        {
            if (rolls[rollIndex] == "X") // Strike
            {
                score += 10;
                score += GetStrikeBonus(rolls, rollIndex);
                rollIndex++;
            }
            else if (rolls[rollIndex + 1] == "/") // Spare
            {
                score += 10;
                score += GetSpareBonus(rolls, rollIndex);
                rollIndex += 2;
            }
            else // Open frame
            {
                score += GetRollValue(rolls[rollIndex]) + GetRollValue(rolls[rollIndex + 1]);
                rollIndex += 2;
            }
        }

        return score;
    }
    
    private static int GetRollValue(string roll)
    {
        if (roll == "X" || roll == "/")
        {
            return 10;
        }
        else
        {
            return int.Parse(roll);
        }
    }

    private static int GetStrikeBonus(string[] rolls, int rollIndex)
    {
        int bonus = 0;
        bonus += GetRollValue(rolls[rollIndex + 1]);
        if (rollIndex < rolls.Length - 2 && rolls[rollIndex + 2] == "/")  
        {
            bonus += 10 - GetRollValue(rolls[rollIndex + 1]); // Account for the first roll of the spare
        }
        else
        {
            bonus += GetRollValue(rolls[rollIndex + 2]);
        }
        return bonus;
    }

    private static int GetSpareBonus(string[] rolls, int rollIndex)
    {
        return GetRollValue(rolls[rollIndex + 2]);
    }
}