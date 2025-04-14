namespace LeetCodeSolutions.Solutions.Mathematics.Easy;

public class Count_Symmetric_Integers {
    
    public static int CountSymmetricIntegers(int low, int high)
    {
        var count = 0;
        for (var index = low; index <= high; index++)
            if (index < 100 && index % 11 == 0) 
            {
                count++;
                index += 8;
            } 
            else if (index is >= 1000 and < 10000) 
            {
                var left = index / 1000 + (index % 1000) / 100;
                var right = (index % 100) / 10 + index % 10;
                if (left == right) {
                    count++;
                    index += 8;
                }
            }
        return count;
    }
}