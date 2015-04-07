// functions002 

let negate x = x * -1
let square x = x * x 
let print x = printfn "The number is: %d" x

let squareNegateThenPrint x =
    print (negate (square x))


// printfn "%A" (negate 3) 
printfn "%A" (squareNegateThenPrint 3) 
// functions002 


let negate x = x * -1
let square x = x * x 
let print x = printfn "The number is: %d" x

let squareNegateThenPrint x =
    print (negate (square x))


printfn "%A" (squareNegateThenPrint 3) 
