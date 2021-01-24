using System;

namespace MatrixMultiplication
{
    public class SequentialCalculator
    {
        public int[,] MultiplyM(int[,] a, int[,] b)
        {
            if (a.GetLength(Const.Col) != b.GetLength(Const.Row))
            {
                throw new ArgumentException(
                    $"Matrix mismatch, {nameof(a)} must have the same number of columns as {nameof(b)} has rows.");
            }

            var productM = new int[a.GetLength(Const.Row), b.GetLength(Const.Col)];
            for (int row = 0; row < a.GetLength(Const.Row); row++)
            {
                for (int col = 0; col < b.GetLength(Const.Col); col++)
                {
                    int product = 0;
                    for (int colRow = 0; colRow < a.GetLength(Const.Col); colRow++)
                    {
                        product += a[row, colRow] * b[colRow, col];
                    }

                    productM[row, col] = product;
                }
            }

            return productM;
        }
    }
}
