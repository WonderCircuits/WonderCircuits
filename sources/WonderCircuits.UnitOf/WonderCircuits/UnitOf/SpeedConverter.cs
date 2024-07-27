using System;

namespace WonderCircuits.UnitOf
{
    public class SpeedConverter : BaseNumberConverter
    {
        private static readonly double CMH = 1 / 36e4;             //Centimeter per Hour
        private static readonly double CMM = 1 / 6e3;              //Centimeter per Minute
        private static readonly double CMS = 1 / 1e2;              //Centimeter per Second 
        private static readonly double EV = 29765;               //Earths Velocity
        private static readonly double FTH = 1 / 11811.02362205;   //Feet per Hour
        private static readonly double FTM = 0.00508;            //Feet per Minute
        private static readonly double FTS = 0.3048;             //Feet per Second
        private static readonly double CV1 = 7900;               //Cosmic Velocity First
        private static readonly double INH = 7.0555555555e-6;    //Inch per Hour
        private static readonly double INM = 4.2333333333e-4;    //Inch per Minute
        private static readonly double INS = 0.0254;             //Inch per Second
        private static readonly double KMH = 1 / 3.6;              //Kilometer per Hour
        private static readonly double KMM = 1 / 6e-2;             //Kilometer per Minute
        private static readonly double KMS = 1e3;                //Kilometer per Second
        private static readonly double KN = 1 / 1.943844492441;    //Knot
        private static readonly double C = 299792458;            //Light
        private static readonly double MA = 295.0464000003;      //Mach SI Standard
        private static readonly double MH = 1 / 36e2;              //Meters per Hour
        private static readonly double MM = 1 / 60.0;              //Meters per Minute
        private static readonly double MS = 1;                   //Meters per Second
        private static readonly double MIH = 0.44704;            //Miles per Hour
        private static readonly double MIM = 26.8224;            //Miles per Minute
        private static readonly double MIS = 1609.344;           //Miles per Second
        private static readonly double MMH = 1 / 36e5;             //Millimeter per Hour
        private static readonly double MMM = 1 / 6e4;              //Millimeter per Minute
        private static readonly double MMS = 1 / 1e3;              //Millimeter per Second   
        private static readonly double CV2 = 11200;              //Cosmic Velocity Second
        private static readonly double SA = 344;                 //SpeedConverter of Sound in Air
        private static readonly double SW = 1482.7;              //SpeedConverter of Sound in Water
        private static readonly double CV3 = 16670;              //Cosmic Velocity Third
        private static readonly double YH = 0.000254;            //Yard per Hour
        private static readonly double YM = 0.01524;             //Yard per Minute
        private static readonly double YS = 0.9144;              //Yard per Second

        public SpeedConverter()
        {

        }
        public SpeedConverter(double value, SpeedUnits units) : base(BuildFromContext(value, units))
        {

        }

        public SpeedConverter From(double value, SpeedUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(SpeedUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, false);
        }

        private static double GetBaseConstant(SpeedUnits units)
        {
            switch (units)
            {
                case SpeedUnits.CentimetersPerHour: { return (CMH); }
                case SpeedUnits.CentimetersPerMinute: { return (CMM); }
                case SpeedUnits.CentimetersPerSecond: { return (CMS); }
                case SpeedUnits.EarthsVelocity: { return (EV); }
                case SpeedUnits.FeetPerHour: { return (FTH); }
                case SpeedUnits.FeetPerMinute: { return (FTM); }
                case SpeedUnits.FeetPerSecond: { return (FTS); }
                case SpeedUnits.FirstCosmicVelocity: { return (CV1); }
                case SpeedUnits.InchesPerHour: { return (INH); }
                case SpeedUnits.InchesPerMinute: { return (INM); }
                case SpeedUnits.InchesPerSecond: { return (INS); }
                case SpeedUnits.KilometersPerHour: { return (KMH); }
                case SpeedUnits.KilometersPerMinute: { return (KMM); }
                case SpeedUnits.KilometersPerSecond: { return (KMS); }
                case SpeedUnits.Knots: { return (KN); }
                case SpeedUnits.Light: { return (C); }
                case SpeedUnits.Mach: { return (MA); }
                case SpeedUnits.MetersPerHour: { return (MH); }
                case SpeedUnits.MetersPerMinute: { return (MM); }
                case SpeedUnits.MetersPerSecond: { return (MS); }
                case SpeedUnits.MilesPerHour: { return (MIH); }
                case SpeedUnits.MilesPerMinute: { return (MIM); }
                case SpeedUnits.MilesPerSecond: { return (MIS); }
                case SpeedUnits.MillimetersPerHour: { return (MMH); }
                case SpeedUnits.MillimetersPerMinute: { return (MMM); }
                case SpeedUnits.MillimetersPerSecond: { return (MMS); }
                case SpeedUnits.SecondCosmicVelocity: { return (CV2); }
                case SpeedUnits.SoundsInAir: { return (SA); }
                case SpeedUnits.SoundsInWater: { return (SW); }
                case SpeedUnits.ThirdCosmicVelocity: { return (CV3); }
                case SpeedUnits.YardsPerHour: { return (YH); }
                case SpeedUnits.YardsPerMinute: { return (YM); }
                case SpeedUnits.YardsPerSecond: { return (YS); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, SpeedUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class SpeedConverterExtensions
    {
        #region From & To Methods
        //public SpeedConverter FromCentimetersPerHour(double v) { return StoreFromContext(this, v, CMH, "CMH"); }
        //public SpeedConverter FromCentimetersPerMinute(double v) { return StoreFromContext(this, v, CMM, "CMM"); }
        //public SpeedConverter FromCentimetersPerSecond(double v) { return StoreFromContext(this, v, CMS, "CMS"); }
        //public SpeedConverter FromEarthsVelocity(double v) { return StoreFromContext(this, v, EV, "EV"); }
        //public SpeedConverter FromFeetPerHour(double v) { return StoreFromContext(this, v, FTH, "FTH"); }
        //public SpeedConverter FromFeetPerMinute(double v) { return StoreFromContext(this, v, FTM, "FTM"); }
        //public SpeedConverter FromFeetPerSecond(double v) { return StoreFromContext(this, v, FTS, "FTS"); }
        //public SpeedConverter FromFirstCosmicVelocity(double v) { return StoreFromContext(this, v, CV1, "CV1"); }
        //public SpeedConverter FromInchesPerHour(double v) { return StoreFromContext(this, v, INH, "INH"); }
        //public SpeedConverter FromInchesPerMinute(double v) { return StoreFromContext(this, v, INM, "INM"); }
        //public SpeedConverter FromInchesPerSecond(double v) { return StoreFromContext(this, v, INS, "INS"); }
        //public SpeedConverter FromKilometersPerHour(double v) { return StoreFromContext(this, v, KMH, "KMH"); }
        //public SpeedConverter FromKilometersPerMinute(double v) { return StoreFromContext(this, v, KMM, "KMM"); }
        //public SpeedConverter FromKilometersPerSecond(double v) { return StoreFromContext(this, v, KMS, "KMS"); }
        //public SpeedConverter FromKnots(double v) { return StoreFromContext(this, v, KN, "KN"); }
        //public SpeedConverter FromLight(double v) { return StoreFromContext(this, v, C, "C"); }
        //public SpeedConverter FromMach(double v) { return StoreFromContext(this, v, MA, "MA"); }
        //public SpeedConverter FromMetersPerHour(double v) { return StoreFromContext(this, v, MH, "MH"); }
        //public SpeedConverter FromMetersPerMinute(double v) { return StoreFromContext(this, v, MM, "MM"); }
        //public SpeedConverter FromMetersPerSecond(double v) { return StoreFromContext(this, v, MS, "MS"); }
        //public SpeedConverter FromMilesPerHour(double v) { return StoreFromContext(this, v, MIH, "MIH"); }
        //public SpeedConverter FromMilesPerMinute(double v) { return StoreFromContext(this, v, MIM, "MIM"); }
        //public SpeedConverter FromMilesPerSecond(double v) { return StoreFromContext(this, v, MIS, "MIS"); }
        //public SpeedConverter FromMillimetersPerHour(double v) { return StoreFromContext(this, v, MMH, "MMH"); }
        //public SpeedConverter FromMillimetersPerMinute(double v) { return StoreFromContext(this, v, MMM, "MMM"); }
        //public SpeedConverter FromMillimetersPerSecond(double v) { return StoreFromContext(this, v, MMS, "MMS"); }
        //public SpeedConverter FromSecondCosmicVelocity(double v) { return StoreFromContext(this, v, CV2, "CV2"); }
        //public SpeedConverter FromSoundsInAir(double v) { return StoreFromContext(this, v, SA, "SA"); }
        //public SpeedConverter FromSoundsInWater(double v) { return StoreFromContext(this, v, SW, "SW"); }
        //public SpeedConverter FromThirdCosmicVelocity(double v) { return StoreFromContext(this, v, CV3, "CV3"); }
        //public SpeedConverter FromYardsPerHour(double v) { return StoreFromContext(this, v, YH, "YH"); }
        //public SpeedConverter FromYardsPerMinute(double v) { return StoreFromContext(this, v, YM, "YM"); }
        //public SpeedConverter FromYardsPerSecond(double v) { return StoreFromContext(this, v, YS, "YS"); }

        //public double ToCentimetersPerHour() { return PerformConversion(CMH); }
        //public double ToCentimetersPerMinute() { return PerformConversion(CMM); }
        //public double ToCentimetersPerSecond() { return PerformConversion(CMS); }
        //public double ToEarthsVelocity() { return PerformConversion(EV); }
        //public double ToFeetPerHour() { return PerformConversion(FTH); }
        //public double ToFeetPerMinute() { return PerformConversion(FTM); }
        //public double ToFeetPerSecond() { return PerformConversion(FTS); }
        //public double ToFirstCosmicVelocity() { return PerformConversion(CV1); }
        //public double ToInchesPerHour() { return PerformConversion(INH); }
        //public double ToInchesPerMinute() { return PerformConversion(INM); }
        //public double ToInchesPerSecond() { return PerformConversion(INS); }
        //public double ToKilometersPerHour() { return PerformConversion(KMH); }
        //public double ToKilometersPerMinute() { return PerformConversion(KMM); }
        //public double ToKilometersPerSecond() { return PerformConversion(KMS); }
        //public double ToKnots() { return PerformConversion(KN); }
        //public double ToLight() { return PerformConversion(C); }
        //public double ToMach() { return PerformConversion(MA); }
        //public double ToMetersPerHour() { return PerformConversion(MH); }
        //public double ToMetersPerMinute() { return PerformConversion(MM); }
        //public double ToMetersPerSecond() { return PerformConversion(MS); }
        //public double ToMilesPerHour() { return PerformConversion(MIH); }
        //public double ToMilesPerMinute() { return PerformConversion(MIM); }
        //public double ToMilesPerSecond() { return PerformConversion(MIS); }
        //public double ToMillimetersPerHour() { return PerformConversion(MMH); }
        //public double ToMillimetersPerMinute() { return PerformConversion(MMM); }
        //public double ToMillimetersPerSecond() { return PerformConversion(MMS); }
        //public double ToSecondCosmicVelocity() { return PerformConversion(CV2); }
        //public double ToSoundsInAir() { return PerformConversion(SA); }
        //public double ToSoundsInWater() { return PerformConversion(SW); }
        //public double ToThirdCosmicVelocity() { return PerformConversion(CV3); }
        //public double ToYardsPerHour() { return PerformConversion(YH); }
        //public double ToYardsPerMinute() { return PerformConversion(YM); }
        //public double ToYardsPerSecond() { return PerformConversion(YS); }
        #endregion
    }



}