namespace Tplib2

open System
open FSharp.Data

module NugetName =

    type NugetStats = HtmlProvider<"https://www.nuget.org/packages/FSharp.Data">

    let getVersionHistoryCount() =

        NugetStats().Tables.``Version History``.Rows.Length