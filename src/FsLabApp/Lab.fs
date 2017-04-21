module Lab

let chars v =
    v |> string |> (fun e -> [for c in e -> c])

let IsNumeric v = 
    fst (System.Int32.TryParse(string(v)))

let Digits v = 
    v |> string |> chars |> List.where IsNumeric |> List.map int

let DigitSum v =
    v |> string |> Digits |> List.sum

