
namespace LeetCodeSolutions.Tests.Tree.Easy;

public class Minimum_Absolute_Difference_in_BST_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(TreeNode root, int result)
    {
        var minimalDistance = Minimum_Absolute_Difference_in_BST.GetMinimumDifference(root);

        Assert.That(minimalDistance, Is.EqualTo(result));
    }


    private static object[] _testCaseSource = {
        new object[] {new TreeNode(0)
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
            3
        },
        new object[] {new TreeNode(3)
            {
                right = new TreeNode(5)
            }, 
            2
        },
        new object[] {new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(48)
                {
                    left = new TreeNode(12),
                    right = new TreeNode(49)
                }
            }, 
            1
        },
    };
}