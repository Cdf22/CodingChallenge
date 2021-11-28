using System;
using System.Collections;
using System.Collections.Generic;
using CodingChallenge.CardGame.interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCards : IPackOfCards
    {
        public int Count => throw new NotImplementedException();

        public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
        public void Shuffle() => throw new NotImplementedException();
        public ICard TakeCardFromTopOfPack() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
