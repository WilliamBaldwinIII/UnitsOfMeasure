module Electric

open Units
open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols
open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

/// Energy, Kilowatt = 1,000 watts
[<Measure>] type kW

/// Energy, Kilowatt Hour = 1 kW running for 1 hour.
[<Measure>] type kWh = kW Hr


/// Conversion from watt to kilowatt.
let wattToKilowatt = 1000.0<watt/kW>







// Actual stuff

/// <summary>
/// Get the amount of time to charge your car with the given charge rate, and vehicle battery capacity.
/// </summary>
/// <param name="kilowatts">Charge rate of the fast charger.</param>
/// <param name="batteryCapacity">Capacity of the battery in kWh.</param>
let getChargeTimeKw (kilowatts : float<kW>) (batteryCapacity : float<kW Hr>) : float<Hr> =
    1.0/(kilowatts * (1.0/batteryCapacity))


/// <summary>
/// Get the amount of time to charge your car with the given voltage, amperage, and vehicle battery capacity.
/// </summary>
/// <param name="volts">Voltage. Usually 120V or 240V.</param>
/// <param name="amps">Amperage.</param>
/// <param name="batteryCapacity">Capacity of the battery in kWh.</param>
let getChargeTime (volts : float<volt>) (amps : float<ampere>) (batteryCapacity : float<kW Hr>) : float<Hr> =
    let watts : float<watt> = volts * amps
    let kilowatts = watts / wattToKilowatt
    getChargeTimeKw kilowatts batteryCapacity





