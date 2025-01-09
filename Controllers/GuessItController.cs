using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC_5EightToTen___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC_5EightToTen___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;
        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("guessEasy(1-10)")]
        public string GuessItEasy(int guessEasy)
        {
            return _guessItServices.GuessItEasy(guessEasy);
        }
        
        [HttpGet]
        [Route("guessMedium(1-50)")]
        public string GuessItMedium(int guessMedium)
        {
            return _guessItServices.GuessItMedium(guessMedium);
        }

        [HttpGet]
        [Route("guessHard(1-100)")]
        public string GuessItHard(int guessHard)
        {
            return _guessItServices.GuessItHard(guessHard);
        }
    }
}