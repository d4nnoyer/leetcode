namespace LeetCodeSolutions.Solutions.DynamicProgramming.Hard;

public class Count_the_Number_of_Powerful_Integers {
    
    public static long NumberOfPowerfulInt(long start, long finish, int limit, string s)
    {
        var startStr = (start - 1).ToString();
        var finishStr = finish.ToString();
        return GetPowerfulCount(finishStr, s, limit) - GetPowerfulCount(startStr, s, limit);
    }
    

    private static long GetPowerfulCount(string border, string s, int limit) {
        if (border.Length < s.Length)
            return 0;
        if (border.Length == s.Length)
            return string.CompareOrdinal(border, s) >= 0 ? 1 : 0;

        var suffix = border[^s.Length..];
        var preLen = border.Length - s.Length;
        long count = 0;

        for (var i = 0; i < preLen; i++) {
            var digit = border[i] - '0';
            if (limit < digit) {
                count += (long)Math.Pow(limit + 1, preLen - i);
                return count;
            }
            count += digit * (long)Math.Pow(limit + 1, preLen - 1 - i);
        }
        if (string.CompareOrdinal(suffix, s) >= 0) 
            count++;
        
        return count;
    }
}