using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CQRS.Benchmark.Test;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("BenchmarkRunner");
        var summary = BenchmarkRunner.Run<ApiBenchmark>();
        Console.ReadLine();
    }
}