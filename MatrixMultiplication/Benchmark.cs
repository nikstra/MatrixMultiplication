using BenchmarkDotNet.Attributes;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    public class Benchmark
    {
        private const int N = 500;
        private readonly int[,] matrix1 = MatrixFactory.Create(N);
        private readonly int[,] matrix2 = MatrixFactory.Create(N);
        private readonly ParalellCalculator _paralellCalculator;
        private readonly SequentialCalculator _sequentialCalculator;

        public Benchmark()
        {
            _paralellCalculator = new ParalellCalculator();
            _sequentialCalculator = new SequentialCalculator();
        }

        [Benchmark]
        public Task<int[,]> CalculateParalell() =>
            _paralellCalculator.MultiplyM(matrix1, matrix2);

        [Benchmark]
        public int[,] CalculateSequential() =>
            _sequentialCalculator.MultiplyM(matrix1, matrix2);
    }
}
