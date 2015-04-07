// matching Patterns with "match" 
let rec fib n = 
    match n with 
    | 0 -> 0 
    | 1 -> 1 
    | _ -> fib (n - 1) + fib (n - 2)

// using when allows us to further refine inputs 
let sign x = 
    match x with 
    | 0 -> 0 
    | x when x < 0 -> -1 
    | x -> 1 

// Pattern matching can be done directly on args
let fst' (x,_) = x 

// implicitly using "function" 
let rec fib' = function 
    | 0 -> 0  
    | 1 -> 1 
    |n -> fib' (n - 1) + fib' (n -  2) 
 
/// note what about the (-1)  case? 