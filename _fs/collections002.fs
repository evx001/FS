
let list1 = ["a";"b"]
let list2 = "c" :: list1 
let list3 = list1 @ list2 

(*
val list1 : string list = ["a"; "b"]
val list2 : string list = ["c"; "a"; "b"]
val list3 : string list = ["a"; "b"; "c"; "a"; "b"]
*)

let rec sum list = 
    match list with 
    | [] -> 0 
    | x :: xs -> x + sum xs 

// val sum : list:int list -> int 

