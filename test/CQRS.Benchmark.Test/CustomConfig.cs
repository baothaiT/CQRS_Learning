using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Exporters;


namespace CQRS.Benchmark.Test;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        AddJob(Job.Default
            .WithWarmupCount(3)    // Warm-up iterations
            .WithIterationCount(10) // Measurement iterations
        );

        //AddExporter(BenchmarkDotNet.Exporters.CsvExporter.Default);
        //AddExporter(BenchmarkDotNet.Exporters.HtmlExporter.Default);
    }
}
