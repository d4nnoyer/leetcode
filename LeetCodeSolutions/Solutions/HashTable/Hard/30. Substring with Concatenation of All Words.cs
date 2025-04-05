namespace LeetCodeSolutions.Solutions.HashTable.Hard;

public class Substring_with_Concatenation_of_All_Words {
    
    public static IList<int> FindSubstring(string s, string[] words)
    {
        if (words.Length == 0)
            return [];

        var text = s.AsSpan();
        var wordLength = words[0].Length;
        var concatLength = wordLength * words.Length;
        if (s.Length < concatLength)
            return [];

        var count = 0;
        int wordIndex;
        Span<int> wordsStat = stackalloc int[words.Length];
        wordsStat.Fill(1);
        
        var wordsDict = new Dictionary<int, int> ();
        foreach (var word in words)
            if (wordsDict.TryGetValue(word.GetHashCode(), out wordIndex))
                wordsStat[wordIndex]++;
            else
                wordsDict[word.GetHashCode()] = count++;

        var result = new List<int>();
        Span<int> currentStat = stackalloc int[wordsDict.Count];
        Span<int> cache = stackalloc int[s.Length];
        var endHead = text.Length - wordLength + 1;
        var endTail = text.Length - (concatLength - wordLength)  + 1;

        for (var offset = 0; offset < wordLength; ++offset)
        {
            wordsStat[..currentStat.Length].CopyTo(currentStat);

            int left;
            for  (left = offset + concatLength - (wordLength * 2);  left >= offset; left -= wordLength)
            {
                var wordSpan = text.Slice(left, wordLength);
                var hash = string.GetHashCode(wordSpan);
                count = wordsDict.TryGetValue(hash, out wordIndex) ? wordIndex : -1;
                cache[left] = count;

                if (count < 0 || currentStat[count] == 0)
                    break;

                currentStat[count]--;
            }
            
            left += wordLength;

            int right;
            for (right = offset + concatLength - wordLength; right < endHead && left < endTail; right += wordLength)
            {
                var wordSpan = text.Slice(right, wordLength);
                var hash = string.GetHashCode(wordSpan);
                count = wordsDict.TryGetValue(hash, out wordIndex) ? wordIndex : -1;
                cache[right] = count;

                if (count < 0)
                {
                    left = right + wordLength;
                    wordsStat[..currentStat.Length].CopyTo(currentStat);
                    continue;
                }

                currentStat[count]--;
                while (currentStat[count] < 0)
                {
                    currentStat[cache[left]]++;
                    left += wordLength;
                }

                if (right - left == concatLength - wordLength)
                    result.Add(left);
            }
        }

        return result;
   }
}