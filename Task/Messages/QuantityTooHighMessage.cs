﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Messages
{
    public class QuantityTooHighMessage : Exception
    {
        public QuantityTooHighMessage(string message) : base(message)
        {

        }
    }
}
