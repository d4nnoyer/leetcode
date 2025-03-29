namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Greatest_Common_Divisor_of_Strings {
    
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length == 1 && str2.Length == 1)
            return str1;
        
        ReadOnlySpan<char> concatSpan1 = [..str1, ..str2];
        ReadOnlySpan<char> concatSpan2 = [..str2, ..str1];

        if (concatSpan1.Equals(concatSpan2, StringComparison.Ordinal))
        {
            var gcdLength = GetGcdLength(str1.Length, str2.Length);
            return concatSpan1[..gcdLength].ToString();
        }

        return "";
    }
    
    private static int GetGcdLength(int str1, int str2)
    {
        int least = Math.Min(str1, str2);
        while (least > 0) {
            if (str1 % least == 0 && str2 % least == 0)
                break;
            least--;
        }
        return least;
    }
}