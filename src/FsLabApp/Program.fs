// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    let res = seq [1..10000] |> Seq.sumBy Lab.DigitSum
    printfn "%A" res
    let s = System.Console.ReadKey()
    0 // return an integer exit code
