using System.Text;

namespace LeetCodeSolutions.Solutions.String.Medium;

public class Count_and_Say {
    
    public static string CountAndSay(int n)
    {
        var result = "1";
        for (var i = 1; i < n; i++) 
            result = RLE(result);
        
        return result;
    }
    
    private static string RLE(string s) {
        var sb = new StringBuilder();
        var count = 1;

        for (var i = 1; i < s.Length; i++) 
        {
            if (s[i] == s[i - 1])
                count++;
            else
            {
                sb.Append(count).Append(s[i-1]);
                count = 1;
            }
        }

        sb.Append(count).Append(s[^1]);
        return sb.ToString();
    }
}