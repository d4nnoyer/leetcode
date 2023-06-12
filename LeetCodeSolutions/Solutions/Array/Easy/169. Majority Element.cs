namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Majority_Element {
    
    public static int MajorityElement(int[] nums)
    {
        // Solution 3: Boyer-Moore Majority Vote Algorithm (http://www.cs.utexas.edu/~moore/best-ideas/mjrty/)
        // Works only if it is exactly known that sequences contains value, presented more than n/2 times
        int major = nums[0];
        int count = 1;
        
        for(var i = 1; i < nums.Length; i++){
            if(count == 0)
            {
                count++;
                major = nums[i];
            }
            else if(major == nums[i])
                count++;
            else 
                count--;
            
        }
        
        return major;
        
        // Solution 2
        // System.Array.Sort(nums);
        // int len = nums.Length;
        // return nums[len/2];
        
        // Solution 1
        // if (nums.Length == 1)
        //     return nums.First();
        //
        // var dict = new Dictionary<int, int>();
        //
        // foreach (var value in nums)
        // {
        //     if (dict.TryGetValue(value, out _)){
        //         
        //         dict[value]++;
        //         if (dict[value] > nums.Length / 2)
        //         {
        //             return value;
        //         }
        //     }
        //     else
        //     {
        //         dict.Add(value, 1);
        //     }
        // }
        //
        // return 0;
    }
    
}