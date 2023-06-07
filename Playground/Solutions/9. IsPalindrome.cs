namespace Playground.Solutions;

public class Palindrome {
    public static bool IsPalindrome(int x) {
        var digits = x.ToString();

        // var length = Math.Ceiling((decimal)(digits.Length / 2));
        for (int i = 0; i < digits.Length/2 ; i++)
        {
            if (digits[i] != digits[^(i+1)])
                return false;
        }

        return true;
    }
}
