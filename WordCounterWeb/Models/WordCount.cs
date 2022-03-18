﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterWeb.Models
{
    public class WordCount : IComparable<WordCount>
    {
        public string Word { get; set; }

        public int Count { get; set; }

        public double Percent { get; set; }

        public int CompareTo(WordCount other)
        {
            if (other == null)
            {
                return 1;
            }

            return other.Count.CompareTo(Count);
        }

        public override string ToString()
        {
            return string.Format("Word: {0}, Count: {1}, Percent: {2}%", 
                    Word, Count, string.Format("{0:N1}", Percent));          
        }

        public override int GetHashCode()
        {
            return Word[0] + Word.Length + Count;
        }

        public override bool Equals(object obj)
        {
            WordCount word = obj as WordCount;

            if (obj == null)
            {
                return false;
            }

            return obj.GetHashCode() == this.GetHashCode();

        }
    }
}
