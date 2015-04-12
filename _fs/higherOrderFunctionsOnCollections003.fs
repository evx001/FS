// higherOrderFunctionsOnCollections
let xs = [ 1..2..9 ]
// val xs : int list = [1; 3; 5; 7; 9]

let ys = [| for i in 0..4 -> 2 * i + 1 |]
// val ys : int [] = [|1; 3; 5; 7; 9|] 

let zs = List.init 5 (fun i -> 2 * i + 1)
// val zs : int list = [1; 3; 5; 7; 9] 

let xs' = Array.fold (fun str n -> 
            sprintf "%s,%i" str n) "" [| 0..9 |] 
// val xs' : string = ",0,1,2,3,4,5,6,7,8,9"

let last xs = List.reduce (fun acc x -> x) xs 
// val last : xs:'a list -> 'a 

let ys' = Array.map (fun x -> x * x) [| 0 .. 9|] 
// val ys' : int [] = [|0; 1; 4; 9; 16; 25; 36; 49; 64; 81|] 

List.iter (fun x -> printfn "%i" x) [ 0..9] 
(* 
0
1
2
3
4
5
6
7
8
9
val it : unit = ()
*) 
 
let zs' = 
    seq { 
            for i in 0..9 do 
                printfn "Adding %d" i 
                yield i
        }

// val zs' : seq<int> 
(*

> zs';;

Adding 0
Adding 1
Adding 2
Adding 3
Adding 4
val it : seq<int> = seq [0; 1; 2; 3; ...]

> 
*)


