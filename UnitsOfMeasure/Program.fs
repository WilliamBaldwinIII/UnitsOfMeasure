// Learn more about F# at http://fsharp.org

open System
open Units
open Electric
open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

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


    // The Chevy Spark EV battery capacity is 19 kWh.
    let sparkCapacity = 19.0<kWh>
    let voltage = 240.0<volt>
    let amps = 16.0<ampere>

    let chargeTime : float<Hr> = Electric.getChargeTime voltage amps sparkCapacity


    let kw = 40.0<kW>
    let fastChargeTime : float<Hr> = Electric.getChargeTimeKw kw sparkCapacity

    printfn "Level 2 charge time at %f volts and %f amps is %f hours." voltage amps chargeTime 
    printfn "DC fast charge time at an average of %f kW is %f hours." kw fastChargeTime 
    //printfn "240V with 16A for 1 Hr = %f kWh." Electric.charge
    printfn "\r\n\r\n"

    0 // return an integer exit code
