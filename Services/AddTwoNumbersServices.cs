using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAMC_3TwoToFour_Endpoints.Services
{
    public class AddTwoNumbersServices
    {
        public string AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            string results = $"Your first number is: {num1} and your second number is: {num2} Your total sum is {sum}";
            return results; 
        }
    }
}