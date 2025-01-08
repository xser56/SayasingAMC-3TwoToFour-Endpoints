using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAMC_3TwoToFour_Endpoints.Services
{
    public class GreaterThenOrLessThenservices
    {
        public string GreaterOrLess(int num1, int num2)
        {
            string results;

            if (num1 > num2)
            {
                 results = "The first Number is greater then your second number! Your Second number is lower!" ;
            }
            else if (num1 < num2)
            {
                results = "The second number is greater then your first number! Your first number is lower!";
            }
            else
            {
                results = "Both the numbers are the same!";
            }
            return results;
        }
    }
}