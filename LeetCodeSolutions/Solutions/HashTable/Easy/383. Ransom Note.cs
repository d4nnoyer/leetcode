namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public static class Ransom_Note {
    
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Span<int> charsCounts = stackalloc int[26];
        
        foreach (var c in magazine)
            charsCounts[c - 'a']++;
        
        foreach (var c in ransomNote)
            if (charsCounts[c - 'a']-- == 0)
                return false;
        
        return true;
    }
}