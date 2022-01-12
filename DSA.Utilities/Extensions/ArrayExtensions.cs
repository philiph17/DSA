using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Utilities.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] Sort<T>(this T[] source)
        {
            Array.Sort(source);
            return source;
        }
    }
}
