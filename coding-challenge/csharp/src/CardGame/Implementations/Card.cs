using System;
using CodingChallenge.CardGame.enums;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Suit Suit => throw new NotImplementedException();

        public Value Value => throw new NotImplementedException();

        public bool Equals(ICard other) => throw new NotImplementedException();
    }
}
