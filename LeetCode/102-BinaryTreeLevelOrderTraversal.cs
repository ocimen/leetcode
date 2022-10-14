// Problem: https://leetcode.com/problems/binary-tree-level-order-traversal/

namespace LeetCode {
    public partial class Solution {
        public IList<IList<int>> LevelOrder(TreeNode root) {
            var result = new Collection<IList<int>>();
            if(root == null) {
                return result;
            }
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            
            while(queue.Count > 0) {
                var levelSize = queue.Count();
                var sizeResult = new List<int>();
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    sizeResult.Add(node.val);
                    if(node.left != null)
                        queue.Enqueue(node.left);
                    if(node.right != null)
                        queue.Enqueue(node.right);
                }
                result.Add(sizeResult);
            }

            return result;
        }
    }
}