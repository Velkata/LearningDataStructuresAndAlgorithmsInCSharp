﻿using System.Collections.Generic;
using System.Text;
using Learning.DataStructures;
using Learning.InterviewQuestions.Trees;
using NUnit.Framework;

namespace Learning.InterviewQuestionsTests.Trees
{
    [TestFixture]
    public class BasicTreeQuestionsTests
    {
        private readonly BasicTreeQuestions _tree;

        public BasicTreeQuestionsTests()
        {
            _tree = new BasicTreeQuestions();
        }

        [Test]
        public void IsSumTree()
        {
            _tree.root = new Node(26);
            _tree.root.left = new Node(10);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(6);
            _tree.root.right = new Node(3);
            _tree.root.right.right = new Node(3);

            Assert.IsTrue(_tree.IsSumTree(_tree.root));
        }

        [Test]
        public void IsSumTree2()
        {
            _tree.root = new Node(26);
            _tree.root.left = new Node(10);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(6);
            _tree.root.right = new Node(3);
            _tree.root.right.left = new Node(1);
            _tree.root.right.right = new Node(3);

            Assert.IsFalse(_tree.IsSumTree(_tree.root));
        }

        [Test]
        public void MaxDepth()
        {
            _tree.root = new Node(1);
            _tree.root.left = new Node(2);
            _tree.root.right = new Node(3);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(5);

            Assert.AreEqual(_tree.MaxDepth(_tree.root), 3);
        }

        [Test]
        public void AreMirror()
        {
            Node a = new Node(1);
            Node b = new Node(1);
            a.left = new Node(2);
            a.right = new Node(3);
            a.left.left = new Node(4);
            a.left.right = new Node(5);

            b.left = new Node(3);
            b.right = new Node(2);
            b.right.left = new Node(5);
            b.right.right = new Node(4);

            Assert.IsTrue(_tree.AreMirror(a, b));
        }

        [Test]
        public void Serialize()
        {
            _tree.root = new Node(26);
            _tree.root.left = new Node(10);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(6);
            _tree.root.right = new Node(3);
            _tree.root.right.right = new Node(3);

            StringBuilder sb = new StringBuilder();
            _tree.Serialize(_tree.root, sb);

            string result = sb.ToString();
            Assert.AreEqual(result, "26 10 4 # # 6 # # 3 # 3 # # ");
        }

        [Test]
        public void Deserialize()
        {
            string input = "26 10 4 # # 6 # # 3 # 3 # # ";
            Node root = _tree.Deserialize(input);

            Assert.AreEqual(root.data, 26);
            Assert.AreEqual(root.left.data, 10);
            Assert.AreEqual(root.left.left.data, 4);
            Assert.AreEqual(root.left.right.data, 6);
            Assert.AreEqual(root.right.data, 3);
            Assert.AreEqual(root.right.right.data, 3);
        }

        [Test]
        public void GetDiff()
        {
            _tree.root = new Node(5);
            _tree.root.left = new Node(2);
            _tree.root.right = new Node(3);
            Assert.AreEqual(_tree.GetLevelDiff(_tree.root), 0);
        }

        [Test]
        public void PrintLevelOrderDictionary()
        {
            _tree.root = new Node(1);
            _tree.root.left = new Node(2);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(6);
            _tree.root.right = new Node(3);
            _tree.root.right.right = new Node(3);

            _tree.PrintLevelOrder(_tree.root);

            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level1"][0], 1);
            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level2"][0], 2);
            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level2"][1], 3);
            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level3"][0], 4);
            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level3"][1], 6);
            Assert.AreEqual(_tree.PrintLevelOrderDictionary["level3"][2], 3);
        }

        [Test]
        public void IsRootToLeafPathSumEqualToGivenNumber()
        {
            _tree.root = new Node(10);
            _tree.root.left = new Node(8);
            _tree.root.right = new Node(2);
            _tree.root.left.left = new Node(3);
            _tree.root.left.right = new Node(5);
            _tree.root.right.left = new Node(2);

            Assert.IsTrue(_tree.IsRootToLeafPathSumEqualToGivenNumber(_tree.root, 21));
        }

        [Test]
        public void IsRootToLeafPathSumEqualToGivenNumber2()
        {
            _tree.root = new Node(10);
            _tree.root.left = new Node(8);
            _tree.root.right = new Node(2);
            _tree.root.left.left = new Node(3);
            _tree.root.left.right = new Node(5);
            _tree.root.right.left = new Node(2);

            Assert.IsFalse(_tree.IsRootToLeafPathSumEqualToGivenNumber(_tree.root, 22));
        }

        [Test]
        public void SortedArrayToBalancedBst()
        {
            var array = new int[] {1,2,3,4,5,6,7};
            _tree.root=_tree.SortedArrayToBalancedBst(array, 0, array.Length-1);

            Assert.AreEqual(_tree.root.data, 4);
            Assert.AreEqual(_tree.root.left.data, 2);
            Assert.AreEqual(_tree.root.left.left.data, 1);
            Assert.AreEqual(_tree.root.left.right.data, 3);
            Assert.AreEqual(_tree.root.right.data, 6);
            Assert.AreEqual(_tree.root.right.left.data, 5);
            Assert.AreEqual(_tree.root.right.right.data, 7);
        }

        [Test]
        public void DiameterOn2()
        {
            _tree.root = new Node(1);
            _tree.root.left = new Node(2);
            _tree.root.right = new Node(3);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(5);

            var res = _tree.DiameterOn2(_tree.root);

            Assert.AreEqual(res, 4);
        }

        [Test]
        public void Diameter()
        {
            _tree.root = new Node(1);
            _tree.root.left = new Node(2);
            _tree.root.right = new Node(3);
            _tree.root.left.left = new Node(4);
            _tree.root.left.right = new Node(5);

            var h = new Height();
            var res = _tree.Diameter(_tree.root, h);

            Assert.AreEqual(res, 4);
        }

        [Test]
        public void ToSumTree()
        {
            _tree.root = new Node(10);
            _tree.root.left = new Node(-2);
            _tree.root.right = new Node(6);
            _tree.root.left.left = new Node(8);
            _tree.root.left.right = new Node(-4);
            _tree.root.right.left = new Node(7);
            _tree.root.right.right = new Node(5);
            
            _tree.ToSumTree(_tree.root);

            Assert.AreEqual(_tree.root.data, 20);
            Assert.AreEqual(_tree.root.left.data, 4);
            Assert.AreEqual(_tree.root.right.data, 12);
            Assert.AreEqual(_tree.root.left.left.data, 0);
            Assert.AreEqual(_tree.root.left.right.data, 0);
        }

        [Test]
        public void LevelOrderTraversalInSpiralForm()
        {
            _tree.root = new Node(1);
            _tree.root.left = new Node(2);
            _tree.root.right = new Node(3);
            _tree.root.left.left = new Node(7);
            _tree.root.left.right = new Node(6);
            _tree.root.right.left = new Node(5);
            _tree.root.right.right = new Node(4);
            var list = new List<int>();

            _tree.LevelOrderTraversalInSpiralForm(_tree.root, list);

            Assert.AreEqual(list[0], 1);
            Assert.AreEqual(list[1], 2);
            Assert.AreEqual(list[2], 3);
            Assert.AreEqual(list[3], 4);
            Assert.AreEqual(list[4], 5);
            Assert.AreEqual(list[5], 6);
            Assert.AreEqual(list[6], 7);
        }

        [Test]
        public void PrintExtremeNodes()
        {
            // Binary Tree of Height 4
            Node node = new Node(1);

            node.left = new Node(2);
            node.right = new Node(3);

            node.left.left = new Node(4);
            node.left.right = new Node(5);
            node.right.right = new Node(7);

            node.left.left.left = new Node(8);
            node.left.left.right = new Node(9);
            node.left.right.left = new Node(10);
            node.left.right.right = new Node(11);
            node.right.right.left = new Node(14);
            node.right.right.right = new Node(15);

            node.left.left.left.left = new Node(16);
            node.left.left.left.right = new Node(17);
            node.right.right.right.right = new Node(31);

            var list = new List<int>();

            _tree.PrintExtremeNodes(node, list);

            Assert.AreEqual(list[0], 1);
            Assert.AreEqual(list[1], 2);
            Assert.AreEqual(list[2], 7);
            Assert.AreEqual(list[3], 8);
            Assert.AreEqual(list[4], 31);
        }

        [Test]
        public void MaxDiff()
        {
            _tree.root = new Node(8);
            _tree.root.left = new Node(3);
            _tree.root.left.left = new Node(1);
            _tree.root.left.right = new Node(6);
            _tree.root.left.right.left = new Node(4);
            _tree.root.left.right.right = new Node(7);
            _tree.root.right = new Node(10);
            _tree.root.right.right = new Node(14);
            _tree.root.right.right.left = new Node(13);

            Assert.AreEqual(_tree.MaxDiff(_tree.root), 7);
        }

        [Test]
        public void ModifyBst()
        {
            var root = new Node(50);
            root.left = new Node(30);
            root.left.left = new Node(20);
            root.left.right = new Node(40);
            root.right = new Node(70);
            root.right.left = new Node(60);
            root.right.right = new Node(80);

            _tree.ModifyBst(root);

            Assert.AreEqual(root.data, 260);
            Assert.AreEqual(root.left.data, 330);
            Assert.AreEqual(root.left.left.data, 350);
            Assert.AreEqual(root.left.right.data, 300);
            Assert.AreEqual(root.right.data, 150);
        }

        [Test]
        public void IsBst()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            Assert.IsTrue(_tree.IsBst(tree.root));
        }

        [Test]
        public void NotBst()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(5);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            Assert.IsFalse(_tree.IsBst(tree.root));
        }

        public void IsBstRecursion()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            Assert.IsTrue(_tree.IsBstRecursion(tree.root, int.MinValue, int.MaxValue));
        }

    }
}
