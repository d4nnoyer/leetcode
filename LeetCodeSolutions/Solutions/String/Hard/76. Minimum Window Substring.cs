namespace LeetCodeSolutions.Solutions.String.Hard;

public class Minimum_Window_Substring
{

    public string MinWindow(string s, string t)
    {
        Span<int> charsCount = stackalloc int[128];
        foreach (var c in t.AsSpan()) 
            charsCount[c]++;

        int counter = t.Length;
        int minLength = int.MaxValue;
        int left = 0;
        int right = 0;
        int head = 0;
        
        while (right < s.Length)
        {
            var rightChar = s[right++];
            if(charsCount[rightChar]-- > 0) 
                counter--;
            while (counter == 0)
            {
                if (right - left < minLength)  
                    minLength = right - (head = left);
                var leftChar = s[left++];
                if (charsCount[leftChar]++ == 0) 
                    counter++;
            }  
        }

        return minLength == int.MaxValue ? "" :  s.Substring(head, minLength);
    }
}