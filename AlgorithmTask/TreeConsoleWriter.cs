using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTask;

/// <summary>
/// Class which defines <see cref="PrintTree(AlgorithmTask.TreeNode, string)"/> 
/// method to print all nodes and leafs.
/// </summary>
public class TreeConsoleWriter
{
    /// <summary>
    /// Prints the tree structure starting from the specified node recursively.
    /// </summary>
    /// <param name="node">The root node of the tree to be printed</param>
    /// <param name="indent">Optional. The indentation string to visually represent the tree structure. Default is an empty string.</param>
    public static void PrintTree(TreeNode node, string indent = "")
    {
        if (node == null) return;

        Console.WriteLine(indent + "- " + node.Payload);
        
        // Increase indentation for children nodes
        indent += "  ";

        foreach (var child in node.Children)
        {
            PrintTree(child, indent);
        }
    }
}
