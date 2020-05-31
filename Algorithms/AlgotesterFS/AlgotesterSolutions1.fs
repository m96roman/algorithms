module AlgotesterSolutions1

open System

let Euro2012 () = 
    printf "%d" (Console.ReadLine().Trim().Split ' ' |> Array.map int |> Array.sum)

let TwoRoads () =
    let readLocationsCount () = 
        Console.ReadLine().Trim() |> int

    let readLocation () =
        let points = Console.ReadLine().Trim().Split ' ' |> Array.map int
        (points.[0], points.[1], points.[2], points.[3])

    let readLocations count = 
        let mutable ls = []
        for i in 1 .. count do
            ls <- readLocation()::ls
        ls

    let getDistance (x1, y1, x2, y2) = 
        (float (x2 - x1) ** 2.0 + float (y2 - y1) ** 2.0) ** 0.5
 
    let getTotaltDistance = 
        readLocationsCount >> readLocations >> List.map getDistance >> List.sum >> int

    let totalDistance = 
        getTotaltDistance()

    printf "%d" totalDistance

let HowMuchToPay () =
    let amounts = Console.ReadLine().Trim().Split ' ' |> Array.map int
    
    let result = 
        if Math.Abs(amounts.[0] - amounts.[1]) <= 1 then -1
        else (amounts |> Array.min) + 1

    printf "%d" result

let HotDaysofPenguins () =
    let dimensions = Console.ReadLine().Trim().Split ' ' |> Array.map int

    let canDrink (dim:int[]) = 
        dim.[0] <= dim.[1] && dim.[0] <= dim.[2] + dim.[3]

    let result = 
        if canDrink dimensions 
            then "Three times Sex on the Beach, please!"
            else "Forget about the cocktails, man!"

    printf "%s" result

let CatAndString () =
    let readStr () =
        Console.ReadLine().Trim()

    let rec solveInternal = function
        | (first::str, lastLetter, toInsert) when first = lastLetter -> solveInternal (str, first, toInsert + 1)
        | (first::str, _, toInsert) -> solveInternal(str, first, toInsert)
        | ([], _, toInsert) -> toInsert

    let solve str = 
        solveInternal (Seq.toList str, '|', 0)

    let result = readStr() |> solve

    printf "%d" result
