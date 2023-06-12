namespace LeetCodeSolutions.Tests.Array.Easy;

public class Convert_Sorted_Array_to_Binary_Search_Tree_Test {
    
    //TODO: overrride equality comparer for TreeNode
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, TreeNode treeResult)
    {
        var tree = Convert_Sorted_Array_to_Binary_Search_Tree.SortedArrayToBST(nums);

        Assert.That(tree, Is.EqualTo(treeResult));
    }


    private static object[] _testCaseSource = {
        new object[] {new[]{-10,-3,0,5,9}, new TreeNode(0)
        {
            left = new TreeNode(-10)
            {
                right = new TreeNode(-3)
            },
            right = new TreeNode(5)
            {
                right = new TreeNode(9)
            }
        }},
    };
    
}