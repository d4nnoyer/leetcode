namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Word_Pattern {
    public static bool WordPattern(string pattern, string s)
    {
        const char separator = ' ';
        var text = s.AsSpan();
        var patternDict = new Dictionary<char, int>(26);

        var index = 0;
        foreach (var wordRange in text.Split(separator))
        {
            if (index >= pattern.Length)
                return false; 
            var patternSymbol = pattern[index];
            var word = text[wordRange];
            var wordHash = string.GetHashCode(word);
            if (patternDict.TryGetValue(patternSymbol, out var mappedWordHash))
            {
                if (mappedWordHash != wordHash)
                    return false;
            }
            else if (patternDict.ContainsValue(wordHash))
                return false;
            else
                patternDict.Add(patternSymbol, wordHash);

            index++;
        }
        
        return index == pattern.Length;
    }
}