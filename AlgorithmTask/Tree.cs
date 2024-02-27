namespace AlgorithmTask;

/// <summary>
/// Class that provides traversing a tree and collecting leaf nodes.
/// </summary>
public class Tree
{
    /// <summary>
    /// Retrieves all the leaf nodes.
    /// </summary>
    /// <param name="root">Root node of the tree</param>
    /// <returns>Collection of leaf nodes - <see cref="IEnumerable{T}"/> of type <see cref="TreeNode"/></returns>
    public IEnumerable<TreeNode> GetLeafs(TreeNode root)
    {
        List<TreeNode> leafNodes = new List<TreeNode>();
        Traverse(root, leafNodes);
        return leafNodes;
    }


    #region Private methods

    /// <summary>
    /// Recursively traverses the tree and collects leaf nodes.
    /// </summary>
    /// <param name="node">Current node, that will be traversed</param>
    /// <param name="leafNodes">List that collects leaf nodes.</param>
    private void Traverse(TreeNode node, List<TreeNode> leafNodes)
    {
        if (node.Children.Count() == 0)
        {
            leafNodes.Add(node); // Add the current node to the list of leaf nodes
            return;
        }

        // If the current node has children,
        // traverse each child node recursively
        foreach (var child in node.Children)
        {
            Traverse(child, leafNodes); 
        }
    }

    #endregion
}


