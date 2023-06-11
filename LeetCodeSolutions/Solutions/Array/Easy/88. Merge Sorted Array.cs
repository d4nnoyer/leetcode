namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Merge_Sorted_Array {
    
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int rIndex1 = m - 1;
        int rIndex2 = n - 1;
        int currPos = m + n - 1;
        
        while (rIndex1 >= 0 && rIndex2 >= 0) {
            
            nums1[currPos--] = nums1[rIndex1] > nums2[rIndex2] 
                ? nums1[rIndex1--] 
                : nums2[rIndex2--];
        }

        while (rIndex2 >= 0) {
            nums1[currPos--] = nums2[rIndex2--];
        }
    }
    
}