namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Group_Anagrams {
    
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new SortedList<int, IList<string>>();
        
        int GetArrayHash(string s)
        {
            var counts = new int[26];
            foreach (var c in s.ToCharArray())
                counts[c - 'a']++;

            return  counts.Aggregate(0, HashCode.Combine);
        }

        foreach (var str in strs)
        {
            var hash = GetArrayHash(str);
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
    
}