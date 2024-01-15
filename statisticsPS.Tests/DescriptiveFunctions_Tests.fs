module statisticsPS.Tests

open NUnit.Framework
open DescriptiveFunctions

//[<SetUp>]
//let Setup () =
//    ()

[<TestFixture>]
type TestClass () =
    [<Test>]
    member this.TestGetMode () =
        //-- Arrange
        let table = [ "Mercedes"; "BMW"; "Ford"; "Mercedes"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"]

        //-- Act
        let actual = getModeFromTable table

        //-- Assert
        let expected = [("Mercedes", 4); ("BMW", 3); ("Ford", 2)]
        Assert.AreEqual(actual, expected)