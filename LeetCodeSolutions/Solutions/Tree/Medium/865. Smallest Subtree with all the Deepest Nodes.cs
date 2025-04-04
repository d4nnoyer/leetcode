using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.Tree.Medium;

public class Smallest_Subtree_with_all_the_Deepest_Nodes {
    public static TreeNode SubtreeWithAllDeepest(TreeNode root) {
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