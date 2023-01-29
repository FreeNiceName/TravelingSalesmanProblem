using System;
using System.Collections.Generic;
using System.Text;

namespace TSP
{
    public static class Extensions
    {
        public static void Fill<T>(this T[,] array, T value)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (var i = 0; i < rows; ++i)
                for (var j = 0; j < columns; ++j)
                    array[i, j] = value;
        }
    }
}
