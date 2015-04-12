// short list rec
let rec sum list =
   match list with
   | head :: tail -> head + sum tail
   | [] -> 0

// Big list rec (with acc)
let sum' list =
   let rec loop list acc =
       match list with
       | head :: tail -> loop tail (acc + head)
       | [] -> acc
   loop list 0
printfn "%A" (sum' [1..1100000])