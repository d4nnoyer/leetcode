namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public static class Max_Number_of_K_Sum_Pairs {
    
    public static int MaxOperations(int[] nums, int k)
    {
        var operationsCount = 0;
        var numbersCount = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            var pair = k - num;
            if (numbersCount.ContainsKey(pair) && numbersCount[pair] > 0) 
            {
                operationsCount++;
                numbersCount[pair]--;
            } 
            else
            {
                numbersCount.TryAdd(num, 0);
                numbersCount[num]++;
            }
        }

        return operationsCount;
    }
}