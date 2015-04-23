using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class BSTTests
    {
        [TestMethod]
        public void PutTest()
        {
            BST<int> bst = new BST<int>();
            bst.Put(10);
            bst.Put(20);
            bst.Put(30);
            bst.Put(40);

            List<int> inorder = bst.InorderRecursive();
        }
    }
}
