﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Maximum
    {
        public int FirstInt, SecondInt, ThirdInt;

        public int MaxInteger(int FirstInt, int SecondInt, int ThirdInt)
        {
            if (FirstInt.CompareTo(SecondInt) > 0 && FirstInt.CompareTo(ThirdInt) > 0)
            {
                return FirstInt;
            }

            if (SecondInt.CompareTo(FirstInt) > 0 && SecondInt.CompareTo(ThirdInt) > 0)
            {
                return SecondInt;
            }

            if (ThirdInt.CompareTo(FirstInt) > 0 && ThirdInt.CompareTo(SecondInt) > 0)
            {
                return ThirdInt; 
            }
            return FirstInt;
        }
    }
}