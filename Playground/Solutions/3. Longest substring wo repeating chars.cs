namespace Playground.Solutions;

public class Longest_substring_wo_repeating_chars {
    
    public int LengthOfLongestSubstring(string s)
    {
        int maxLen = 0;
        var substring = new HashSet<char>();
        int leftPos = 0; 
        int rightPos = 0;
    
        while(rightPos < s.Length) {
            while (substring.Contains(s[rightPos]))
            {
                substring.Remove(s[leftPos++]);  
            }
            substring.Add(s[rightPos++]); 
            maxLen = Math.Max(maxLen, rightPos - leftPos);
        }
 
        return maxLen;
    }
}