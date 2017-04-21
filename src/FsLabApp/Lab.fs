﻿module Lab

let Chars =
    string >> (fun e -> seq [for c in e -> c])

let IsNumeric v = 
    fst (System.Int32.TryParse(string(v)))

let Digits = 
    string >> Chars >> Seq.where IsNumeric >> Seq.map (string >> int)

let DigitSum =
    string >> Digits >> Seq.sum

let rec InfSeq start inc = seq {
    yield start
    yield! InfSeq (start + inc) inc
}

let IsPrime n =
    let f = float n
    f % 2.0 > 0.0
    &&
    seq {3.0..2.0..sqrt f} |> Seq.tryFind (fun e -> f % e = 0.0) |> (=) None

let Primes =
    let s = seq {
        yield 2
        yield! InfSeq 3 2
    }
    s |> Seq.filter IsPrime
