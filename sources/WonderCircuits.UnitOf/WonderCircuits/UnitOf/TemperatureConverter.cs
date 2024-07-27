using System;
namespace WonderCircuits.UnitOf
{
    public class TemperatureConverter : BaseNumberConverter
    {
        private const int C = 1; //Celsius 
        private const int F = 2; //Fahrenheit 
        private const int K = 3; //kelvin 
        private const int R = 4; //Rankine 
        private const int RE = 5;//Reaumur
        public TemperatureConverter()
        {

        }
        public TemperatureConverter(double value, TemperatureUnits units) : base(BuildFromContext(value, units))
        {

        }

        public TemperatureConverter From(double value, TemperatureUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(TemperatureUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return FromCelsiusToType(ToCelsius(Context.Value, Context.Bases), toConstant);
        }

        private double ToCelsius(double v, double t)
        {
            switch (t)
            {
                case F: return (v - 32) / 1.8;
                case K: return v - 273.15;
                case R: return (v - 491.67) * (5.0 / 9.0);
                case RE: return v * 1.25;
                default: return v;
            }
        }
        private double FromCelsiusToType(double v, double t)
        {
            switch (t)
            {
                case F: return v * 1.8 + 32;
                case K: return v + 273.15;
                case R: return (v + 273.15) * 1.8;
                case RE: return v * 0.8;
                default: return v;
            }
        }

        private static double GetBaseConstant(TemperatureUnits units)
        {
            switch (units)
            {
                case TemperatureUnits.Celsius: { return (C); }
                case TemperatureUnits.Fahrenheit: { return (F); }
                case TemperatureUnits.Kelvin: { return (K); }
                case TemperatureUnits.Rankine: { return (R); }
                case TemperatureUnits.Reaumur: { return (RE); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, TemperatureUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class TemperatureConverterExtensions
    {
        #region From & To Methods
        //public TemperatureConverter FromCelsius(double v) { return StoreFromContext(this, v, C, "C"); }
        //public TemperatureConverter FromFahrenheit(double v) { return StoreFromContext(this, v, F, "F"); }
        //public TemperatureConverter FromKelvin(double v) { return StoreFromContext(this, v, K, "K"); }
        //public TemperatureConverter FromRankine(double v) { return StoreFromContext(this, v, R, "R"); }
        //public TemperatureConverter FromReaumur(double v) { return StoreFromContext(this, v, RE, "RE"); }


        //public double ToCelsius() { return PerformConversion(C); }
        //public double ToFahrenheit() { return PerformConversion(F); }
        //public double ToKelvin() { return PerformConversion(K); }
        //public double ToRankine() { return PerformConversion(R); }
        //public double ToReaumur() { return PerformConversion(RE); }
        #endregion
    }



}