module statisticsPS.Tests

open NUnit.Framework
open DescriptiveFunctions

//[<SetUp>]
//let Setup () =
//    ()

[<TestFixture>]
type TestClass () =
    [<Test>]
    member this.TestGetAbsoluteMode () =
        //-- Arrange
        let table = [ "Mercedes"; "BMW"; "Ford"; "Mercedes"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"; "Mercedes"]

        //-- Act
        let actual = getModeFromTable table

        //-- Assert
        let expected = [("Mercedes", 5); ("BMW", 3); ("Ford", 2)]
        Assert.AreEqual(actual, expected)

    [<Test>]
    member this.TestGetRelativeMode () =
        //-- Arrange
        let table = [ "Mercedes"; "Mercedes"; "BMW"; "Ford"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"; "Mercedes"]

        //-- Act
        let actual = getRelativeModeFromTable table

        //-- Assert
        let expected = [("Mercedes", 50.0); ("BMW", 30.0); ("Ford", 20.0)]
        Assert.AreEqual(actual, expected)