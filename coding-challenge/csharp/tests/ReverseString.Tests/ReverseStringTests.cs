using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReverseStringTests
    {
        [Test]
        public void ReverseString_WithValidStringParameter_ReturnsReversedString()
        {
            // Arrange
            var inputString = "Hello";

            // Act
            string reversedInput = StringUtilities.Reverse(inputString);

            // Assert
            Assert.AreEqual("olleH", reversedInput);
        }

        [Test]
        public void ReverseString_WithInvalidParameter_ShouldThrowArgumentNullException()
        {
            // Arrange
            string inputString = null;

            // Act and assert
            Assert.Throws<System.ArgumentNullException>(() => StringUtilities.Reverse(inputString));
        }

        [Test]
        public void ReverseString_WithInvalidParameter_ShouldThrowArgumentException()
        {
            // Arrange
            var inputString = "  ";

            // Act and assert
            Assert.Throws<System.ArgumentException>(() => StringUtilities.Reverse(inputString));
        }
    }
}
