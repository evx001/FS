// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
type Markup = 
| ContentElement of string * Markup list
| EmptyElement of string 
| Content of string 

(*
let movieList = 
    ContentElement(" html", 
    [ ContentElement("head", [ ContentElement("title", [ Content "Guilty Pleasures"])])
        ContentElement("body",
            [ ContentElement("article", 
              [ ContentElement("h1", [Co ntent "Some Guilty Pleasures" ]) 
                ContentElement ("p",
                    [ Content "These are "
                    ContentElement("strong", [Content "a few"])
                    Content " of my guilty pleasures")]
                ContentElement ("ul", 
                    [ContentElement("li", [ Content "Crank (2006)"])
                    ContentElement("li", "Starship Tropers (1997)"])
                    ContentElement("li", "RoboCop (1987)"])])])])])

let rec toHtml markup = 
    match markup with 
        ContentElement (tag, children) -> 
            use w = new System.IO.StringWriter() 
            children
                |> Seq.map toHtml 
                |> Seq.iter (fun (s : string) -> w.Writer(s))
            sprintf "<%s>%s</%s>" tag
            Content (c) -> sprintf "%s" c 
             
 HtmlString(movieList |> toHtml) |> displayHtml 
 *)
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    System.Console.ReadLine()|> ignore 
    0 // return an integer exit code

 