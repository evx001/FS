module RpnCalc
open System 
let v = [ "4 3 5 * + 1 3 2 * + /"]
let evalRpnExpr (s : string) = 
        let solve items current = 
            match (current, items) with 
            | "+", y::x::t -> (x + y)::t 
            | "-", y::x::t -> (x - y)::t 
            | "*", y::x::t -> (x * y)::t
            | "/", y::x::t -> (x / y)::t
            | _ -> (float current)::items
        (s.Split(' ') |> Seq.fold solve []).Head



[<EntryPoint>]
let main argv = 
    v // a list of ...
    |> List.map (fun expr -> expr, evalRpnExpr expr)
    |> List.iter (fun (expr, result) -> printfn "(%s) = %A" expr result)
    Console.ReadLine() |> ignore