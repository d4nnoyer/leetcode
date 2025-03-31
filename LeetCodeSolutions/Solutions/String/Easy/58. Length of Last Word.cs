namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Length_of_Last_Word {
    public static int LengthOfLastWord(string s)
    {
        var length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (length == 0)
                    continue;
                else 
                    break;
            }
            length++;
        }

        return length;
    }
}