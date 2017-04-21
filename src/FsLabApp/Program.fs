// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    let res = Lab.Factorize 360 |> Seq.map string |> String.concat ", "
    printfn "%A" res
    let s = System.Console.ReadKey()
    0 // return an integer exit code
