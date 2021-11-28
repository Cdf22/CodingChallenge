using System.Collections.Generic;
using CodingChallenge.CardGame.Implementations;
using CodingChallenge.CardGame.interfaces;
using CodingChallenge.CardGame.enums;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class CardGameTests
    {
        [Test]
        public void CreatePackOfCards_ReturnsPackOfCardsObject()
        {
            // Arrange
            var pack = new PackOfCardsCreator();

            // Act
            IPackOfCards p = pack.Create();

            // Assert
            Assert.AreEqual(52, p.Count);
        }

        [Test]
        public void TakeCardFromTopOfPack_ReturnsCard_CardCountInPackIsDecreasedByOne()
        {
            // Arrange
            var packCreator = new PackOfCardsCreator();
            IPackOfCards pack = packCreator.Create();

            // Act
            ICard card = pack.TakeCardFromTopOfPack();

            // Assert
            Assert.IsNotNull(card);
            Assert.IsInstanceOf<Card>(card);
            Assert.AreEqual(51, pack.Count);
        }

        [Test]
        public void ShuffleCards_CardCountInPackIsReturnedTo52()
        {
            // Arrange
            var packCreator = new PackOfCardsCreator();
            IPackOfCards pack = packCreator.Create();
            pack.TakeCardFromTopOfPack();
            pack.TakeCardFromTopOfPack();

            // Act
            pack.Shuffle();

            // Assert
            Assert.AreEqual(52, pack.Count);
        }

        [Test]
        public void GetEnumerator_ReturnsIEnumerator<ICard>()
        {
            // Arrange
            var packCreator = new PackOfCardsCreator();
            IPackOfCards pack = packCreator.Create();

            // Act and assert
            Assert.IsInstanceOf<ICard>(pack.GetEnumerator());
        }
    }
}
