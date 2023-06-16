using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.Tree.Easy;

public class Invert_Binary_Tree {
    
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root is null) return null;
        
        //Naive solution: recursive-based and potentially has issues with thread-stack size
        // void Invert(TreeNode node)
        // {
        //     if (node is not null)
        //     {
        //         (node.left, node.right) = (node.right, node.left);
        //         Invert(node.left);
        //         Invert(node.right);
        //     }
        // }
        //
        // Invert(root);

        var nodesStack = new Stack<TreeNode>();
        nodesStack.Push(root);

        while (nodesStack.Count > 0)
        {
            var node = nodesStack.Pop();
            (node.left, node.right) = (node.right, node.left);
            if (node.left is not null) 
                nodesStack.Push(node.left);
            if (node.right is not null) 
                nodesStack.Push(node.right);
        }

        return root;
    }
    
}