using System;

namespace MatrixMultiplication
{
    public class MatrixFactory
    {
        public static int[,] Create(int size)
        {
            var random = new Random();
            int maxFactor = (int)Math.Sqrt(int.MaxValue / size);

            var m = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    m[i, j] = random.Next(maxFactor);
                }
            }

            return m;
        }
    }
}
