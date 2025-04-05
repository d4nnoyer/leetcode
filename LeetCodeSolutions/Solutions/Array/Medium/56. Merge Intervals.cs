namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Merge_Intervals {
    
    public static int[][] Merge(int[][] intervals) 
    {
        System.Array.Sort(intervals, (a, b) => a[0] - b[0]);
        var merged = new LinkedList<int[]>();
        foreach (var interval in intervals) {
            if (merged.Count == 0 || interval[0] > merged.Last!.Value[1])
                merged.AddLast(interval);
            else
                merged.Last!.Value[1] = Math.Max(merged.Last.Value[1], interval[1]);
        }

        return merged.ToArray();
    }
}