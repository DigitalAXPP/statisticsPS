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
        table