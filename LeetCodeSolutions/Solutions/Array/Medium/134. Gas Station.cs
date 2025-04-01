namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Gas_Station {
    
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var currentAmount = gas[0] - cost[0];
        var lowestAmount = currentAmount;
        var lowestIndex = 0;

        for (var index = 1; index < cost.Length; index++)
        {
            currentAmount += gas[index] - cost[index];
            if (currentAmount < lowestAmount)
            {
                lowestIndex = index;
                lowestAmount = currentAmount;
            }
        }

        return currentAmount < 0 
            ? -1 
            : (lowestIndex + 1) % cost.Length;
    }
}