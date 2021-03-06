﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListmk2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {  
        [TestMethod]
        public void Add()
        {
            MyList<int> list = new MyList<int>();
            int expected = 62;
            list.Add(13);
            list.Add(5);
            list.Add(22);
            list.Add(62);

            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void CountCheck()
        {
            MyList<int> list = new MyList<int>();
            int expected = 2;
            list.Add(13);
            list.Add(39);

            Assert.AreEqual(expected, list.Count);

        }
        [TestMethod]
        public void RemoveCheck()
        {
            MyList<int> list = new MyList<int>();
            int expected = 4;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(0);
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void CappedCheck()
        {
            MyList<int> list = new MyList<int>();
            int expected = 7;
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(expected, list[7]);
        }
        [TestMethod]
        public void ZipCheck()
        {
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            int expected = 6;
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(7);
            list1.Add(9);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            list1 = list1.Zip(list2);
            Assert.AreEqual(expected, list1[5]);
        }
    }
    
}
