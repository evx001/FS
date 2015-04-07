// Generating-List-Array-Seq
//////////////////////////////////////

// Generating a List
// 1. too generic 
let lsInit = List.init 3 // warning:  The value 'lsInit' has been inferred to have generic type
              
// 2. whitespace issue               
let lsInit = List.init 3
    (fun i -> 1 * 2) // Unexpected symbol '(' ERROR!
    
// 3. whitespace issue still 
let lsInit = List.init 3
	    (fun i -> 1 * 2) // Unexpected symbol '('
	    // BEING RIGHT OF = ERROR! 
	    
// 4. back to first ERROR
let lsInit = List.init 3 
	     (fun i -> 1 * 2) // warning:  The value 'lsInit' has been inferred to have generic type
   
// 5. =) finally 
let lsInit = List.init 3 
	      (fun i -> 1 * 2) 
// val lsInit : int list = [2; 2; 2]

//////////////////////////////////////

