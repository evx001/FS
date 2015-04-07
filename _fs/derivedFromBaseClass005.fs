// derivedFromBaseClass
type Animal() =
    member __.Rest() = ()

type Dog() =
    inherit Animal()
    member __.Run() =
        base.Rest()

let dog = Dog() 
// upcast 
let animal = dog :> Animal 
// Dynamic casting 
let probablyADog = animal :?> Dog

(*
type Animal =
  class
    new : unit -> Animal
    member Rest : unit -> unit
  end
type Dog =
  class
    inherit Animal
    new : unit -> Dog
    member Run : unit -> unit
  end
val dog : Dog
val animal : Animal
val probablyADog : Dog
*) 

