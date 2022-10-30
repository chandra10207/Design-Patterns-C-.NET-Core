using System;
using System.Collections.Generic;
using Common;

namespace Api.Services
{
    public class CardsService : ICardsService
    {
        public IEnumerable<Card> FetchCards()
        {
            return new List<Card>()
            {
                //new Card() {Attack = 90, Defense = 80, Name = "Ultimate Shadow" },
                //new Card() {Attack = 66, Defense = 55, Name = "Puppet of Doom" }
            };

        }

        public CardsService()
        {

        }
    }
}

