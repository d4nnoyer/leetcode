namespace LeetCodeSolutions.Solutions.String.Medium;

public static class Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length {
    
    public static int MaxVowels(string s, int k)
    {
        var currentVowels = 0;
        for (var i = 0; i < k; i++)
            if (IsVowel(s[i]))
                currentVowels++;

        var maxVowels = currentVowels;
        for (var i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
                currentVowels++;
            if(IsVowel(s[i-k]))
                currentVowels--;
            maxVowels = Math.Max(maxVowels, currentVowels);
        }
        
        return maxVowels;
    }
    private static bool IsVowel(char c) {
        // 1065233 is a bit mask that is the value of
        // 0bzyx...cba
        // Where each letter (after 0b suffix) is replaced by a 1 if it's a vowel and 0 otherwise.
        return (1065233 >> (c - 'a') & 1) != 0;
    }
}