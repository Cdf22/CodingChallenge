using System;
using CodingChallenge.CardGame.enums;

namespace CodingChallenge.CardGame
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; }

        Value Value { get; }
    }
}
