﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Messages
{
    public class NotPositiveQuantityMessage : Exception
    {
        public NotPositiveQuantityMessage(string message) : base(message)
        {

        }
    }
}
