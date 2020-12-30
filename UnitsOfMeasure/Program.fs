// Learn more about F# at http://fsharp.org

open System
open Units

[<EntryPoint>]
let main argv =
    let input = 400.0<LbFt>
    let output = convertPoundFeetToNewtonMeters input
    let backToinput = convertNewtonMetersToPoundFeet output

    //let error = Units.convertGramsToKilograms input

    printfn "The Chevy Spark EV has %f Newton-meters of torque." output
    printfn "The Chevy Spark EV has %f lb-ft of torque." backToinput
    printfn "\r\n\r\n"


    let mph = 90.0<Mile/Hr>
    let mps = convertMphToMps mph
    let backToMph = convertMpsToMph mps
    printfn "The Chevy Spark EV has a max speed of %f mph." backToMph
    printfn "The Chevy Spark EV has a max speed of %f meters per second." mps

    printfn "\r\n\r\n"

    let avgMph = 60.0<Mile/Hr>
    let avgMps = convertMphToMps avgMph
    let avgBackToMph = convertMpsToMph avgMps
    printfn "Average highway speed is %f mph." avgBackToMph
    printfn "Average highway speed is %f meters per second." avgMps

    printfn "\r\n\r\n"


    0 // return an integer exit code
