module AlgotesterSolutions1

open System

let Euro2012 () = 
    printf "%d" (Console.ReadLine().Trim().Split ' ' |> Array.map int |> Array.sum)

