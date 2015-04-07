let lsInit = List.init 3 
              (fun i -> 1 * 2) 
// val lsInit : int list = [2; 2; 2]

let isGen = [0;2;4]
// val isGen : int list = [0; 2; 4]

let lsgen2 = [0..2..8]
// val lsgen2 : int list = [0; 2; 4; 6; 8]

let lsgen2' = [0..8]
// val lsgen2' : int list = [0; 1; 2; 3; 4; 5; 6; 7; 8]

let lsgen3 = 
    [for i in 0..3 -> 0.5 * float i]
// val lsgen3 : float list = [0.0; 0.5; 1.0; 1.5]


// gen with interum steps
let lsgen3' =
    [for i in 0..3 ->
            printf "Adding %d\n" i
            0.5 * float i]
(*
Adding 0
Adding 1
Adding 2
Adding 3
val lsgen3' : float list = [0.0; 0.5; 1.0; 1.5]
*)

let inserted = -1 :: lsgen2' 
// val inserted : int list = [-1; 0; 1; 2; 3; 4; 5; 6; 7; 8]
let concat = lsgen2 @ lsgen2'
// val concat : int list = [0; 2; 4; 6; 8; 0; 1; 2; 3; 4; 5; 6; 7; 8]
let arinit = Array.init 3
                (fun i -> i * 2)
// val arinit : int [] = [|0; 2; 4|] 

let argen = [| 0 ; 2 ; 4|]
// val argen : int [] = [|0; 2; 4|] 

let argen2 = [|0 .. 2 .. 8|]
// val argen2 : int [] = [|0; 2; 4; 6; 8|]

let argen2' = [|0..8|]
// val argen2' : int [] = [|0; 1; 2; 3; 4; 5; 6; 7; 8|]

let argen3 = 
        [|for i in 0..3 -> 0.5 * float i|] 
// val argen3 : float [] = [|0.0; 0.5; 1.0; 1.5|]

let argen3' = 
    [|for i 0..3 -> 
            printf "Adding %d\n" i 
            0.5 * float i |] 
// val argen3 : float [] = [|0.0; 0.5; 1.0; 1.5|]

