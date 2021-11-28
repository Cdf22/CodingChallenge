using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.CardGame.interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            return new PackOfCards();
        }
    }
}
