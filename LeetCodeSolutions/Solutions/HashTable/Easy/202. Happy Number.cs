namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Happy_Number {
    
    public static bool IsHappy(int n)
    {
        var appearedNumbers = new HashSet<long>();

        while (true)
        {
            var next = 0;
            while (n > 0)
            {
                var digit = n % 10;
                next += digit * digit;
                n /= 10;
            }

            if (appearedNumbers.Add(next) is false)
                return false;

            if (next == 1)
                return true;

            n = next;
        }
    }
}