``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.737 (1809/October2018Update/Redstone5)
Intel Core i5-7400 CPU 3.00GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100-rc1-014190
  [Host]     : .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT


```
|                      Method | Condition |       Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------- |-----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|              **TestParameters** |     **False** | **307.496 ns** | **3.9617 ns** | **3.7058 ns** | **1.000** | **0.0200** |     **-** |     **-** |      **64 B** |
|    TestParametersLazyLambda |     False |   1.264 ns | 0.0147 ns | 0.0122 ns | 0.004 |      - |     - |     - |         - |
| TestParametersLazyLocalFunc |     False |   6.891 ns | 0.0422 ns | 0.0395 ns | 0.022 | 0.0204 |     - |     - |      64 B |
|                             |           |            |           |           |       |        |       |       |           |
|              **TestParameters** |      **True** | **306.528 ns** | **2.1895 ns** | **1.9409 ns** |  **1.00** | **0.0200** |     **-** |     **-** |      **64 B** |
|    TestParametersLazyLambda |      True | 303.598 ns | 1.7089 ns | 1.5986 ns |  0.99 | 0.0200 |     - |     - |      64 B |
| TestParametersLazyLocalFunc |      True | 310.748 ns | 0.4714 ns | 0.3937 ns |  1.01 | 0.0405 |     - |     - |     128 B |
