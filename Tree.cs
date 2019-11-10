using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

namespace leetcode {
    public class Tree {
        public TreeNode root;
        public Tree () {
            root = null;
        }
        public void Insert (int val) {
            TreeNode newNode = new TreeNode (val);
            newNode.val = val;
            if (root == null) //如果跟是空，則新加入的點為根  
                root = newNode;
            else {
                TreeNode current = root; //如果根不為空，則當前的點設成根  
                TreeNode parent; //宣告父節點  
                while (true) {
                    parent = current; //設定父節點為根  
                    if (val < current.val) //如果當前值小於父節點  
                    {
                        current = current.left; //把當前節點歸為左子樹  
                        if (current == null) //如果左子樹為空  
                        {
                            parent.left = newNode; //新增一個節點  
                            return;
                        }
                    } else {
                        current = current.right; //如果當前值大於父節點，將其歸右子樹  
                        if (current == null) //如果右子樹為空  
                        {
                            parent.right = newNode; // 新增一個節點  
                            return;
                        }
                    }
                }
            }
        }
        public TreeNode ReturnRoot()  
        {  
            return root;  
        }  
    }
}