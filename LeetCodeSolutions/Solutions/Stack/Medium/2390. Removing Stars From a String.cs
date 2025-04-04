namespace LeetCodeSolutions.Solutions.Stack.Medium;

public static class Removing_Stars_From_a_String {
    
    public static string RemoveStars(string s)
    {
        // Stack is not required
        const char star = '*';
        var writePtr = 0;
        Span<char> result = stackalloc char[s.Length];

        foreach (var c in s)
            if (c != star)
                result[writePtr++] = c;
            else
                writePtr--;

        return result[..writePtr].ToString();
    }
}