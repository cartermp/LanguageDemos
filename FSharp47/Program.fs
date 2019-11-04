// Learn more about F# at http://fsharp.org

open System
open SpanDemo
open BenchmarkDotNet.Running

[<EntryPoint>]
let main _ =
    let summary = BenchmarkRunner.Run<ParsingBenchmark>()
    printfn "%A" summary
    
    0 // return an integer exit code
