using System;
using CodingChallenge.CardGame.enums;
using CodingChallenge.CardGame.interfaces;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }


        public Suit Suit { get;}

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            if(other == null)
            {
                throw new ArgumentNullException();
            }
            return Value == other.Value;
        }
    }
}
