// Descriminated Unions 
type Tree<'T> =
    | Node of Tree<'T> * 'T * Tree<'T>
    | Leaf

let rec depth = function
    | Node(l, _, r) -> 1 + depth l + depth r
    | Leaf -> 0

let optionPatternMatch input =
   match input with
    | Some i -> printfn "input is an int=%d" i
    | None -> printfn "input is missing"

type OrderId = Order of string

// Create a DU value
let orderId = Order "12"

// Pattern matching of single-case DU
let (Order id) = orderId 

let optionPatternMatch' input = 
    match input with 
    | Some i -> printfn "input is an int=%d" i 
    | None -> printfn "input is missing" 

  
//> 
(*   type Tree<'T> =
  | Node of Tree<'T> * 'T * Tree<'T>
  | Leaf
val depth : _arg1:Tree<'a> -> int
val optionPatternMatch : input:int option -> unit
type OrderId = | Order of string
val orderId : OrderId = Order "12"
val id : string = "12"
val optionPatternMatch' : input:int option -> unit
*)