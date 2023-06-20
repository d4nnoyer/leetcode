namespace LeetCodeSolutions.Solutions.String.Easy;

public class Valid_Parentheses {
    
    private static readonly Dictionary<char, char> Pairs = new()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' },
    };
    
    public static bool IsValid(string s)
    {
        var parStack = new Stack<char>();
        foreach (var ch in s)
        {
            if (Pairs.ContainsKey(ch))
            {
                parStack.Push(ch);
            }
            else if (parStack.Count == 0 || Pairs[parStack.Pop()] != ch)
                return false;
            
        }        
        
        return parStack.Count == 0 ;
    }
    
}