// consumingCollections

let rec fold_left = 
              List.fold_left
                    (fun state a -> state + 1 ) 0
                    [ for i in 0 .. 9 -> true]
// val it : int = 1 

List.reduce_left
  (fun accum a -> accum + a) 
   [0..9]


List.map(fun x -> x * x)[1..10]
// val it : int list = [1; 4; 9; 16; 25; 36; 49; 64; 81; 100]

List.iter
    (fun x -> printf "%A\n" x) [1..10]
// 12345678910val it : unit = () 

Array.fold_left 
    (fun state a -> state + 1) 0 
    [| for i in 0..9 -> true|] 
// val it : int = 1 

Array.reduce_left
    (fun accum a -> accum + a)
    [|0..9|]

Array.map
    (fun x -> x * x) [|1..10|]
// val it : int [] = [|1; 4; 9; 16; 25; 36; 49; 64; 81; 100|]

Array.iter
    (fun x -> printf "%d" x) 
    [|1..10|]
// 12345678910val it : unit = ()

let arr = [|for i in 0..3|]
arr.[2..4]

let arr = [| for i 0..3 -> i|]
arr.[2..4]

let arr = [| for i 0..3 -> i|]
arr.[..4]

Seq.reduce
    (fun accum a -> accum + a) 
    (seq{ for i in 0..9 do 
        yield i})
// val it : int = 45
