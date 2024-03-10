//namespace statisticsPS
module DescriptiveFunctions
    open FSharp.Stats
    open System
    
//module Say =
    let getDistributions =
        Distributions.Continuous.Normal.Init 25. 0.1


    let getAbsoluteDistributionFromTable table =
        table
        |> List.countBy id
        |> List.sortByDescending (fun (id, count) -> count)

    let getRelativeDistributionFromTable table =
        let length = table |> List.length
        let (floatLength : float) = length
        table 
        |> List.groupBy id
        |> List.map (fun (key, item) -> (key, System.Math.Round(((float)item.Length/floatLength)*100.00, 2, MidpointRounding.ToEven)))
        |> List.sortByDescending (fun (_, item) -> item)
        
    let getModeFromTable table =
        table
        |> List.countBy id
        |> List.head

    let getMedianFromTable table =
        let length = table |> List.length
        let sortedTable = table |> List.sort
        match length % 2 with
        | 0 -> (float sortedTable.[(length /2)-1] + float sortedTable.[(length /2)]) / 2.0
        | _ -> float sortedTable.[length /2]

    let getMeanFromTable (table : int list) =
        let sum = table |> List.sum
        let length = table |> List.length
        System.Math.Round (float sum / float length, 2, MidpointRounding.ToEven)