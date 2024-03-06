using System;
using NUnit.Framework;

namespace HashMapNamespace.Test
{
    public class HashMap64
    {
        private int[] _buckets;

        public HashMap64(int capacity)
        {
            _buckets = new int[capacity];
        }

        public int GetBucket(long key)
        {
            return (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_buckets.Length);
        }

        public int Capacity
        {
            get { return _buckets.Length; }
        }
    }

    public class HashMap64_GetBucket_495cdd41af
    {
        private HashMap64 _hashMap;

        [SetUp]
        public void Setup()
        {
            _hashMap = new HashMap64(100);
        }

        [Test]
        public void GetBucket_PositiveKey_ReturnsCorrectBucket()
        {
            long key = 123456789;
            int expectedBucket = (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_hashMap.Capacity);

            int actualBucket = _hashMap.GetBucket(key);

            Assert.AreEqual(expectedBucket, actualBucket);
        }

        [Test]
        public void GetBucket_NegativeKey_ReturnsCorrectBucket()
        {
            long key = -123456789;
            int expectedBucket = (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_hashMap.Capacity);

            int actualBucket = _hashMap.GetBucket(key);

            Assert.AreEqual(expectedBucket, actualBucket);
        }

        [Test]
        public void GetBucket_ZeroKey_ReturnsCorrectBucket()
        {
            long key = 0;
            int expectedBucket = (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_hashMap.Capacity);

            int actualBucket = _hashMap.GetBucket(key);

            Assert.AreEqual(expectedBucket, actualBucket);
        }

        [Test]
        public void GetBucket_MaxLongKey_ReturnsCorrectBucket()
        {
            long key = long.MaxValue;
            int expectedBucket = (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_hashMap.Capacity);

            int actualBucket = _hashMap.GetBucket(key);

            Assert.AreEqual(expectedBucket, actualBucket);
        }

        [Test]
        public void GetBucket_MinLongKey_ReturnsCorrectBucket()
        {
            long key = long.MinValue;
            int expectedBucket = (int)(((uint)key ^ (uint)(key >> 32)) % (uint)_hashMap.Capacity);

            int actualBucket = _hashMap.GetBucket(key);

            Assert.AreEqual(expectedBucket, actualBucket);
        }
    }
}
