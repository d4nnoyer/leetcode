using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.Tree.Easy;

public class Minimum_Absolute_Difference_in_BST {
    
    public static int GetMinimumDifference(TreeNode root)
    {
        int minimalDistance = int.MaxValue;
        int? prevValue = null;
            
        int TraverseInOrder(TreeNode node)
        {
            if (node is null) 
                return minimalDistance;

            TraverseInOrder(node.left);

            if (prevValue is not null)
            {
                var distance = Math.Abs((int)prevValue - node.val);
                minimalDistance = Math.Min(distance, minimalDistance);
            }
            prevValue = node.val;

            TraverseInOrder(node.right);

            return minimalDistance;
        }
        
        return TraverseInOrder(root);
    }
}