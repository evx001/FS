// Array creation
let arryOne = Array.create 11 ""
//> val arryOne : string [] = [|""; ""; ""; ""; ""; ""; ""; ""; ""; ""; ""|]

let num = [|1;2;3|]
let nums = [|1..21|]

let numEvens = [|for i in nums do 
                    if i%2 = 0 then yield i|] 
//> val numEvens : int [] = [|2; 4; 6; 8; 10; 12; 14; 16; 18; 20|]



let arry000 = [|0..9|] |> Array.append [|11..19|] |> Array.sortBy (fun x -> x % 2 =0)
//> val arry000 : int [] =
///  [|11; 19; 9; 1; 3; 5; 7; 17; 15; 13; 18; 8; 12; 6; 4; 14; 2; 16; 0|]
