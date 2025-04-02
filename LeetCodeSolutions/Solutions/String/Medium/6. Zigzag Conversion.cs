namespace LeetCodeSolutions.Solutions.String.Medium;

public static class Zigzag_Conversion {
    
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1 && s.Length == 1)
            return s;

        Span<char> result = stackalloc char[s.Length];

        var resultIndex = 0;
        var period = numRows * 2 - 2;

        for (int row = 0; row < numRows; row++)
        {
            var increment = 2 * row;

            for (int i = row; i < s.Length; i += increment)
            {
                result[resultIndex++] = s[i];

                if (increment != period) 
                    increment = period - increment;
            }
        }

        return result.ToString();
    }
}