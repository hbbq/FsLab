module Lab

let Chars =
    string >> (fun e -> seq [for c in e -> c])

let IsNumeric v = 
    fst (System.Int32.TryParse(string(v)))

let Digits = 
    string >> Chars >> Seq.where IsNumeric >> Seq.map (string >> int)

let DigitSum =
    string >> Digits >> Seq.sum

