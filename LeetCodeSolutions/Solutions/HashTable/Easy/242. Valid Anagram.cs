namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Valid_Anagram {
    
    
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) 
            return false;

        // Due to description of task, strings contain only lowercase latin symbols 
        var counts = new int[26];

        foreach (var c in s.ToCharArray())
            counts[c - 'a']++;
        foreach (var c in t.ToCharArray())
            if (--counts[c-'a']<0) return false;

        return true;
    }
}