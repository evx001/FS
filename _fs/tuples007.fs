let x = (1,"Hello")
//> val x : int * string = (1, "Hello")
let a,b = x
// val b : string = "Hello"
// val a : int = 1

let y = (x,(a,b))
// val y : (int * string) * (int * string) = ((1, "Hello"), (1, "Hello"))

let z = (x,y,a)
// val z : (int * string) * ((int * string) * (int * string)) * int =
//  ((1, "Hello"), ((1, "Hello"), (1, "Hello")), 1)

let ((a',b'),y',a'') = z
// val y' : (int * string) * (int * string) = ((1, "Hello"), (1, "Hello"))
// val b' : string = "Hello"
// val a'' : int = 1
// val a' : int = 1
