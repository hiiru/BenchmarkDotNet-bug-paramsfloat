using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace BenchmarkDotNet_bug_paramsfloat
{
    [Config(typeof(Config))]
    public class BugPoC
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                Add(Job.RyuJitX64.With(Mode.Throughput).WithLaunchCount(1).WithWarmupCount(1).WithTargetCount(1));
            }
        }

        [Params(0.2f, 0.8f, 0f, 0.546532f)]
        public float Bugged { get; set; }

        [Benchmark]
        public float ReturnParam()
        {
            return Bugged;
        }

        [Benchmark]
        public float ReturnParam2()
        {
            return Bugged;
        }
    }
}