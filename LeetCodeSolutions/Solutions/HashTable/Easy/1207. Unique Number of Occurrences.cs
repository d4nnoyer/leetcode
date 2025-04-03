namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public static class Unique_Number_of_Occurrences {
    
    public static bool UniqueOccurrences(int[] arr)
    {
        Span<int> occurenceCount = stackalloc int[1000 * 2 + 1];
        Span<int> occurenceCountCount = stackalloc int[1001];

        foreach (var num in arr)
            occurenceCount[num + 1000]++;
        
        foreach (var count in occurenceCount)
            if (count != 0 && occurenceCountCount[count]++ > 0)
                return false;

        return true;
    }
}