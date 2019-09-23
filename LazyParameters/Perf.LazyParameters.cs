// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Toolchains.DotNetCli;
using BenchmarkDotNet.Running;

namespace Test.LazyParameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmark_LazyParameters>();
        }
    }

    [DisassemblyDiagnoser(printAsm: true, printSource: true, recursiveDepth: 2)]
    [MemoryDiagnoser]
    public class Benchmark_LazyParameters
    {
        public static DateTime Date = DateTime.Now;

        [Params(true, false)]
        public bool TraceOn { get; set; }

        [Benchmark(Baseline = true)]
        public string TestParameters()
        {
            return TestParametersSub(Date.ToString());
        }

        public string TestParametersSub(string date)
        {
             if (TraceOn)
            {
                return date;
            }
            else
            {
                return string.Empty;
            }
       }

        [Benchmark]
        public string TestParametersLazyLambda()
        {
            return TestParametersLambdaSub(() => Date.ToString());
        }

        public string TestParametersLambdaSub(Func<string> date)
        {
            if (TraceOn)
            {
                return date();
            }
            else
            {
                return string.Empty;
            }
        }

        [Benchmark]
        public string TestParametersLazyLocalFunc()
        {
            string LocalFunc()
            {
                return Date.ToString();
            }
            return TestParametersLazyLocalFuncSub(LocalFunc);
        }

        public string TestParametersLazyLocalFuncSub(Func<string> date)
        {
            if (TraceOn)
            {
                return date();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
