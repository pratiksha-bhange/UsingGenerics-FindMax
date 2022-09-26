using System;
using System.Collections.Generic;
using System.Text;

namespace UsingGenrics_MaxFind
{
    public class FindMax
    {
        public T findMaxValue<T>(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0)
            {
                return firstValue;
            }
            else if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
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
