using System.Text;

namespace LeetCodeSolutions.Solutions.String.Medium;

public static class Reverse_Words_in_a_String {
    
    public static string ReverseWords(string s)
    {
        const char space = ' ';
        var sb = new StringBuilder(s.Length);
        var startIndex = 0;
        var endIndex = s.Length - 1;

        while (s[startIndex] == space)
            startIndex++;
        
        while (s[endIndex] == space)
            endIndex--;

        var currentWordLength = 0;
        while (startIndex <= endIndex)
        {
            while (endIndex >= startIndex && s[endIndex] != space)
            {
                currentWordLength++;
                endIndex--;
            }
            
            sb.Append(s.AsSpan(endIndex + 1, currentWordLength));
            sb.Append(space);
            currentWordLength = 0;

            while (endIndex >= startIndex && s[endIndex] == space)
                endIndex--;
        }

        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}