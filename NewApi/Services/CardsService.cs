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
                new Card("Ultimate Shadow" , 90,80),
                //new Card() {Attack = 66, Defense = 55, Name = "Puppet of Doom" }

            };

        }

        public CardsService()
        {

        }
    }
}

