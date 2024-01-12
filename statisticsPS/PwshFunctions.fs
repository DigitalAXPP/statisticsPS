namespace statisticsPS

open DescriptiveFunctions
open System.Management.Automation

[<Cmdlet("Get", "ModeFromTable")>]
type GetModeFromTableCommand () =
    inherit PSCmdlet ()
    [<Parameter(
        Mandatory=true,
        ValueFromPipeline=true)>]
    [<ValidateNotNullOrEmpty>]
    member val Table : string = String.Empty with get, set

    override x.ProcessRecord () =
        x.WriteVerbose ($"The JWT you provided is: Test")
        base.ProcessRecord ()