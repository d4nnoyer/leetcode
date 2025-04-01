namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Longest_Common_Prefix {
    
    public static string LongestCommonPrefix(string[] strs)
    {
        int index;
        var minimalLength = int.MaxValue;
        foreach (var str in strs)
            if (str.Length < minimalLength)
                minimalLength = str.Length;

        if (minimalLength == 0)
            return "";

        for (index = 0; index < minimalLength; index++)
        {
            var currChar = strs[0][index];
            foreach (var str in strs)
            {
                if (str[index] != currChar)
                    return strs[0][..index];
            }
        }

        return strs[0][..minimalLength];
    }
}