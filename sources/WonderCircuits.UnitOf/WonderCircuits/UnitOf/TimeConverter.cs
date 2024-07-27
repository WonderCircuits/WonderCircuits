using System;

namespace WonderCircuits.UnitOf
{
    public class TimeConverter : BaseNumberConverter
    {
        private static readonly double AS = 1e18;            //Attoseconds
        private static readonly double C = 1 / 31536e5;        //Centuries
        private static readonly double D = 1 / 864e2;          //Days
        private static readonly double DE = 1 / 31536e4;       //Decades
        private static readonly double FS = 1e15;            //Femtoseconds
        private static readonly double FN = 1 / 1209600.0;     //Fortnight
        private static readonly double GY = 1 / 31556952.00001;//Gregorian Years
        private static readonly double H = 1 / 36e2;           //Hours
        private static readonly double JY = 1 / 31557600.0;    //Yulian Years
        private static readonly double LY = 1 / 31622400.0;    //Leap Years
        private static readonly double MUS = 1e6;            //Microseconds
        private static readonly double M = 1 / 31536e6;        //Millenniums
        private static readonly double MS = 1e3;             //Milliseconds
        private static readonly double MIN = 1 / 60.0;         //Minutes
        private static readonly double MON = 1 / 2628000.0;    //Months
        private static readonly double NS = 1e9;             //Nanoseconds
        private static readonly double PS = 1e12;            //Picoseconds
        private static readonly double S = 1;                //Seconds
        private static readonly double WK = 1 / 604800.0;      //Weeks
        private static readonly double Y = 1 / 31536e3;        //Years
        public TimeConverter()
        {

        }
        public TimeConverter(double value, TimeUnits units) : base(BuildFromContext(value, units))
        {

        }

        public TimeConverter From(double value, TimeUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(TimeUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(TimeUnits units)
        {
            switch (units)
            {
                case TimeUnits.Attoseconds: { return (AS); }
                case TimeUnits.Centuries: { return (C); }
                case TimeUnits.Days: { return (D); }
                case TimeUnits.Decades: { return (DE); }
                case TimeUnits.Femtoseconds: { return (FS); }
                case TimeUnits.Fortnights: { return (FN); }
                case TimeUnits.GregorianYears: { return (GY); }
                case TimeUnits.Hours: { return (H); }
                case TimeUnits.JulianYears: { return (JY); }
                case TimeUnits.LeapYears: { return (LY); }
                case TimeUnits.Microseconds: { return (MUS); }
                case TimeUnits.Millenniums: { return (M); }
                case TimeUnits.Milliseconds: { return (MS); }
                case TimeUnits.Minutes: { return (MIN); }
                case TimeUnits.Months: { return (MON); }
                case TimeUnits.Nanoseconds: { return (NS); }
                case TimeUnits.Picoseconds: { return (PS); }
                case TimeUnits.Seconds: { return (S); }
                case TimeUnits.Weeks: { return (WK); }
                case TimeUnits.Years: { return (Y); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, TimeUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }

    }

    public static class TimeConverterExtensions
    {
        #region From & To Methods
        //public TimeConverter FromAttoseconds(double v) { return StoreFromContext(this, v, AS, "AS"); }
        //public TimeConverter FromCenturies(double v) { return StoreFromContext(this, v, C, "C"); }
        //public TimeConverter FromDays(double v) { return StoreFromContext(this, v, D, "D"); }
        //public TimeConverter FromDecades(double v) { return StoreFromContext(this, v, DE, "DE"); }
        //public TimeConverter FromFemtoseconds(double v) { return StoreFromContext(this, v, FS, "FS"); }
        //public TimeConverter FromFortnights(double v) { return StoreFromContext(this, v, FN, "FN"); }
        //public TimeConverter FromGregorianYears(double v) { return StoreFromContext(this, v, GY, "GY"); }
        //public TimeConverter FromHours(double v) { return StoreFromContext(this, v, H, "H"); }
        //public TimeConverter FromJulianYears(double v) { return StoreFromContext(this, v, JY, "JY"); }
        //public TimeConverter FromLeapYears(double v) { return StoreFromContext(this, v, LY, "LY"); }
        //public TimeConverter FromMicroseconds(double v) { return StoreFromContext(this, v, MUS, "MUS"); }
        //public TimeConverter FromMillenniums(double v) { return StoreFromContext(this, v, M, "M"); }
        //public TimeConverter FromMilliseconds(double v) { return StoreFromContext(this, v, MS, "MS"); }
        //public TimeConverter FromMinutes(double v) { return StoreFromContext(this, v, MIN, "MIN"); }
        //public TimeConverter FromMonths(double v) { return StoreFromContext(this, v, MON, "MON"); }
        //public TimeConverter FromNanoseconds(double v) { return StoreFromContext(this, v, NS, "NS"); }
        //public TimeConverter FromPicoseconds(double v) { return StoreFromContext(this, v, PS, "PS"); }
        //public TimeConverter FromSeconds(double v) { return StoreFromContext(this, v, S, "S"); }
        //public TimeConverter FromWeeks(double v) { return StoreFromContext(this, v, WK, "WK"); }
        //public TimeConverter FromYears(double v) { return StoreFromContext(this, v, Y, "Y"); }


        //public double ToAttoseconds() { return PerformConversion(AS); }
        //public double ToCenturies() { return PerformConversion(C); }
        //public double ToDays() { return PerformConversion(D); }
        //public double ToDecades() { return PerformConversion(DE); }
        //public double ToFemtoseconds() { return PerformConversion(FS); }
        //public double ToFortnights() { return PerformConversion(FN); }
        //public double ToGregorianYears() { return PerformConversion(GY); }
        //public double ToHours() { return PerformConversion(H); }
        //public double ToJulianYears() { return PerformConversion(JY); }
        //public double ToLeapYears() { return PerformConversion(LY); }
        //public double ToMicroseconds() { return PerformConversion(MUS); }
        //public double ToMillenniums() { return PerformConversion(M); }
        //public double ToMilliseconds() { return PerformConversion(MS); }
        //public double ToMinutes() { return PerformConversion(MIN); }
        //public double ToMonths() { return PerformConversion(MON); }
        //public double ToNanoseconds() { return PerformConversion(NS); }
        //public double ToPicoseconds() { return PerformConversion(PS); }
        //public double ToSeconds() { return PerformConversion(S); }
        //public double ToWeeks() { return PerformConversion(WK); }
        //public double ToYears() { return PerformConversion(Y); }
        #endregion
    }


}