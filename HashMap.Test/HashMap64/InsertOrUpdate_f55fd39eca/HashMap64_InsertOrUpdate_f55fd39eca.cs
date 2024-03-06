using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace HashMapNamespace.Test
{
    [TestFixture]
    public class HashMap64_InsertOrUpdate_f55fd39eca
    {
        private Dictionary<long, string> hashMap;

        [SetUp]
        public void Setup()
        {
            hashMap = new Dictionary<long, string>();
        }

        [Test]
        public void InsertOrUpdate_WhenCalled_WithNewKey_ShouldInsertValue()
        {
            long key = 1;
            string value = "Test";

            hashMap[key] = value;

            Assert.IsTrue(hashMap.ContainsKey(key));
            Assert.AreEqual(value, hashMap[key]);
        }

        [Test]
        public void InsertOrUpdate_WhenCalled_WithExistingKey_ShouldUpdateValue()
        {
            long key = 1;
            string value = "Test";
            string newValue = "Updated";

            hashMap[key] = value;
            hashMap[key] = newValue;

            Assert.IsTrue(hashMap.ContainsKey(key));
            Assert.AreEqual(newValue, hashMap[key]);
        }

        [Test]
        public void InsertOrUpdate_WhenCalled_WithNegativeKey_ShouldInsertValue()
        {
            long key = -1;
            string value = "Test";

            hashMap[key] = value;

            Assert.IsTrue(hashMap.ContainsKey(key));
            Assert.AreEqual(value, hashMap[key]);
        }

        [Test]
        public void InsertOrUpdate_WhenCalled_WithZeroKey_ShouldInsertValue()
        {
            long key = 0;
            string value = "Test";

            hashMap[key] = value;

            Assert.IsTrue(hashMap.ContainsKey(key));
            Assert.AreEqual(value, hashMap[key]);
        }

        [Test]
        public void InsertOrUpdate_WhenCalled_WithNullValue_ShouldInsertValue()
        {
            long key = 1;
            string value = null;

            hashMap[key] = value;

            Assert.IsTrue(hashMap.ContainsKey(key));
            Assert.AreEqual(value, hashMap[key]);
        }
    }
}
