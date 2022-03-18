﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterWeb.Models
{
    public interface IWordIndexer
    {
        string this[int index] { get; }

        int Count { get; }
    }
}
