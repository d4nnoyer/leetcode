namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public static class Determine_if_Two_Strings_Are_Close {
 
    public static bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;

        Span<short> word1Chars = stackalloc short[26];
        Span<short> word2Chars = stackalloc short[26];

        for (var i = 0; i < word1.Length; i++)
        {
            word1Chars[word1[i] - 'a']++;
            word2Chars[word2[i] - 'a']++;
        }
        
        for (var i = 0; i < 26; i++)
            if (word1Chars[i] == 0 && word2Chars[i] != 0)
                return false;

        word1Chars.Sort();
        word2Chars.Sort();
        
        for (var i = 0; i < 26; i++)
            if (word1Chars[i] != word2Chars[i])
                return false;
        
        return true;
    }
    
}