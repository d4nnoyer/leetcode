namespace LeetCodeSolutions.Solutions.String.Easy;

public static class Reverse_Vowels_of_a_String {
    
    public static string ReverseVowels(string s)
    {
        if (s.Length == 1) return s;
        
        Span<char> result = new char[s.Length];
        s.AsSpan().CopyTo(result);

        var leftIndex = 0;
        var rightIndex = s.Length - 1;
        
        while (leftIndex <= rightIndex)
        {
            var leftIsChar = Vowels.Contains(result[leftIndex]);
            var rightIsChar = Vowels.Contains(result[rightIndex]);
            if (leftIsChar is false)
                leftIndex++;
            
            if (rightIsChar is false)
                rightIndex--;

            if (leftIsChar && rightIsChar)
            {
                var temp = s[leftIndex];
                result[leftIndex] = result[rightIndex];
                result[rightIndex] = temp;
                leftIndex++;  rightIndex--;
            }
        }
        
        return result.ToString();
    }

    private static HashSet<char> Vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
}