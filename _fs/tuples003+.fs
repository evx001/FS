// tuples003+ 
// Tuple construction
let x = (1, "Hello")
// val x : int * string = (1, "Hello")
// Triple
let y = ("one", "two", "three")
// val y : string * string * string = ("one", "two", "three")

// Tuple deconstruction / pattern
let (a',b') = x
// val b' : string = "Hello"
// val a' : int = 1

let c' = fst (1, 2)
let d' = snd (1, 2)
// val c' : int = 1
// val d' : int = 2

let print' tuple = 
    match tuple with 
    | (a, b) -> printfn "Pair %A %A" a b 
// val print' : 'a * 'b -> unit 

// Declare a record type 
type Person = { Name : string; Age : int } 
// type Person =
//  {Name: string;
//   Age: int;}
// make a value via record expression 
let paul = { Name = "Paul"; Age = 28 } 
// val paul : Person = {Name = "Paul";
//                    Age = 28;}
// ’Copy and update’ record expression
let paulsTwin = { paul with Name = "Jim" }
// val paulsTwin : Person = {Name = "Jim";
//                          Age = 28;}
// Records can be augmented with properties and methods:
type Person with
    member x.Info = (x.Name, x.Age)
// type Person with
//   member Info : string * int
let isPaul person = 
    match person with 
    | { Name = "Paul" } -> true 
    | _ -> false
// val isPaul : person:Person -> bool 
