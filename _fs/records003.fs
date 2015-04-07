// Declare a record type 
type Person = { Name : string; Age : int } 
// add an instance of a record 
let paul = { Name = "Paul"; Age = 28 } 
// updating 
let paulsTwin = { paul with Name = "Jim" } 
// properties and methods for records
type Person with 
    member x.Info = (x.Name,x.Age)
// records are much like superstatic classes 
let isPaul person = 
    match person with 
    | { Name = "Paul" } -> true 
    | _ -> false 