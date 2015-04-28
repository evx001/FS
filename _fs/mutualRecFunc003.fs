let feb2015 =       [("APL* ITUNES.COM/BILL 866-712-7753 CA", 3.26);
                      ("PLURALSIGHT LLC", 29.00);
                      ("Safari Books Online",46.81);
                      ("DNH*GODADDY.COM",10.88);
                      ("MTA MVM*CHAMBERS STQPS NEW YORK NY", 19.05);
                      ("DNH*GODADDY.COM",13.04);
                      ("GH GITHUB.COM WOHA 4157354488",7.00);
                      ("NYC TAXI 7N42",12.96);
                      ("WWW.TEAMTREEHOUSE.COM 8009282130",25.00);
                      ("MTA MVM*CHAMBERS STQPS NEW YORK NY",19.05);
                      ("Amazon Payments",5.00);
                      ("MTA MVM*CLARK STREEQPS NEW YORK NY",19.05);
                      ("MEETUP.COM",89.94)]  

//    let rec fib n =
//        match n with
//        | 0 -> 0
//        | 1 -> 1
//        | _ -> fib (n - 1) + fib (n - 2)

// let xs = snd(feb2015.Head)::[]
// list comsuming where n gets feb2015
// let ys = snd((feb2015.Tail).Head)::[]
let rec xs n = 
    match n with 
    | [] -> [] 
    | xs -> snd(n.Head)::[]
and ys n = 
    match n with
    |[] -> [] 
    | ys -> snd((n.Tail).Head)::[]

printfn "%A" (xs feb2015) //> [3.26]

