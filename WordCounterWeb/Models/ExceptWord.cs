﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterWeb.Models
{
    class ExceptWord
    {
        private HashSet<string> _separatorsWords = new HashSet<string>()
        {
            "a", "the", "an", "in", "on", "of"
        };
    }
}
