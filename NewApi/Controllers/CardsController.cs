using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewApi.Controllers
{
    [Produces("application/json")]
    [Route("api/cards")]
    public class CardsController : Controller
    {
        private ICardsService _cardsService;

        public CardsController(ICardsService cardService)
        {
            _cardsService = cardService;
        }

        [HttpGet("")]
        public IEnumerable<Card> GetAll()
        {
            return _cardsService.FetchCards();
        }




        

    }
}

