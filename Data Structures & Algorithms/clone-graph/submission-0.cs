/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {


    public Node CloneGraph(Node node) {
        
        Dictionary<Node, Node> vis = new Dictionary<Node, Node>();
        if(node == null)
            return node;
        Node ans = dfs(node,vis);
        return ans;
    }

    Node dfs(Node node, Dictionary<Node,Node> vis)
    {
        if(vis.ContainsKey(node))
        {
            return vis[node];
        }
 
        Node newNode = new Node(node.val);
        vis.Add(node,newNode);
        foreach(Node n in node.neighbors)
        {
            if(!vis.ContainsKey(n))
            {
                Node newchild = dfs(n,vis);
                newNode.neighbors.Add(newchild);
            }
            else
            {
                newNode.neighbors.Add(vis[n]);
            }
        }
        return newNode;

    }
}
