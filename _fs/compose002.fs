let add a b = a + b 
// add 4 5  

let add' a b c = a + b + c 
// add' (add 3 4) 5 6  

let add'' a b c d = a + b + c + d 
let add003piped = add 1 2 |> add' 3 4 |> add'' 5 6 7  

let add003compose  = add 2  >> add' 3 4  >> add'' 5 6 7 
add003compose 1 

(*
> 
val add : a:int -> b:int -> int
val add' : a:int -> b:int -> c:int -> int
val add'' : a:int -> b:int -> c:int -> d:int -> int
val add003piped : int = 28
val add003compose : (int -> int)
val it : int = 28
*)