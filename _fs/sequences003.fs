// Sequences 
let seq1 = 
    seq { 
        yield 1 
        yield 2 
        yield! [5..10] 
    }
// val seq1 : seq<int> 