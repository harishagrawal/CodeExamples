using NUnit.Framework;

namespace HashMapNamespace.Test
{
    public class HashHelpers
    {
        public static int CalculateCapacity(int capacity, float loadFactor, out int limitCapacity)
        {
            // Here you should implement the logic of calculating the capacity and limit capacity
            // This is just an example and will not compile
            limitCapacity = (int)(capacity * loadFactor);
            return capacity;
        }
    }

    [TestFixture]
    public class HashHelpers_CalculateCapacity_bb934c0f00
    {
        [Test]
        public void CalculateCapacity_WhenCalledWithValidParameters_ReturnsExpectedCapacityAndLimit()
        {
            // Arrange
            int initCapacity = 10;
            float loadFactor = 0.75f;
            int expectedCapacity = 14; // TODO: Replace with expected capacity
            int expectedLimitCapacity = 11; // TODO: Replace with expected limit capacity

            // Act
            int limitCapacity;
            int actualCapacity = HashHelpers.CalculateCapacity(initCapacity, loadFactor, out limitCapacity);

            // Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
            Assert.AreEqual(expectedLimitCapacity, limitCapacity);
        }

        [Test]
        public void CalculateCapacity_WhenCalledWithZeroInitialCapacity_ReturnsCorrectCapacityAndLimit()
        {
            // Arrange
            int initCapacity = 0;
            float loadFactor = 0.75f;
            int expectedCapacity = 1; // TODO: Replace with expected capacity
            int expectedLimitCapacity = 1; // TODO: Replace with expected limit capacity

            // Act
            int limitCapacity;
            int actualCapacity = HashHelpers.CalculateCapacity(initCapacity, loadFactor, out limitCapacity);

            // Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
            Assert.AreEqual(expectedLimitCapacity, limitCapacity);
        }

        [Test]
        public void CalculateCapacity_WhenCalledWithNegativeInitialCapacity_ThrowsArgumentException()
        {
            // Arrange
            int initCapacity = -1;
            float loadFactor = 0.75f;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => HashHelpers.CalculateCapacity(initCapacity, loadFactor, out _));
        }
    }
}
