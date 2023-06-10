namespace Playground.Solutions.Array.Easy;

public class Convert_Sorted_Array_to_Binary_Search_Tree {
    
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return nums.Length == 1
            ? new TreeNode(nums[0])
            : GetLeafs(nums, ..(nums.Length-1));
    }

    private static TreeNode GetLeafs(IReadOnlyList<int> nums, Range range) {
        if (range.Start.Value > range.End.Value)
            return null;
        
        var rangeMid = (range.Start.Value + range.End.Value) / 2;
        
        return new TreeNode(nums[rangeMid])
        {
            left = rangeMid == 0 ? null :  GetLeafs(nums, range.Start .. (rangeMid-1)),
            right = GetLeafs(nums, (rangeMid+1) .. range.End)
        };
    }

}

public class TreeNode {
         
    public int val;
    public TreeNode left;
    public TreeNode right;
         
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right; 
    }
}
