using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAMC_3TwoToFour_Endpoints.Services
{
    public class WhoAreYouServices
    {
        public string WhoAreYou(string Name, string WakeUp)
        {
            string results = $"So your name is {Name}, and you wake up at {WakeUp} o'clock?";
            return results;
        }
    }
}

// What is your name
        // Ask time
        // print sentence string " your name is {Name} and you wake up at {Time}