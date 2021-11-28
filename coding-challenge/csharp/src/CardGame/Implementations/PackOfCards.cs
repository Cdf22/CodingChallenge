using System;
using System.Collections;
using System.Collections.Generic;
using CodingChallenge.CardGame.enums;
using CodingChallenge.CardGame.interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCards : IPackOfCards
    {
        List<Card> _cards = new List<Card>();
        public PackOfCards()
        {
            var i = 0;

            for(var suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (var value = Value.Ace; value <= Value.King; value++)
                {
                    _cards.Add(new Card(suit, value));
                }
            }

            Count = _cards.Count;
        }

        public int Count { get; private set; }

        public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
        public void Shuffle() => throw new NotImplementedException();
        public ICard TakeCardFromTopOfPack()
        {
            var cardsInDeck = _cards.Count;
            var card = _cards[cardsInDeck-1];
            _cards.RemoveAt(cardsInDeck-1);
            Count = _cards.Count;
            return card;
        }
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
