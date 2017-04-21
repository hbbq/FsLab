﻿module Lab

let Chars v =
    v |> string |> (fun e -> seq [for c in e -> c])

let IsNumeric v = 
    fst (System.Int32.TryParse(string(v)))

let Digits v = 
    v |> string |> Chars |> Seq.where IsNumeric |> Seq.map (string >> int)

let DigitSum v =
    v |> string |> Digits |> Seq.sum

