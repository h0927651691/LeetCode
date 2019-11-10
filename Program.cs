using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace leetcode {
    class Program {
        static void Main (string[] args) {
            Tree BST = new Tree ();
            BST.Insert (1);
            BST.Insert (5);
            BST.Insert (2);
            BST.Insert (7);
            BST.Insert (3);
            BST.Insert (8);
            BST.Insert (10);
            Solution mySolution = new Solution();
            mySolution.InorderTraversal(BST.ReturnRoot());
        }
    }
    public class Solution {
        private List<int> res = new List<int> ();
        public IList<int> InorderTraversal (TreeNode root) {
            InorderDFS (root);
            // string dogCsv = string.Join (",", res.ToArray ());
            // Console.WriteLine (dogCsv);
            return res;
        }
        private void InorderDFS (TreeNode root) {
            if (root == null) {
                // Console.WriteLine ("Call Return");
                return;
            }
            InorderTraversal (root.left);
            res.Add (root.val);
            InorderTraversal (root.right);
        }
    }
}