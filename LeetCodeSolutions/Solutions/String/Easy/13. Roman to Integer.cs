namespace LeetCodeSolutions.Solutions.String.Easy;

public class Roman_to_Integer
{
    private static readonly Dictionary<char, int> RomansNumerals =
        new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
    public static int RomanToInt(string s)
    {
        int number = 0;
        int currentNominal = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var curr = s[i];
            if (RomansNumerals[curr] >= currentNominal)
            {
                currentNominal = RomansNumerals[curr];
                number += currentNominal;
            }
            else
            {
                number -= RomansNumerals[curr];
            }
        }
        
        return number;
    }
}