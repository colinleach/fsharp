module DartsTests

open FsUnit.Xunit
open Xunit

open Darts

[<Fact>]
let ``Missed target`` () =
    score -9.0 9.0 |> should equal 0

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``On the outer circle`` () =
    score 0.0 10.0 |> should equal 1

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``On the middle circle`` () =
    score -5.0 0.0 |> should equal 5

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``On the inner circle`` () =
    score 0.0 -1.0 |> should equal 10

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Exactly on center`` () =
    score 0.0 0.0 |> should equal 10

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Near the center`` () =
    score -0.1 -0.1 |> should equal 10

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just within the inner circle`` () =
    score 0.7 0.7 |> should equal 10

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just outside the inner circle`` () =
    score 0.8 -0.8 |> should equal 5

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just within the middle circle`` () =
    score -3.5 3.5 |> should equal 5

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just outside the middle circle`` () =
    score -3.6 -3.6 |> should equal 1

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just within the outer circle`` () =
    score -7.0 7.0 |> should equal 1

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Just outside the outer circle`` () =
    score 7.1 -7.1 |> should equal 0

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Asymmetric position between the inner and middle circles`` () =
    score 0.5 -4.0 |> should equal 5

