module SpanDemo

open System
open BenchmarkDotNet.Attributes

type ReadOnlySpan<'T> with
    // Note the 'inline' in the member definition
    member sp.GetSlice(startIdx, endIdx) =
        let s = defaultArg startIdx 0
        let e = defaultArg endIdx sp.Length
        sp.Slice(s, e - s)

module Parsing =
    // String has a format of "123,456"
    let parseNums (str: string) =
        let commaIdx = str.IndexOf(',')

        let first = str.[.. commaIdx-1]
        let last = str.[str.Length - commaIdx ..]
        
        // Give back a tuple
        (Int32.Parse(first), Int32.Parse(last))

    let parseNumsSpan (str: string) =
        let sp = str.AsSpan()

        let commaIdx = sp.IndexOf(',')
        let first = sp.[.. commaIdx]
        let last = sp.[sp.Length - commaIdx ..]
        
        // Give back a tuple
        struct (Int32.Parse(first), Int32.Parse(last))

[<MemoryDiagnoser>]
type ParsingBenchmark() =
    let str = "123,456"
    let nums = List.init 100 (fun _ -> str)

    [<Benchmark(Baseline = true)>]
    member _.ParseString() =
        for str in nums do
            Parsing.parseNums str |> ignore

    [<Benchmark>]
    member _.ParseWithSpan() =
        for str in nums do
            Parsing.parseNumsSpan |> ignore