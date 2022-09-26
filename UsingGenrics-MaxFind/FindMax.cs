using System;
using System.Collections.Generic;
using System.Text;

namespace UsingGenrics_MaxFind
{
   public class FindMax
    {
        public double findMaxDoubleValue(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}