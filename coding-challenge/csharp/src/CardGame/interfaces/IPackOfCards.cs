using System.Collections.Generic;

namespace CodingChallenge.CardGame.interfaces
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        void Shuffle();

        ICard TakeCardFromTopOfPack();
    }
}
