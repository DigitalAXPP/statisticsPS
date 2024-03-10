module statisticsPS.Tests

open NUnit.Framework
open DescriptiveFunctions

//[<SetUp>]
//let Setup () =
//    ()

[<TestFixture>]
type TestClass () =
    [<Test>]
    member this.TestGetAbsoluteDistribution () =
        //-- Arrange
        let table = [ "Mercedes"; "BMW"; "Ford"; "Mercedes"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"; "Mercedes"]

        //-- Act
        let actual = getAbsoluteDistributionFromTable table

        //-- Assert
        let expected = [("Mercedes", 5); ("BMW", 3); ("Ford", 2)]
        Assert.AreEqual(actual, expected)

    [<Test>]
    member this.TestGetRelativeDistribution () =
        //-- Arrange
        let table01 = [ "Mercedes"; "Mercedes"; "BMW"; "Ford"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"; "Mercedes"]
        let table02 = [1;2;3;4;3;2;1;4;3;2;2;1;1;1;4;3;5]

        //-- Act
        let actual01 = getRelativeDistributionFromTable table01
        let actual02 = getRelativeDistributionFromTable table02

        //-- Assert
        let expected01 = [("Mercedes", 50.0); ("BMW", 30.0); ("Ford", 20.0)]
        let expected02 = [(1, 29.41); (2, 23.53); (3, 23.53); (4, 17.65); (5, 5.88)]
        Assert.AreEqual(actual01, expected01)
        Assert.AreEqual(actual02, expected02)

    [<Test>]
    member this.TestGetMode () =
        //-- Arrange
        let table = [ "Mercedes"; "BMW"; "Ford"; "Mercedes"; "BMW" ; "BMW"; "Ford"; "Mercedes"; "Mercedes"; "Mercedes"]

        //-- Act
        let actual = getModeFromTable table

        //-- Assert
        let expected = ("Mercedes", 5)
        Assert.AreEqual(actual, expected)

    [<Test>]
    member this.TestGetMedian () =
        //-- Arrange
        let unevenList = [1;2;3;4;3;2;1;4;3;2;2;1;1;1;4;3;5]
        let evenList = [1;2;3;4;3;2;1;4;3;2;1;1;1;4;3;5]

        //-- Act
        let actualUneven = getMedianFromTable unevenList
        let actualEven = getMedianFromTable evenList

        //-- Assert
        let expectedUneven = 2.0
        let expectedEven = 2.5
        Assert.AreEqual(actualUneven, expectedUneven)
        Assert.AreEqual(actualEven, expectedEven)

    [<Test>]
    member this.TestGetMean () =
        //-- Arrange
        let table = [1;2;3;4;3;2;1;4;3;2;2;1;1;1;4;3;5]

        //-- Act
        let actual = getMeanFromTable table

        //-- Assert
        let expected = 2.47
        Assert.AreEqual(actual, expected)