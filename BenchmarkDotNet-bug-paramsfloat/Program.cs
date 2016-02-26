using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNet_bug_paramsfloat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BugPoC>();
            Console.ReadLine();
        }
    }
}