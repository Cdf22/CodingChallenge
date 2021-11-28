using System.Collections.Generic;
using CodingChallenge.CardGame.Implementations;
using CodingChallenge.CardGame.interfaces;
using CodingChallenge.CardGame.enums;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class CardTests
    {

        [Test]
        public void CardsAreEqual_WithValidCardParameter_Success()
        {
            // Arrange
            var a = new Card(Suit.Spades, Value.Ace);
            var b = new Card(Suit.Clubs, Value.Ace);

            // Act and assert
            Assert.AreEqual(true, a.Equals(b));
        }

        [Test]
        public void CardsAreNotEqual_WithValidCardParameter_Success()
        {
            // Arrange
            var a = new Card(Suit.Spades, Value.Ace);
            var b = new Card(Suit.Spades, Value.Two);

            // Act and assert
            Assert.AreEqual(false, a.Equals(b));
        }

        [Test]
        public void CardAreNotEqual_WithInValidCardParameter_ShouldThrowArgumentNullException()
        {
            // Arrange
            var a = new Card(Suit.Spades, Value.Ace);
            Card b = null;

            // Act and assert
            Assert.Throws<System.ArgumentNullException>(() => a.Equals(b));
        }
    }
}
