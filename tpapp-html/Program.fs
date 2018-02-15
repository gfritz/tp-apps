open System
open FSharp.Data
open Tplib2

printfn "NuGet Version History Count using tplib2 is %i" <| Tplib2.NugetName.getVersionHistoryCount()

type NugetStats = HtmlProvider<"https://www.nuget.org/packages/FSharp.Data">

let rawStats = NugetStats().Tables.``Version History``

let takeAmount = 5
printfn "Taking %i" takeAmount
rawStats.Rows |> Seq.take takeAmount |> Seq.iter (printfn "row = %A")