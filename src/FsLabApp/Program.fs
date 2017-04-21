// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    let res = Lab.Primes |> Seq.take 4
    printfn "%A" res
    let s = System.Console.ReadKey()
    0 // return an integer exit code
