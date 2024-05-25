using BenchmarkDotNet.Attributes;

namespace Benchmarker
{
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark]
        public string GetFullName()
        {
            string output = "";
            for (int i = 0; i < 1000; i++)
            {
                 output += i;
            }

            return output;
        }
    }
}
