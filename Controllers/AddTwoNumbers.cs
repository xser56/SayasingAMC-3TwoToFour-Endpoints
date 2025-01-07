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
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpPost]
        [Route("Add/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersServices.AddNumbers(num1, num2);
        }
    } //End
}

