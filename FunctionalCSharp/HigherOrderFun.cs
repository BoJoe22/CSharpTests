using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalCSharp
{
    public class HigherOrderFun
    {
        public static int sum(List<int> intList, Func<int, int> f)
        {
            if (intList.Count == 0)
                return 0;
            else return f(intList[0]) + sum(intList.GetRange(1, intList.Count - 1), f);
        }
    }
}
