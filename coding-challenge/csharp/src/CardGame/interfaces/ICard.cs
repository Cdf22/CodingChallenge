using System;
using CodingChallenge.CardGame.enums;

namespace CodingChallenge.CardGame.interfaces
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; }

        Value Value { get; }
    }
}
