# MatrixMultiplication
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1316 (1909/November2018Update/19H2)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|              Method |     Mean |   Error |   StdDev |
|-------------------- |---------:|--------:|---------:|
|   CalculateParalell | 350.0 ms | 8.68 ms | 24.19 ms |
| CalculateSequential | 851.5 ms | 2.73 ms |  2.13 ms |
