namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Group_Anagrams {
    
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new SortedList<int, IList<string>>();
        Span<int> charCountarr = stackalloc int[26];

        foreach (var str in strs)
        {
            var hash = GetArrayHash(str, charCountarr);
            if (anagramGroups.TryGetValue(hash, out var anagramGroup))
            {
                anagramGroup.Add(str);
            }
            else
            {
                anagramGroups.Add(hash, new List<string> {str}); 
            }
        }

        return anagramGroups.Values;
    }
    
    private static int GetArrayHash(string s, Span<int> charCountarr)
    {
        charCountarr.Clear();

        foreach (var c in s)
            charCountarr[c - 'a']++;
            
        var hash = 0;
        foreach (var count in charCountarr)
        {
            hash = HashCode.Combine(count, hash);
        }

        return  hash;
    }
}