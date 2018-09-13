using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheyCoolTools.Convert
{
    public static class ConvertMeasurement
    {
        public static double KilometersToMiles(double kilometers) => 0.62137f * kilometers;
        public static double MilesToKilometers(double miles) => 1.60934f * miles;

        public static double MilesPerHourToKnots(double milesPerHour) => 0.868976f * milesPerHour;
        public static double KnotsToMilesPerHour(double knots) => 1.15078f * knots;

        public static double MilesToNauticalMiles(double miles) => 0.86976f * miles;
        public static double NauticalMilesToMiles(double nauticalMiles) => 1.15078f * nauticalMiles;

        public static double InchesToCentimeters(double inches) => 2.54f * inches;
        public static double CentimetersToInches(double centimeters) => 0.393701f * centimeters;

        public static double FahrenheitToCelsius(double fahrenheit) => ((fahrenheit - 32.0f) * (5.0f / 9.0f));
        public static double CelsiusToFahrenheit(double celsius) => (celsius * (9.0f / 5.0f) + 32.0f);

        public static double CelsiusToKelvin(double celsius) => celsius + 273.15f;
        public static double KelvinToCelsius(double kelvin) => kelvin - 273.15f;

        public static double FahrenheitToKelvin(double fahrenheit) => ((5.0f / 9.0f) * (fahrenheit - 32.0f) + 273.0f);
        public static double KelvinToFahrenheit(double kelvin) => ((9.0f / 5.0f) * (kelvin - 273.0f) + 32.0f);

        public static double LitersToUSQuarts(double liters) => 1.056710f * liters;
        public static double USQuartsToLiters(double quarts) => 0.946353f * quarts;

        public static double USGallonsToLiters(double usGallons) => 3.78541f * usGallons;
        public static double LitersToUSGallons(double liters) => 0.264172f * liters;

        public static double PoundsToGrams(double pounds) => 453.59237f * pounds;
        public static double GramsToPounds(double grams) => 0.002204622621848775f * grams;

        public static double OuncesToGrams(double ounces) => 28.349523125f * ounces;
        public static double GramsToOunces(double grams) => 0.0352739619495799f * grams;

        public static double StonesToPounds(double stones) => 14.0f * stones;
        public static double PoundsToStones(double pounds) => 0.071428571428572f * pounds;

        public static double USTonsToMetricTons(double usTons) => 0.907185f * usTons;
        public static double MetricTonsToUSTons(double metricTons) => 1.1023113109244f * metricTons;

    }

}