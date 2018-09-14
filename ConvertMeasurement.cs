
namespace WheyCoolTools.Convert
{
    /// <summary>
    /// ConvertMeasurement, v0.2
    /// Provides methods for converting between units of measurement.
    /// NOTE: Rounding of some conversions may be necessary. The class
    /// is generally accurate within 6 decimal places.
    /// </summary>
    /// 
    // TODO
    // Create a wrapper method that allows for greater precision and/or rounding.
    // The method could check to see how many significant digits on the left
    // side of the decimal point exist, and round accordingly. Allow a bool
    // to override this feature.
    //
    // NOTE: Many methods have not been tested yet.
    public static class ConvertMeasurement
    {
        public static decimal KilometersToMiles(decimal kilometers) => 0.62137m * kilometers;
        public static decimal MilesToKilometers(decimal miles) => 1.60934m * miles;

        public static decimal MilesPerHourToKnots(decimal milesPerHour) => 0.868976m * milesPerHour;
        public static decimal KnotsToMilesPerHour(decimal knots) => 1.15078m * knots;

        public static decimal MilesToNauticalMiles(decimal miles) => 0.86976m * miles;
        public static decimal NauticalMilesToMiles(decimal nauticalMiles) => 1.15078m * nauticalMiles;

        public static decimal InchesToCentimeters(decimal inches) => 2.54m * inches;
        public static decimal CentimetersToInches(decimal centimeters) => 0.393701m * centimeters;

        public static decimal FahrenheitToCelsius(decimal fahrenheit) => ((fahrenheit - 32m) * (5m / 9m));
        public static decimal CelsiusToFahrenheit(decimal celsius) => (celsius * (9m / 5m) + 32m);

        public static decimal CelsiusToKelvin(decimal celsius) => celsius + 273.15m;
        public static decimal KelvinToCelsius(decimal kelvin) => kelvin - 273.15m;

        public static decimal FahrenheitToKelvin(decimal fahrenheit) => ((5m / 9m) * (fahrenheit - 32m) + 273m);
        public static decimal KelvinToFahrenheit(decimal kelvin) => ((9m / 5m) * (kelvin - 273m) + 32m);

        public static decimal LitersToUSQuarts(decimal liters) => 1.056710m * liters;
        public static decimal USQuartsToLiters(decimal quarts) => 0.946353m * quarts;

        public static decimal USGallonsToLiters(decimal usGallons) => 3.78541m * usGallons;
        public static decimal LitersToUSGallons(decimal liters) => 0.264172m * liters;

        public static decimal PoundsToGrams(decimal pounds) => 453.59237m * pounds;
        public static decimal GramsToPounds(decimal grams) => 0.002204622621848775m * grams;

        public static decimal OuncesToGrams(decimal ounces) => 28.349523125m * ounces;
        public static decimal GramsToOunces(decimal grams) => 0.0352739619495799m * grams;

        public static decimal StonesToPounds(decimal stones) => 14m * stones;
        public static decimal PoundsToStones(decimal pounds) => pounds / 14m;

        public static decimal USTonsToMetricTons(decimal usTons) => 0.907185m * usTons;
        public static decimal MetricTonsToUSTons(decimal metricTons) => 1.1023113109244m * metricTons;

        public static decimal MilesToFeet(decimal miles) => 5280m * miles;
        public static decimal MilesToInches(decimal miles) => 63360m * miles;
        public static decimal MilesToYards(decimal miles) => 1760m * miles;
        public static decimal FeetToMiles(decimal feet) => feet / 5280m; 
        public static decimal InchesToMiles(decimal inches) => (FeetToMiles(inches)) / 12m;

        public static decimal YardsToMiles(decimal yards) => 0.00056818181818181818m * yards;
        public static decimal YardsToFeet(decimal yards) => 3m * yards;
        public static decimal YardsToInches(decimal yards) => 36m * yards;
        public static decimal FeetToYards(decimal feet) =>  feet / 3m;
        public static decimal InchesToYards(decimal inches) => inches / 36m;

        public static decimal FeetToInches(decimal feet) => 12m * feet;
        public static decimal InchesToFeet(decimal inches) => inches / 12m;
        public static decimal MilesPerHoursToKilometersPerHour(decimal milesPerHour) => 
            1.609344m * milesPerHour;
        public static decimal KilometerPerHourToMilesPerHour(decimal kilometersPerHour) =>
            kilometersPerHour / 1.609344m;

        public static decimal KilometerToMeters(decimal kilometers) => 1000m * kilometers;
        public static decimal MetersToKilometers(decimal meters) => meters / 1000m;
        public static decimal KilometersPerSecondToMetersPerSecond(decimal kilometersPerSecond) =>
            kilometersPerSecond / 3.6m;
        public static decimal MetersPerSecondToKilometersPerHour(decimal metersPerSecond) =>
            metersPerSecond * 3.6m;

        public static decimal MilesPerHourToFeetPerSecond(decimal milesPerHour) =>
            1.46666666666666666666666666666666666666666666666667m * milesPerHour;

        public static decimal FeetPerSecondToMilesPerHour(decimal feetPerSecond) =>
            feetPerSecond / 1.46666666666666666666666666666666666666666666666667m;

        public static decimal DegreesToRadians(decimal degrees) => degrees * 0.01745329252m;
        public static decimal RadiansToDegrees(decimal radians) => radians * 57.295779513m;
        /* 
        * IMPLEMENTED BUT NOT YET COMMITED
        *  
        * /

       /*
          NOT YET IMPLEMENTED

         
          
           Days <--> Hours <--> Minutes <--> Seconds
           Watts <--> BTUs/hr
           Watts <--> Kilowatts
           Horsepower <--> Watts
           Kilocalorie <--> Joule
           Atmosphere <--> PSI
           More To Come...
        */

    }

}