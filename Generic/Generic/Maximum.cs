using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Maximum
    {
        public int FirstInt, SecondInt, ThirdInt;
        public double FirstFloat, SecondFloat, ThirdFloat;

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
        public double MaxFloat(double FirstFloat, double SecondFloat, double ThirdFloat)
        {
            if (FirstFloat.CompareTo(SecondFloat) > 0 && FirstFloat.CompareTo(ThirdFloat) > 0)
            {
                return FirstFloat;
            }

            if (SecondFloat.CompareTo(FirstFloat) > 0 && SecondFloat.CompareTo(ThirdFloat) > 0)
            {
                return SecondFloat;
            }

            if (ThirdFloat.CompareTo(FirstFloat) > 0 && ThirdFloat.CompareTo(SecondFloat) > 0)
            {
                return ThirdFloat;
            }
            return FirstFloat;
        }
        public string MaxString(string FirstString, string SecondString, string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0)
            {
                return FirstString;
            }

            if (SecondString.CompareTo(FirstString) > 0 && SecondString.CompareTo(ThirdString) > 0)
            {
                return SecondString;
            }

            if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) > 0)
            {
                return ThirdString;
            }
            return FirstString;
        }
    }
}
