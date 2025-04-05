namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Isomorphic_Strings {
    
    public static bool IsIsomorphic(string s, string t)
    {
        Span<int> isomorphicCharsS = stackalloc int[256];
        Span<int> isomorphicCharsT = stackalloc int[256];
        
        for (int i = 0; i < s.Length; i++)
        {
            var c1 = s[i];
            var c2 = t[i];
            if (isomorphicCharsS[c1] == 0)
                isomorphicCharsS[c1] = c2;
            if (isomorphicCharsT[c2] == 0)
                isomorphicCharsT[c2] = c1;
            if (isomorphicCharsS[c1] != c2 || isomorphicCharsT[c2] != c1)
                return false;
        }

        return true;
    }
}