namespace LeetCodeSolutions.Tests.Tree.Easy;

public class Invert_Binary_Tree_Test
{

    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(TreeNode root, TreeNode result)
    {
        var invertedBst = Invert_Binary_Tree.InvertTree(root);

        var a = TreeNode.TraverseInOrder(invertedBst).ToList();
        var b = TreeNode.TraverseInOrder(result).ToList();
        Assert.That(a, Is.EqualTo(b));
    }


    private static object[] _testCaseSource =
    [
        new object[]
        {
            new TreeNode(0)
            {
                left = new TreeNode(-10)
                {
                    right = new TreeNode(-3)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(9)
                },
            },
            new TreeNode(0)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(9)
                },
                right = new TreeNode(-10)
                {
                    left = new TreeNode(-3)
                },
            },
        }
    ];
    
}