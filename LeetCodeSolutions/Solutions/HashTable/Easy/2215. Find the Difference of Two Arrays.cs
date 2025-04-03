namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public static class Find_the_Difference_of_Two_Arrays {
    
    public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var numsSet1 = new HashSet<int>(nums1);
        var numsSet2 = new HashSet<int>(nums2);
        
        var list1 = new List<int>(nums1.Length);
        foreach (var num in numsSet1)
            if (numsSet2.Contains(num) is false)
                list1.Add(num);
        
        var list2 = new List<int>(nums2.Length);
        foreach (var num in numsSet2)
            if (numsSet1.Contains(num) is false)
                list2.Add(num);

        list1.TrimExcess();
        list2.TrimExcess();
        return [list1, list2];
    }
}