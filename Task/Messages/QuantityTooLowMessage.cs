using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Messages
{
    public class QuantityTooLowMessage : Exception
    {
        public QuantityTooLowMessage(string message) : base(message)
        {

        }
    }
}
