// Learn more about F# at http://fsharp.org

open System
open Units
open Electric
open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

let printLevelChargeTime level (volts : float<volt>) (amps : float<ampere>) (batteryCapacity : float<kW Hr>) =
    let chargeTime : float<Hr> = Electric.getChargeTime volts amps batteryCapacity
    printfn "Level %i charge time at %g volts and %g amps is %g hours." level volts amps chargeTime
    ()

[<EntryPoint>]
let main argv =
    let input = 400.0<LbFt>
    let output = convertPoundFeetToNewtonMeters input
    let backToinput = convertNewtonMetersToPoundFeet output

    //let error = Units.convertGramsToKilograms input

    printfn "The Chevy Spark EV has %g Newton-meters of torque." output
    printfn "The Chevy Spark EV has %g lb-ft of torque." backToinput
    printfn "\r\n\r\n"


    let mph = 90.0<Mile/Hr>
    let mps = convertMphToMps mph
    let backToMph = convertMpsToMph mps
    printfn "The Chevy Spark EV has a max speed of %g mph." backToMph
    printfn "The Chevy Spark EV has a max speed of %g meters per second." mps

    printfn "\r\n\r\n"

    let avgMph = 60.0<Mile/Hr>
    let avgMps = convertMphToMps avgMph
    let avgBackToMph = convertMpsToMph avgMps
    printfn "Average highway speed is %g mph." avgBackToMph
    printfn "Average highway speed is %g meters per second." avgMps

    printfn "\r\n\r\n"


    // The Chevy Spark EV battery capacity is 19 kWh.
    let sparkCapacity = 19.0<kWh>


    printLevelChargeTime 2 240.0<volt> 16.0<ampere> sparkCapacity
    printLevelChargeTime 1 120.0<volt> 12.0<ampere> sparkCapacity
    printLevelChargeTime 1 120.0<volt> 8.0<ampere> sparkCapacity

    let kw = 40.0<kW>
    let fastChargeTime : float<Hr> = Electric.getChargeTimeKw kw sparkCapacity
    printfn "DC fast charge time at an average of %g kW is %g hours." kw fastChargeTime 
    //printfn "240V with 16A for 1 Hr = %g kWh." Electric.charge
    printfn "\r\n\r\n"

    0 // return an integer exit code
