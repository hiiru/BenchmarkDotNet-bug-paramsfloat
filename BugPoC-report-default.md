BenchmarkDotNet=v0.9.1.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-2600K CPU @ 3.40GHz, ProcessorCount=8
Frequency=3320341 ticks, Resolution=301.1739 ns
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE [AttachedDebugger]

Type=BugPoC  Mode=Throughput  Platform=X64  
Jit=RyuJit  LaunchCount=1  WarmupCount=1  
TargetCount=1  

       Method |    Median |    StdDev |   Bugged |
------------- |---------- |---------- |--------- |
 ReturnParam2 | 4.4836 ns | 0.0000 ns |        0 |
  ReturnParam | 4.7085 ns | 0.0000 ns |        0 |
 ReturnParam2 |        NA |        NA |      0.2 |
  ReturnParam |        NA |        NA |      0.2 |
 ReturnParam2 |        NA |        NA | 0.546532 |
  ReturnParam |        NA |        NA | 0.546532 |
 ReturnParam2 |        NA |        NA |      0.8 |
  ReturnParam |        NA |        NA |      0.8 |

Benchmarks with troubles:
  BugPoC_ReturnParam2_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.2
  BugPoC_ReturnParam2_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.546532
  BugPoC_ReturnParam2_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.8
  BugPoC_ReturnParam_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.2
  BugPoC_ReturnParam_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.546532
  BugPoC_ReturnParam_X64_Jit-RyuJit_Warmup1_Target1_Process1_Bugged-0.8
