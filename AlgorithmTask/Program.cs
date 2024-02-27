using AlgorithmTask;

Console.WriteLine(".___        __                                  .___.__         \r\n|   | _____/  |_  ___________  _____   ____   __| _/|__|____    \r\n|   |/    \\   __\\/ __ \\_  __ \\/     \\_/ __ \\ / __ | |  \\__  \\   \r\n|   |   |  \\  | \\  ___/|  | \\/  Y Y  \\  ___// /_/ | |  |/ __ \\_ \r\n|___|___|  /__|  \\___  >__|  |__|_|  /\\___  >____ | |__(____  / \r\n         \\/          \\/            \\/     \\/     \\/         \\/  \r\n   _____  .__                       .__  __  .__                \r\n  /  _  \\ |  |    ____   ___________|__|/  |_|  |__   _____     \r\n /  /_\\  \\|  |   / ___\\ /  _ \\_  __ \\  \\   __\\  |  \\ /     \\    \r\n/    |    \\  |__/ /_/  >  <_> )  | \\/  ||  | |   Y  \\  Y Y  \\   \r\n\\____|__  /____/\\___  / \\____/|__|  |__||__| |___|  /__|_|  /   \r\n        \\/     /_____/                            \\/      \\/    \r\n___________              __                                     \r\n\\__    ___/____    _____|  | __                                 \r\n  |    |  \\__  \\  /  ___/  |/ /                                 \r\n  |    |   / __ \\_\\___ \\|    <                                  \r\n  |____|  (____  /____  >__|_ \\                                 \r\n               \\/     \\/     \\/                                 \n");

// Adding leaf nodes.
#region TreeCreation

TreeNode leaf1 = new TreeNode("Leaf 1 of node1", Enumerable.Empty<TreeNode>());
TreeNode leaf2 = new TreeNode("Leaf 2 of node1", Enumerable.Empty<TreeNode>());

TreeNode leaf3 = new TreeNode("Leaf 1 of leaf3ofNode1", Enumerable.Empty<TreeNode>());
TreeNode leaf4 = new TreeNode("Leaf 2 of leaf3ofNode1", Enumerable.Empty<TreeNode>());

TreeNode leaf5 = new TreeNode("Leaf 1 of node 2", Enumerable.Empty<TreeNode>());
TreeNode leaf6 = new TreeNode("Leaf 2 of node 2", Enumerable.Empty<TreeNode>());

TreeNode leaf3ofNode1 = new TreeNode("Node leaf 3 of node 1", new List<TreeNode> { leaf3, leaf4 });

TreeNode node1 = new TreeNode("node 1 of root", new List<TreeNode> { leaf1, leaf2, leaf3ofNode1 }) ;
TreeNode node2 = new TreeNode("node 2 of root", new List<TreeNode> { leaf5, leaf6 });
TreeNode leafNode3 = new TreeNode("node 3 of root, but leaf", Enumerable.Empty<TreeNode>() );

TreeNode root = new TreeNode("Root", new List<TreeNode> { node1, node2, leafNode3 });
#endregion


Console.WriteLine("Testing leaf nodes traversing process:\n");

Console.WriteLine("Printing all nodes and leafs: ");
TreeConsoleWriter.PrintTree(root);

// Create instance of Tree
Tree tree = new Tree();

// Calling the GetLeafs method on the instance of Tree
var leafNodes = tree.GetLeafs(root);

Console.WriteLine("\n Now printing only leaf nodes:");
foreach (var leaf in leafNodes)
{
    Console.WriteLine(" - " + leaf.Payload);
}