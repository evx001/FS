open System
/// given x 
let negate x = x * -1
let square x = x * x
let print x = printfn "The number is: %d" x
let squareNegateThenPrint x =
    print (negate (square x))

    
/// piping with functions 
let sumOfLenghts (xs :string []) = 
    xs 
    |> Array.map (fun s  -> s.Length) 
    |> Array.sum 

/// composition with functions 
let squareNegateThenPrint' = 
    square >> negate >> print 

/// mutually recursive functions 
let rec even x = 
    if x  = 0 then true
    else odd (x - 1) 

and odd x = 
    if x  =1 then true 
    else even (x - 1) 
/// and supplies the mutual recursive extension 
