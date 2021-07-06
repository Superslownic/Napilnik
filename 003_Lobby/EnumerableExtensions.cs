using System;
using System.Collections.Generic;
using System.Linq;

namespace NapilnikTask_Lobby
{
    public static class EnumerableExtensions
    {
        public static T Any<T>(this IEnumerable<T> enumerable)
        {
            Random random = new Random();
            return enumerable.ElementAt(random.Next(enumerable.Count()));
        }
    }
}
