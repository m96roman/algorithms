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