namespace LeetCodeSolutions.Solutions.String.Easy;

public class Valid_Palindrome {
    
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) 
            return true;
        
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            while (!char.IsDigit(s[left]) && !char.IsLetter(s[left]) && left < right)
                left++;

            while (!char.IsDigit(s[right]) && !char.IsLetter(s[right]) && left < right)
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
    
}