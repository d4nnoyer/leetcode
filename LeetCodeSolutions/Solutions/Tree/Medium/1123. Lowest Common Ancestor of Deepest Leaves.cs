using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.Tree.Medium;

public class Lowest_Common_Ancestor_of_Deepest_Leaves {
    
    public static TreeNode LcaDeepestLeaves(TreeNode root)
    {
        return Dfs(root).node;
    }

    private static (TreeNode node, int depth) Dfs(TreeNode node)
    {
        if (node is null)
            return (null, 0);
        
        var left = Dfs(node.left);
        var right = Dfs(node.right);

        if (left.depth > right.depth)
            return (left.node, left.depth + 1);
        if (left.depth < right.depth)
            return (right.node, right.depth + 1);
        
        return (node, left.depth + 1);
    }
}