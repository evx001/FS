// derivedFromBaseClass
type ICustomer =
    abstract Name : string
    abstract Age : int

let createCustomer name age =
    { new ICustomer with
        member __.Name = name
        member __.Age = age }

(*
type ICustomer =
  interface
    abstract member Age : int
    abstract member Name : string
  end
val createCustomer : name:string -> age:int -> ICustomer 
*) 