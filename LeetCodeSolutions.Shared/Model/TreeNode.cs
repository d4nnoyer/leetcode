namespace LeetCodeSolutions.Shared.Model;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
    }

    public static IEnumerable<TreeNode> TraverseInOrder(TreeNode node)
    {
        if (node is not null)
        {
            foreach (var left in TraverseInOrder(node.left))
                yield return left;

            yield return node;
            
            foreach (var right in TraverseInOrder(node.right))
                yield return right;
        }
    }
}