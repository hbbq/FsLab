module Lab

let IsNumeric str = 
    fst (System.Int32.TryParse(str))

let Digits v = 
    v |> string |> (fun e -> e.ToCharArray()) |> Array.map string |> Array.where IsNumeric |> Array.map int |> Array.toList 

let DigitSum v =
    v |> string |> Digits |> List.sum

