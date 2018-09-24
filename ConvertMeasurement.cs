//Author: Dave Bochichio
//https://davebochichio.com
//https://github.com/DaveEC42
//
namespace WheyCoolStudios.Tools.Convert
{
    /// <summary>
    /// ConvertMeasurement, v0.3
    /// Provides methods for converting between units of measurement.
    /// NOTE: Rounding of some conversions may be necessary. The class
    /// is generally accurate within 6 double places.
    /// </summary>
    /// 
    // TODO
    // Create a wrapper method that allows for greater precision and/or rounding.
    // The method could check to see how many significant digits on the left
    // side of the double point exist, and round accordingly. Allow a bool
    // to override this feature.
    //
    // NOTE: Many methods have not been tested yet.
    public static class ConvertMeasurement
    {
        public static double KilometersToMiles(double kilometers) => 0.62137 * kilometers;
        public static double MilesToKilometers(double miles) => 1.60934 * miles;

        public static double MilesPerHourToKnots(double milesPerHour) => 0.868976 * milesPerHour;
        public static double KnotsToMilesPerHour(double knots) => 1.15078 * knots;

        public static double MilesToNauticalMiles(double miles) => 0.86976 * miles;
        public static double NauticalMilesToMiles(double nauticalMiles) => 1.15078 * nauticalMiles;

        public static double InchesToCentimeters(double inches) => 2.54 * inches;
        public static double CentimetersToInches(double centimeters) => 0.393701 * centimeters;

        public static double FahrenheitToCelsius(double fahrenheit) => ((fahrenheit - 32d) * (5d / 9d));
        public static double CelsiusToFahrenheit(double celsius) => (celsius * (9d / 5d) + 32d);

        public static double CelsiusToKelvin(double celsius) => celsius + 273.15;
        public static double KelvinToCelsius(double kelvin) => kelvin - 273.15;

        public static double FahrenheitToKelvin(double fahrenheit) => ((5d / 9d) * (fahrenheit - 32d) + 273d);
        public static double KelvinToFahrenheit(double kelvin) => ((9d / 5d) * (kelvin - 273d) + 32d);

        public static double LitersToUSQuarts(double liters) => 1.056710 * liters;
        public static double USQuartsToLiters(double quarts) => 0.946353 * quarts;

        public static double USGallonsToLiters(double usGallons) => 3.78541 * usGallons;
        public static double LitersToUSGallons(double liters) => 0.264172 * liters;

        public static double PoundsToGrams(double pounds) => 453.59237 * pounds;
        public static double GramsToPounds(double grams) => 0.002204622621848775 * grams;

        public static double OuncesToGrams(double ounces) => 28.349523125 * ounces;
        public static double GramsToOunces(double grams) => 0.0352739619495799 * grams;

        public static double StonesToPounds(double stones) => 14d * stones;
        public static double PoundsToStones(double pounds) => pounds / 14d;

        public static double USTonsToMetricTons(double usTons) => 0.907185 * usTons;
        public static double MetricTonsToUSTons(double metricTons) => 1.1023113109244 * metricTons;

        public static double MilesToFeet(double miles) => 5280d * miles;
        public static double MilesToInches(double miles) => 63360d * miles;
        public static double MilesToYards(double miles) => 1760d * miles;
        public static double FeetToMiles(double feet) => feet / 5280d; 
        public static double InchesToMiles(double inches) => (FeetToMiles(inches)) / 12d;

        public static double YardsToMiles(double yards) => yards / 1760d;
        public static double YardsToFeet(double yards) => 3d * yards;
        public static double YardsToInches(double yards) => 36d * yards;
        public static double FeetToYards(double feet) =>  feet / 3d;
        public static double InchesToYards(double inches) => inches / 36d;

        public static double FeetToInches(double feet) => 12d * feet;
        public static double InchesToFeet(double inches) => inches / 12d;
        public static double MilesPerHoursToKilometersPerHour(double milesPerHour) => 
            1.609344 * milesPerHour;
        public static double KilometerPerHourToMilesPerHour(double kilometersPerHour) =>
            kilometersPerHour / 1.609344;

        public static double KilometerToMeters(double kilometers) => 1000d * kilometers;
        public static double MetersToKilometers(double meters) => meters / 1000d;
        public static double KilometersPerSecondToMetersPerSecond(double kilometersPerSecond) =>
            kilometersPerSecond / 3.6d;
        public static double MetersPerSecondToKilometersPerHour(double metersPerSecond) =>
            metersPerSecond * 3.6d;

        public static double MilesPerHourToFeetPerSecond(double milesPerHour) =>
            1.46666666666666666666666666666666666666666666666667 * milesPerHour;

        public static double FeetPerSecondToMilesPerHour(double feetPerSecond) =>
            feetPerSecond / 1.46666666666666666666666666666666666666666666666667;

        public static double DegreesToRadians(double degrees) => 0.01745329252 * degrees;
        public static double RadiansToDegrees(double radians) => 57.295779513 * radians;

        public static double DaysToHours(double days) => days * 24d;
        public static double DaysToMinutes(double days) => days * 24d * 60d;
        public static double DaysToSeconds(double days) => days * 24d * 60d * 60d;

        public static double HoursToMinutes(double hours) => hours * 60d;
        public static double HoursToSeconds(double hours) => hours * 60d * 60d;

        public static double MinutesToSeconds(double minutes) => minutes * 60d;

        public static double SecondsToMinutes(double seconds) => seconds / 60d;
        public static double SecondsToHours(double seconds) => seconds / (60d * 60d);
        public static double SecondsToDays(double seconds) => seconds / (60d * 60d * 24d);

        public static double MinutesToHours(double minutes) => minutes / 60d;
        public static double MinutesToDays(double minutes) => minutes / (60d * 24d);

        public static double HoursToDays(double hours) => hours / 24d;

        public static double WattsToKilowatts(double watts) => watts / 1000d;
        public static double KilowattsToWatts(double kilowatts) => 1000d * kilowatts;

        public static double HorsepowerToWatts(double horsepower) => 745.6998715823 * horsepower;
        public static double WattsToHorsepower(double watts) => watts / 745.6998715823;
        
        public static double KilocaloriesToJoules(double kilocalories) => 4184d * kilocalories;
        public static double JoulesToKilocalories(double joules) => joules / 4184d;

        public static double AtmospheresToPSI(double atmospheres) => 14.695948775872306 * atmospheres;
        public static double PSIToAtmospheres(double psi) => psi / 14.695948775872306;
        
    }

}