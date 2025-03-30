namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Is_Subsequence {
    
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;
        
        var searchValueIndex = 0;
        foreach (var c in t)
        {
            if (c != s[searchValueIndex]) 
                continue;
            
            searchValueIndex++;
            if (searchValueIndex == s.Length)
                return true;
        }
        
        return false;
    }
}