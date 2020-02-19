using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Messages
{
    public class NotPositiveQuantityMessage : Exception
    {
        public string Message => "A positive quantity was not provided";
    }
}
