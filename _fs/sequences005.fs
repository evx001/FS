// module Sequences 
open System 
open System.IO 

let integers = seq {for i in 1..11 -> i} // i in place or yield
let intergers' = Seq.init 100 (fun i -> i+1)
let intergers'' = Seq.initInfinite (fun i -> i+1)
// seq is immutable
// some part of the sequence must return some value but all branches needn't 
// supports recursive functions that works much like Seq.unfold
let rec seqRecur i = 
    seq { 
       if i < 100 then 
          yield i 
          yield! (seqRecur (i + 1))
}

let fileHierarchyTrev startDir = 
    printfn "%A" (Directory.EnumerateFiles(startDir, @" / . ", System.IO.SearchOption.AllDirectories))

// recursive file heirarchy traversal 

