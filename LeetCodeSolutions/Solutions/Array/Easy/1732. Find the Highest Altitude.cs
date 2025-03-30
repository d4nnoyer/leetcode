namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Find_the_Highest_Altitude {
    
    public static int LargestAltitude(int[] gain)
    {
        var largestAttitude = 0;
        var currentAttitude = 0;
        foreach (var t in gain)
        {
            currentAttitude += t;
            if (currentAttitude > largestAttitude)
                largestAttitude = currentAttitude;
        }
        
        return largestAttitude;
    }
}