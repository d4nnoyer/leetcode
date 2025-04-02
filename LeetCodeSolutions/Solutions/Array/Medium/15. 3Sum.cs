namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class ThreeSumClass {
    
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var sums = new List<IList<int>>();
        System.Array.Sort(nums);

        if (nums[0] > 0)
            return System.Array.Empty<IList<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                break;
            
            if(i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum > 0)
                    right--;
                else if (sum < 0)
                    left++;
                else
                {
                    sums.Add([nums[i], nums[left], nums[right]]);
                    int lastLow = nums[left];
                    int lastHigh = nums[right];
                    while (left < right && nums[left] == lastLow)
                        left++;
                    while (left < right && nums[right] == lastHigh)
                        right--;
                }
            }
        }
        sums.TrimExcess();
        return sums;
    }
}