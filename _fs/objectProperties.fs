// objectProperties 

type Vector(x : float, y : float) = 
    let mag = sqrt(x * x + y * y) // let binding  
    member this.X = x // propeties 
    member this.Y = y 
    member this.Mag = mag 
    member this.Scales(s) =  // methods
        Vector(x * s, y * s) 
    static member (+) (a : Vector, b : Vector) = 
        Vector(a.X + b.X, a.Y)

(*
type Vector =
  class
    new : x:float * y:float -> Vector
    member Scales : s:float -> Vector
    member Mag : float
    member X : float
    member Y : float
    static member ( + ) : a:Vector * b:Vector -> Vector
  end
*)
