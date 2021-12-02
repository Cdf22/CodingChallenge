using System;
using System.Collections;
using System.Collections.Generic;
using CodingChallenge.CardGame.enums;
using CodingChallenge.CardGame.interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCards : IPackOfCards
    {
        private List<Card> _deck = new();

        public PackOfCards() => ResetDeck();

        public int Count { get; private set; }

        public IEnumerator<ICard> GetEnumerator() => _deck.GetEnumerator();

        public void Shuffle()
        {
            const int SHUFFLE_AMOUNT_MIN = 10;
            const int SHUFFLE_AMOUNT_MAX = 15;
            const int GRAB_CARD_AMOUNT_MIN = 2;
            const int GRAB_CARD_AMOUNT_MAX = 6;
            const int MIN_DECK_POSITION = 0;
            const int MAX_DECK_POSITION = 51;

            ResetDeck();

            /* Decided to shuffle based on the standard amateur card player  
             * Think this is more expensive to do with lists, but simpler to read
             * than if using arrays */
            var rnd = new Random();
            var shuffleAmount = rnd.Next(SHUFFLE_AMOUNT_MIN, SHUFFLE_AMOUNT_MAX);

            for(var i = 0; i < shuffleAmount; i++)
            {
                var grabCardAmount = rnd.Next(GRAB_CARD_AMOUNT_MIN, GRAB_CARD_AMOUNT_MAX);
                var grabCardPosition = rnd.Next(MIN_DECK_POSITION, MAX_DECK_POSITION - grabCardAmount);

                List<Card> slicedCards = _deck.GetRange(grabCardPosition, grabCardAmount);
                _deck.RemoveRange(grabCardPosition, grabCardAmount);
                _deck.AddRange(slicedCards);
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var cardsInDeck = _deck.Count;
            Card card = _deck[cardsInDeck-1];
            _deck.RemoveAt(cardsInDeck-1);
            Count = _deck.Count;
            return card;
        }

        IEnumerator IEnumerable.GetEnumerator() => _deck.GetEnumerator();

        private void ResetDeck()
        {
            /* I know that the spec said "Return all removed cards to the pack"
             * but i thought storing removed cards, that as yet are not used 
             * would be wasteful in terms of resources. So decided to use a fresh deck.
             */
            _deck.Clear();

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (Value value = Value.Ace; value <= Value.King; value++)
                {
                    _deck.Add(new Card(suit, value));
                }
            }

            Count = _deck.Count;
        }
    }
}
