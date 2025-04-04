using LeetCodeSolutions.Solutions.Tree.Medium;

namespace LeetCodeSolutions.Tests.Tree.Medium;

public class Lowest_Common_Ancestor_of_Deepest_Leaves_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(TreeNode root, TreeNode result)
    {
        var lca = Lowest_Common_Ancestor_of_Deepest_Leaves.LcaDeepestLeaves(root);

        Assert.That(lca.val, Is.EqualTo(result.val));
        Assert.That(lca.left?.val, Is.EqualTo(result.left?.val));
        Assert.That(lca.right?.val, Is.EqualTo(result.right?.val));
    }
    
    private static object[] _testCaseSource =
    [
        new object[]
        {
            new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                },
            },
            new TreeNode(2)
            {
                left = new TreeNode(7),
                right = new TreeNode(4)
            },
        },
        new object[]
        {
            new TreeNode(0)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(2)
                },
                right = new TreeNode(3)
            },
            new TreeNode(2)
        }
    ];
}