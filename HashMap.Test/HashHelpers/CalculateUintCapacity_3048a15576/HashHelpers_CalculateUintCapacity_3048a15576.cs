using NUnit.Framework;
using HashMapNamespace;

namespace HashMapNamespace.Test
{
    public class HashHelpers
    {
        public static uint CalculateUintCapacity(uint initCapacity, float loadFactor, out uint limitCapacity)
        {
            // Your implementation goes here
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class HashHelpers_CalculateUintCapacity_3048a15576
    {
        [Test]
        public void CalculateUintCapacity_WithValidInputs_ReturnsCorrectCapacity()
        {
            // Arrange
            uint initCapacity = 32;
            float loadFactor = 0.75f;
            uint limitCapacity;

            // Act
            uint result = HashHelpers.CalculateUintCapacity(initCapacity, loadFactor, out limitCapacity);

            // Assert
            Assert.AreEqual(43, result);
            Assert.AreEqual(32, limitCapacity);
        }

        [Test]
        public void CalculateUintCapacity_WithZeroInitCapacity_ReturnsMinimumCapacity()
        {
            // Arrange
            uint initCapacity = 0;
            float loadFactor = 0.75f;
            uint limitCapacity;

            // Act
            uint result = HashHelpers.CalculateUintCapacity(initCapacity, loadFactor, out limitCapacity);

            // Assert
            Assert.AreEqual(1, result);
            Assert.AreEqual(1, limitCapacity);
        }

        [Test]
        public void CalculateUintCapacity_WithMaximumInitCapacity_ReturnsMaximumCapacity()
        {
            // Arrange
            uint initCapacity = uint.MaxValue;
            float loadFactor = 0.75f;
            uint limitCapacity;

            // Act
            uint result = HashHelpers.CalculateUintCapacity(initCapacity, loadFactor, out limitCapacity);

            // Assert
            Assert.AreEqual(1941741533, result);
            Assert.AreEqual(1456306149, limitCapacity);
        }

        [Test]
        public void CalculateUintCapacity_WithNegativeLoadFactor_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            uint initCapacity = 32;
            float loadFactor = -0.75f;
            uint limitCapacity;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => HashHelpers.CalculateUintCapacity(initCapacity, loadFactor, out limitCapacity));
        }
    }
}
