using System;

namespace WonderCircuits.UnitOf
{
    public class AngleConverter : BaseNumberConverter
    {
        private static readonly double C = 1 / 360.0;          //Circle
        private static readonly double D = 1;                //Degree
        private static readonly double G = 1 / 0.9;            //Gradian
        private static readonly double MIL = 1 / 0.05625;    //Angular Mil
        private static readonly double M = 60;               //Minute 
        private static readonly double Q = 1 / 90.0;           //Quadrant
        private static readonly double RAD = Math.PI / 180.0;  //Radian
        private static readonly double R = 1 / 360.0;          //Revolution
        private static readonly double RA = 1 / 90.0;          //Right AngleConverter
        private static readonly double S = 3600;             //Second 
        private static readonly double SE = 1 / 60.0;          //Sextant
        private static readonly double SI = 1 / 30.0;        //Sign
        private static readonly double T = 1 / 360.0;          //Turn
        public AngleConverter()
        {

        }
        public AngleConverter(double value, AngleUnits units) : base(BuildFromContext(value, units))
        {

        }

        public AngleConverter From(double value, AngleUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(AngleUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(AngleUnits units)
        {
            switch (units)
            {
                case AngleUnits.Circles: { return (C); }
                case AngleUnits.Degrees: { return (D); }
                case AngleUnits.Gradians: { return (G); }
                case AngleUnits.Mils: { return (MIL); }
                case AngleUnits.Minutes: { return (M); }
                case AngleUnits.Quadrants: { return (Q); }
                case AngleUnits.Radians: { return (RAD); }
                case AngleUnits.Revolutions: { return (R); }
                case AngleUnits.RightAngles: { return (RA); }
                case AngleUnits.Seconds: { return (S); }
                case AngleUnits.Sextants: { return (SE); }
                case AngleUnits.Signs: { return (SI); }
                case AngleUnits.Turns: { return (T); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, AngleUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }

    }

    public static class AngleConverterExtensions
    {
        #region From & To Methods
        //public AngleConverter FromCircles(double v) { return StoreFromContext(this, v, C, "C"); }
        //public AngleConverter FromDegrees(double v) { return StoreFromContext(this, v, D, "D"); }
        //public AngleConverter FromGradians(double v) { return StoreFromContext(this, v, G, "G"); }
        //public AngleConverter FromMils(double v) { return StoreFromContext(this, v, MIL, "MIL"); }
        //public AngleConverter FromMinutes(double v) { return StoreFromContext(this, v, M, "M"); }
        //public AngleConverter FromQuadrants(double v) { return StoreFromContext(this, v, Q, "Q"); }
        //public AngleConverter FromRadians(double v) { return StoreFromContext(this, v, RAD, "RAD"); }
        //public AngleConverter FromRevolutions(double v) { return StoreFromContext(this, v, R, "R"); }
        //public AngleConverter FromRightAngles(double v) { return StoreFromContext(this, v, RA, "RA"); }
        //public AngleConverter FromSeconds(double v) { return StoreFromContext(this, v, S, "S"); }
        //public AngleConverter FromSextants(double v) { return StoreFromContext(this, v, SE, "SE"); }
        //public AngleConverter FromSigns(double v) { return StoreFromContext(this, v, SI, "SI"); }
        //public AngleConverter FromTurns(double v) { return StoreFromContext(this, v, T, "T"); }

        //public double ToCircles() { return PerformConversion(C); }
        //public double ToDegrees() { return PerformConversion(D); }
        //public double ToGradians() { return PerformConversion(G); }
        //public double ToMils() { return PerformConversion(MIL); }
        //public double ToMinutes() { return PerformConversion(M); }
        //public double ToQuadrants() { return PerformConversion(Q); }
        //public double ToRadians() { return PerformConversion(RAD); }
        //public double ToRevolutions() { return PerformConversion(R); }
        //public double ToRightAngles() { return PerformConversion(RA); }
        //public double ToSeconds() { return PerformConversion(S); }
        //public double ToSextants() { return PerformConversion(SE); }
        //public double ToSigns() { return PerformConversion(SI); }
        //public double ToTurns() { return PerformConversion(T); }

        #endregion
    }


}