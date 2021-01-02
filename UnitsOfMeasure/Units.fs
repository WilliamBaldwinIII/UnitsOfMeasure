module Units


// COURTESY OF https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/units-of-measure

/// Mass, grams.
[<Measure>] type g
/// Mass, kilograms.
[<Measure>] type kg
/// Weight, pounds.
[<Measure>] type lb

/// Distance, meters.
[<Measure>] type m
/// Distance, cm
[<Measure>] type cm

/// Distance, inches.
[<Measure>] type inch
/// Distance, feet
[<Measure>] type ft

/// Time, seconds.
[<Measure>] type s

/// Force, Newtons.
[<Measure>] type N = kg m / s^2

/// Pressure, bar.
[<Measure>] type bar
/// Pressure, Pascals
[<Measure>] type Pa = N / m^2

/// Volume, milliliters.
[<Measure>] type ml
/// Volume, liters.
[<Measure>] type L

// Define conversion constants.
let gramsPerKilogram : float<g kg^-1> = 1000.0<g/kg>
let cmPerMeter : float<cm/m> = 100.0<cm/m>
let cmPerInch : float<cm/inch> = 2.54<cm/inch>

let mlPerCubicCentimeter : float<ml/cm^3> = 1.0<ml/cm^3>
let mlPerLiter : float<ml/L> = 1000.0<ml/L>

// Define conversion functions.
let convertGramsToKilograms (x : float<g>) = x / gramsPerKilogram
let convertCentimetersToInches (x : float<cm>) = x / cmPerInch






// MY STUFF


/// Torque, Newton-meter
[<Measure>] type Nm = N m



/// Torque, Pound foot
[<Measure>] type LbFt = lb ft


/// Distance, mile
[<Measure>] type Mile

/// Time, hour
[<Measure>] type Hr

let feetPerMile = 5280.0<ft/Mile>
let secondsPerHour = 60.0 * 60.0<s/Hr>

//let newtonMetersPerPoundFoot = 1.35582<Nm/LbFt>
let newtonsPerPound = 4.448222<N/lb>
let metersPerFoot = 0.3048<m/ft>
let newtonMetersPerPoundFoot : float<Nm/LbFt> = newtonsPerPound * metersPerFoot


let convertPoundFeetToNewtonMeters (poundFeet : float<LbFt>) = poundFeet * newtonMetersPerPoundFoot
let convertNewtonMetersToPoundFeet (newtonMeters : float<Nm>) = newtonMeters / newtonMetersPerPoundFoot

let convertMpsToFtps (metersPerSecond : float<m/s>) = metersPerSecond / metersPerFoot
let convertMpsToMph (metersPerSecond : float<m/s>) = 
    let feetPerSecond = convertMpsToFtps metersPerSecond
    let mph = feetPerSecond * secondsPerHour / feetPerMile
    mph

let convertMphToMps (mph : float<Mile/Hr>) = 
    let feetPerSecond = mph / secondsPerHour * feetPerMile
    let mps = feetPerSecond * metersPerFoot
    mps