namespace LeetCodeSolutions.Solutions.String.Easy;

public class Merge_Strings_Alternately {
    public static string MergeAlternately(string word1, string word2)
    {
        Span<char> result1 = stackalloc char[word1.Length + word2.Length];
        
        var leastWordLength = word1.Length < word2.Length ? word1.Length : word2.Length;
        var mostWordLength = word1.Length < word2.Length ? word2.Length : word1.Length;

        for (var i = 0; i < leastWordLength; i++)
        {
            result1[i*2] = word1[i];
            result1[i*2+1] = word2[i];
        }

        if (leastWordLength != mostWordLength)
        {
            var longerWord = word1.Length < word2.Length ? word2 : word1;
            result1.Slice(leastWordLength * 2);
            longerWord
                .AsSpan()[leastWordLength..]
                .CopyTo(result1[(leastWordLength * 2)..]);
        }
      
        return result1.ToString();
    }
}