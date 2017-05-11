using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableImpl;

namespace HashTableTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashTableDoesNotContainKeyTest()
        {
            var ht = new HashTable();
            string key = "KEY";
            
            Assert.IsFalse(ht.Contains(key));
        }

        [TestMethod]
        public void HashTableContainsKeyTest()
        {
            var ht = new HashTable();
            string key = "KEY";
            string value = "value";

            ht.Add(key, value);
            
            Assert.IsTrue(ht.Contains(key));
        }

        [TestMethod]
        public void HashTableAddTest()
        {
            var ht = new HashTable();
            string key = "KEY";
            string value = "value";

            ht.Add(key, value);

            Assert.IsTrue((string) ht[key] == value);
        }

    }
}
