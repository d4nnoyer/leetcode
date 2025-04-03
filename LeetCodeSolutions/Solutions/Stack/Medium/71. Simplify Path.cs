using System.Text;

namespace LeetCodeSolutions.Solutions.Stack.Medium;

public static class Simplify_Path {
    public static string SimplifyPath(string path)
    {
        const char slash = '/';
        ReadOnlySpan<char> pathSpan = path.AsSpan();
        ReadOnlySpan<char> upDir = ['.', '.']; 
        ReadOnlySpan<char> currDir = ['.'];
        var dirsStack = new Stack<Range>();

        var right = 0;
        while (right < pathSpan.Length)
        {
            if (pathSpan[right] == slash)
            {
                right++;
                continue;
            }

            var left = right;
            while (right < pathSpan.Length && pathSpan[right] != slash)
                right++;

            var dirRange = new Range(left, right);
            var span = pathSpan[dirRange];
            if (span.SequenceEqual(upDir))
                dirsStack.TryPop(out _);
            else if (span.SequenceEqual(currDir) is false)
                dirsStack.Push(dirRange);
        }

        if (dirsStack.Count == 0) 
            return "/";
        
        Span<Range> ranges = stackalloc Range[dirsStack.Count];
        for (int i = ranges.Length - 1; i >= 0; i--)
            ranges[i] = dirsStack.Pop();
        
        var sb = new StringBuilder();
        foreach (var range in ranges)
        {
            sb.Append(slash);
            sb.Append(pathSpan[range]);
        }
                
        return sb.ToString();
    }
}