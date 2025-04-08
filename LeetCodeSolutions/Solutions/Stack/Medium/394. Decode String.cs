using System.Text;

namespace LeetCodeSolutions.Solutions.Stack.Medium;

public class Decode_String {
    public static string DecodeString(string s)
    {
        var pairs = new Stack<(int count, StringBuilder builder)>();
        var sb = new StringBuilder();
        var currentCount = 0;

        foreach (var c in s.AsSpan())
        {
            if (char.IsDigit(c)) 
                currentCount = currentCount * 10 + (c - '0');
            else if (c == '[')
            {
                pairs.Push((currentCount, sb));
                currentCount = 0;
                sb = new StringBuilder();
            }
            else if (c == ']')
            {
                var builder = pairs.Pop();
                var currentChars = sb;
                sb = builder.builder;
                while (builder.count --> 0)
                    sb.Append(currentChars);
            }
            else
                sb.Append(c);
        }

        return sb.ToString();
    }
}