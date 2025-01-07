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
    public class GreaterThenOrLessThenController : ControllerBase
    {
        private readonly GreaterThenOrLessThenservices _greaterThenOrLessThenServices;
        public GreaterThenOrLessThenController(GreaterThenOrLessThenservices greaterThenOrLessThenservices)
        {
            _greaterThenOrLessThenServices = greaterThenOrLessThenservices;
        }

        [HttpPost]
        [Route("Compare/{num1}/{num2}")]
        public string GreaterOrLess(int num1, int num2)
        {
            return _greaterThenOrLessThenServices.GreaterOrLess(num1, num2);
        }
    }
}
