 // Exceptions 
// The failwith function throws an exception of type Exception.
let divideFailwith x y =
    if y = 0 then 
        failwith "Divisor cannot be zero." 
    else x / y
// val divideFailwith : x:int -> y:int -> int

// try and with expressions 
let divide x y =
   try
       Some (x / y)
   with :? System.DivideByZeroException -> 
       printfn "Division by zero!"
       None
//val divide : x:int -> y:int -> int option 

exception InnerError of string
exception OuterError of string
// The try/finally expression enables you to execute clean-up code even if a block of code throws an exception. Here's an example which also defines custom exceptions.
let handleErrors x y =
   try 
     try 
        if x = y then raise (InnerError("inner"))
        else raise (OuterError("outer"))
     with InnerError(str) -> 
          printfn "Error1 %s" str
   finally
      printfn "Always print this."
(*
exception InnerError of string
exception OuterError of string
val handleErrors : x:'a -> y:'a -> unit when 'a : equality
*) 
