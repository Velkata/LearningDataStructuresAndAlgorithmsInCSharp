﻿using System.Collections.Generic;
using Learning.InterviewQuestions.DynamicProgramming;
using NUnit.Framework;

namespace Learning.InterviewQuestionsTests.DynamicTests
{
    [TestFixture]
    public class BaseDynamicQuestionsTests
    {
        private readonly BaseDynamicQuestions _dynamic;

        public BaseDynamicQuestionsTests()
        {
            _dynamic = new BaseDynamicQuestions();
        }

        [Test]
        public void NumberOfPaths()
        {
            Assert.AreEqual(_dynamic.NumberOfPaths(4, 4), 20);
        }

        [Test]
        public void PrintUniqueMatrixRows()
        {
            var set = new HashSet<string>();
            int[,] mat = { 
                { 0, 1, 0, 0, 1 }, 
                { 1, 0, 1, 1, 0 }, 
                { 0, 1, 0, 0, 1 }, 
                { 1, 1, 1, 0, 0 }
            };
            _dynamic.PrintUniqueMatrixRows(mat, set);
            Assert.AreEqual(set.Count, 3);
        }

        [Test]
        public void PrintMatrixInSpiralForm()
        {
            int[,] a = { 
                {1,  2,  3,  4,  5,  6},
                {7,  8,  9,  10, 11, 12},
                {13, 14, 15, 16, 17, 18}
            };
            var list = new List<int>();
            _dynamic.PrintMatrixInSpiralForm(a, list);

            // 1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11
            Assert.AreEqual(list[0], 1);
            Assert.AreEqual(list[17], 11);
        }

        [Test]
        public void CelebrityProblem()
        {
            // Person with 2 is celebrity
            int[,] a = {
                    { 0, 0, 1, 0},
                    { 0, 0, 1, 0},
                    { 0, 0, 0, 0},
                    { 0, 0, 1, 0}
            };
            Assert.AreEqual(_dynamic.CelebrityProblem(4, a), 2);
        }

        [Test]
        public void PrintTour()
        {
            // Person with 2 is celebrity
            PetrolPump[] arr = new PetrolPump[3];
            arr[0] = new PetrolPump() { petrol = 6, distance = 4};
            arr[1] = new PetrolPump() { petrol = 3, distance = 6 };
            arr[2] = new PetrolPump() { petrol = 7, distance = 3 };
            Assert.AreEqual(_dynamic.PrintTour(arr, arr.Length), 2);
        }

        [Test]
        public void OptimalStrategyOfGame()
        {
            int[] arr1 = { 8, 15, 3, 7 };
            int n =arr1.Length;
            Assert.AreEqual(_dynamic.OptimalStrategyOfGame(arr1, n), 22);

            int[] arr2 = { 2, 2, 2, 2 };
            n = arr2.Length;
            Assert.AreEqual(_dynamic.OptimalStrategyOfGame(arr2, n), 4);

            int[] arr3 = { 20, 30, 2, 2, 2, 10 };
            n = arr3.Length;
            Assert.AreEqual(_dynamic.OptimalStrategyOfGame(arr3, n), 42);
        }

        [Test]
        public void FindMinInsertionsDp()
        {
            Assert.AreEqual(_dynamic.FindMinInsertionsDp("geeks", "geeks".Length), 3);
        }

        [Test]
        public void PrintMaxSubSquare()
        {
            int[,] mat =  {
                {0, 1, 1, 0, 1}, 
                {1, 1, 0, 1, 0}, 
                {0, 1, 1, 1, 0},
                {1, 1, 1, 1, 0},
                {1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0}
            };

            var result = new List<int>();
            _dynamic.PrintMaxSubSquare(mat, result);
            Assert.AreEqual(result.Count, 9);
        }

        [Test]
        public void MaxSubArraySum()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Assert.AreEqual(_dynamic.MaxSubArraySum(a), 7);
        }
    }
}
