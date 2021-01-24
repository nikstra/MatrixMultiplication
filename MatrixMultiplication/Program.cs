using BenchmarkDotNet.Running;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
