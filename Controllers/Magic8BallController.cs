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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;

        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("Magic8Ball/{AskAQuestion}")]
        public string Magic8Ball(string AskAQuestion)
        {
            return _magic8BallServices.Magic8Ball(AskAQuestion);
        }
    }
}