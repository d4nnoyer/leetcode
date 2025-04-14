namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Count_Good_Triplets {
    
    public static int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var n = arr.Length;
        var result = 0;
        
        for (int i = 0; i < n - 2; i++)
        for (int j = i + 1; j < n - 1; j++)
        for (int k = j + 1; k < n; k++)
            if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                result++;
        
        return result;
    }
}