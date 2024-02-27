namespace AlgorithmTask;

/// <summary>
/// Basic record type for tree.
/// </summary>
/// <param name="payload"></param>
/// <param name="Children"></param>
public record TreeNode(string Payload, IEnumerable<TreeNode> Children)
{
}
