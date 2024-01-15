//namespace statisticsPS
module DescriptiveFunctions
    open FSharp.Stats

//module Say =
    let getDistributions =
        Distributions.Continuous.Normal.Init 25. 0.1


    let getModeFromTable table =
        table
        |> List.countBy id
        |> List.sortByDescending (fun (id, count) -> count)