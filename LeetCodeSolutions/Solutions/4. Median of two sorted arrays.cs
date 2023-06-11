namespace LeetCodeSolutions.Solutions;

public class Median_of_two_sorted_arrays {
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
        {
            return GetSortedArrayMedian(nums2);
        }
        if (nums2.Length == 0)
        {
            return GetSortedArrayMedian(nums1);
        }
        
        var commonLength = nums1.Length + nums2.Length;
        bool isEven = commonLength % 2 == 0;
        var indexToReach = isEven ? commonLength / 2 - 1 :  commonLength / 2 ;

        int nums1Index = 0;
        int nums2Index = 0;
        int mergedIndex = 0;
        int currentValue = 0;

        while (mergedIndex - 1 != indexToReach)
        {
            if (nums2Index >= nums2.Length)
            {
                currentValue = nums1[nums1Index];
                nums1Index++;
            }
            else if (nums1Index >= nums1.Length)
            {
                currentValue = nums2[nums2Index];
                nums2Index++;
            }
            else if (nums1[nums1Index] < nums2[nums2Index])
            {
                currentValue = nums1[nums1Index];
                nums1Index++;
            }
            else
            {
                currentValue = nums2[nums2Index];
                nums2Index++;
            }
            
            mergedIndex++;
        }

        if (isEven)
        {
            int leftValue = currentValue;
            currentValue = nums1Index == nums1.Length 
                ? nums2[nums2Index]
                : nums2Index == nums2.Length 
                    ?  nums1[nums1Index]
                    : nums1[nums1Index] < nums2[nums2Index] 
                        ? nums1[nums1Index] 
                        : nums2[nums2Index];

            return (double) (leftValue + currentValue) / 2;
        }
        else
        {
            return currentValue;
        }
    }

    private double GetSortedArrayMedian(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr[0];
        }
        
        if (arr.Length == 2)
        {
            return (double) (arr[0] + arr[1]) / 2;
        }
        
        bool isEven = arr.Length % 2 == 0;
        var indexToReach = isEven ?  arr.Length / 2 - 1 : arr.Length / 2 ;

        if (isEven)
        {
            return (double) (arr[indexToReach] + arr[indexToReach+1]) / 2;
        }
        else
        {
            return arr[indexToReach];
        }
    }
}