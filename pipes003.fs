// Pipes003 

let sumOfLengths 
    (xs : string []) = 
        xs
        |> Array.map (fun s -> s.Length)
        |> Array.sum
printfn "%A" (sumOfLengths [""])




