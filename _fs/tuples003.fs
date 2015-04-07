// Tuples 
let x = (1, "String")
let v = ("one","two","three")

let c1 = fst (1, 2)
let d1 = snd (1, 2)
let (a',b') = x 

let print1 tuple =
match tuple with
| (a, b) -> printfn "Pair %A %A" a b
