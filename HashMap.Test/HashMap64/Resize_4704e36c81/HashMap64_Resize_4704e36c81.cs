using System;
using NUnit.Framework;

namespace HashMapNamespace.Test
{
    public class HashMap64
    {
        private int size;

        public HashMap64(int initialSize)
        {
            size = initialSize;
        }

        public int Size
        {
            get { return size; }
        }

        public void Resize()
        {
            if (size > int.MaxValue / 2)
            {
                throw new OverflowException();
            }

            size *= 2;
        }
    }

    [TestFixture]
    public class HashMap64_Resize_4704e36c81
    {
        private HashMap64 hashMap;
        private int initialSize = 10;

        [SetUp]
        public void Setup()
        {
            hashMap = new HashMap64(initialSize);
        }

        [Test]
        public void Resize_WhenCalled_ShouldDoubleTheSize()
        {
            // Arrange
            int expectedSize = initialSize * 2;

            // Act
            hashMap.Resize();

            // Assert
            Assert.AreEqual(expectedSize, hashMap.Size);
        }

        [Test]
        public void Resize_WhenCalledTwice_ShouldQuadrupleTheSize()
        {
            // Arrange
            int expectedSize = initialSize * 4;

            // Act
            hashMap.Resize();
            hashMap.Resize();

            // Assert
            Assert.AreEqual(expectedSize, hashMap.Size);
        }

        [Test]
        public void Resize_WhenSizeIsMaxInt_ShouldThrowOverflowException()
        {
            // Arrange
            hashMap = new HashMap64(int.MaxValue / 2 + 1);

            // Act & Assert
            Assert.Throws<OverflowException>(() => hashMap.Resize());
        }
    }
}
