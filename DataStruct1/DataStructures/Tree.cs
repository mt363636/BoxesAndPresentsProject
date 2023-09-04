using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1.DataStructures
{
    public class Tree<K, T> where K : IComparable<K> where T : Box
        // private and public representations of addnode, findnode, removenode,findexpirednodes, getminkey and findsuitableboxforgift methods
    {
        public TreeNode<K, T> Root { get; private set; }

        public void AddNode(K key, T value)
        {
            if (Root == null)
            {
                Root = new TreeNode<K, T>(key, value);
            }
            else
            {
                AddNode(key, Root, value);
            }
        }

        public TreeNode<K, T> FindNode(K key)
        {
            return FindNode(key, Root);
        }

        public void RemoveNode(K key)
        {
            Root = RemoveNode(key, Root);
        }

        public TreeNode<K, T> FindSuitableBoxForGift(double giftBaseSize, double giftHeight)
        {
            return FindSuitableBoxForGift(giftBaseSize, giftHeight, Root);
        }

        public List<TreeNode<K, T>> FindExpiredNodes(List<Box> existingInventory)
        {
            List<TreeNode<K, T>> expiredNodes = new List<TreeNode<K, T>>();
            FindExpiredNodes(Root, existingInventory, expiredNodes);
            return expiredNodes;
        }



        private void AddNode(K key, TreeNode<K, T> node, T value)
        {
            if (key.CompareTo(node.Key) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<K, T>(key, value);
                    return;
                }

                AddNode(key, node.Left, value);
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode<K, T>(key, value);
                    return;
                }

                AddNode(key, node.Right, value);
            }
        }

        private TreeNode<K, T> FindNode(K key, TreeNode<K, T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (key.CompareTo(node.Key) == 0)
            {
                return node;
            }
            else if (key.CompareTo(node.Key) < 0)
            {
                return FindNode(key, node.Left);
            }
            else
            {
                return FindNode(key, node.Right);
            }
        }

        private TreeNode<K, T> RemoveNode(K key, TreeNode<K, T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (key.CompareTo(node.Key) < 0)
            {
                node.Left = RemoveNode(key, node.Left);
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                node.Right = RemoveNode(key, node.Right);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                node.Key = GetMinKey(node.Right);
                node.Right = RemoveNode(node.Key, node.Right);
            }

            return node;
        }

        private K GetMinKey(TreeNode<K, T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Key;
        }



        private TreeNode<K, T> FindSuitableBoxForGift(double giftBaseSize, double giftHeight, TreeNode<K, T> node)
        {
            if (node == null)
            {
                return null;
            }

            double nodeKey = Convert.ToDouble(node.Key);
            int compareBaseSize = nodeKey.CompareTo(giftBaseSize);

            if (node.Value is Box box && compareBaseSize == 0 && box.Height >= giftHeight)
            {
                // Found a suitable box
                return node;
            }
            else if (compareBaseSize > 0)
            {
                return FindSuitableBoxForGift(giftBaseSize, giftHeight, node.Left);
            }
            else
            {
                return FindSuitableBoxForGift(giftBaseSize, giftHeight, node.Right);
            }
        }

        private void FindExpiredNodes(TreeNode<K, T> node, List<Box> existingInventory, List<TreeNode<K, T>> expiredNodes)
        {
            if (node == null)
            {
                return;
            }

            FindExpiredNodes(node.Left, existingInventory, expiredNodes);

            if (existingInventory.Any(b => b.Equals(node.Value)) && IsExpired(node.Value))
            {
                expiredNodes.Add(node);
            }

            FindExpiredNodes(node.Right, existingInventory, expiredNodes);
        }






        public bool IsExpired(Box box)
        {
            DateTime currentTime = DateTime.Now;
            return box.ExpiryDate <= currentTime;
        }






    }
}
