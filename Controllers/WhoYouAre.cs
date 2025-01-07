using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayasingAMC_3TwoToFour_Endpoints.Services;

namespace SayasingAMC_3TwoToFour_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhoYouAreController : ControllerBase
    {
        private readonly WhoAreYouServices _whoAreYouServices;

        public WhoYouAreController(WhoAreYouServices whoAreYouServices)
        {
            _whoAreYouServices = whoAreYouServices;
        }

        [HttpPost]
        [Route("Who/{Name}/{WakeUp}")]
        public string WhoAreYou(string Name, string WakeUp)
        {
            return _whoAreYouServices.WhoAreYou(Name, WakeUp);
        }
    }
}


