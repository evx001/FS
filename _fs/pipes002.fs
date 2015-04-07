// Pipes002 
let negate x = x * -1
let square x = x * x 
let print x = printfn "The number is: %d" x
// Pipe operator |> is used to chain functions and arguments together.
let ``square, negate, then print`` x = x |> square |> negate |> print
// Double-backtick identifiers are handy to improve readability especially in unit testing:

``square, negate, then print`` 3
