using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1.DataStructures
{
    public class TreeNode<K, T>
    {
        public T Value { get; }
        public K Key { get; set; }
        public TreeNode<K, T> Left { get; set; }
        public TreeNode<K, T> Right { get; set; }


        public TreeNode(K key, T value)
        {
            Value = value;
            Key = key;
        }


    }
}
