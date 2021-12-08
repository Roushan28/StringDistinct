using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDistinct
{
    public static class StringExtensions
    {
        public static string DistinctFrom(this string one, string two)
        {
            return new string(one.Except(two).ToArray());
        }
    }
}
