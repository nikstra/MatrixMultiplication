using System;

namespace MatrixMultiplication
{
    public static class Extensions
    {
        public static void Print(this int[,] @this)
        {
            for (int i = 0; i < @this.GetLength(Const.Row); i++)
            {
                for (int j = 0; j < @this.GetLength(Const.Col); j++)
                {
                    Console.Write((j == 0 ? string.Empty : " ") + @this[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
