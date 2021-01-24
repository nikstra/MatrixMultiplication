using System;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    public class ParalellCalculator
    {
        private readonly object Lock = new Object();

        public async Task<int[,]> MultiplyM(int[,] a, int[,] b)
        {
            if (a.GetLength(Const.Col) != b.GetLength(Const.Row))
            {
                throw new ArgumentException(
                    $"Matrix mismatch, {nameof(a)} must have the same number of columns as {nameof(b)} has rows.");
            }

            var productM = new int[a.GetLength(Const.Row), b.GetLength(Const.Col)];

            await Task.WhenAll(Enumerable.Range(0, a.GetLength(Const.Row)).Select(i =>
                Task.Run(() => MultiplyPart(i))));

            return productM;

            void MultiplyPart(int row)
            {
                for (int col = 0; col < b.GetLength(Const.Col); col++)
                {
                    int product = 0;
                    for (int colRow = 0; colRow < a.GetLength(Const.Col); colRow++)
                    {
                        product += a[row, colRow] * b[colRow, col];
                    }

                    lock (Lock)
                    {
                        productM[row, col] = product;
                    }
                }
            };
        }
    }
}
