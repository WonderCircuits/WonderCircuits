using System;

namespace WonderCircuits.UnitOf
{
    public class TorqueConverter : BaseNumberConverter
    {
        private static readonly double DYNCM = 9.80665e7;        //Dyne Centimeter
        private static readonly double DYNM = 9.80665e5;         //Dyne Meter
        private static readonly double DYNMM = 9.80665e8;        //Dyne Millimeter
        private static readonly double GFCM = 1e5;               //Gram ForceConverter Centimeter
        private static readonly double GFM = 1e3;                //Gram ForceConverter Meter
        private static readonly double GFMM = 1e6;               //Gram ForceConverter Millimeter
        private static readonly double KGFCM = 1e2;              //Kilogram ForceConverter Centimeter
        private static readonly double KGFM = 1;                 //Kilogram ForceConverter Meter
        private static readonly double KGFMM = 1e3;              //Kilogram ForceConverter Millimeter
        private static readonly double KNM = 9.80665e-3;         //Kilonewton Meter
        private static readonly double NCM = 9.80665e2;          //Newton Centimeter
        private static readonly double NM = 9.80665;             //Newton Meter
        private static readonly double NMM = 9.80665e3;          //Newton Millimeter
        private static readonly double OZFFT = 115.7282185748;   //Ounce ForceConverter Foot
        private static readonly double OZFIN = 1388.738622898;   //Ounce ForceConverter Inch
        private static readonly double LBFFT = 7.23301357557;    //Pound ForceConverter Foot
        private static readonly double LBFIN = 86.79616290684;   //Pound ForceConverter Inch
        public TorqueConverter()
        {

        }
        public TorqueConverter(double value, TorqueUnits units) : base(BuildFromContext(value, units))
        {

        }

        public TorqueConverter From(double value, TorqueUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(TorqueUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(TorqueUnits units)
        {
            switch (units)
            {
                case TorqueUnits.DyneCentimeters: { return (DYNCM); }
                case TorqueUnits.DyneMeters: { return (DYNM); }
                case TorqueUnits.DyneMillimeters: { return (DYNMM); }
                case TorqueUnits.GramCentimeters: { return (GFCM); }
                case TorqueUnits.GramMeters: { return (GFM); }
                case TorqueUnits.GramMillimeters: { return (GFMM); }
                case TorqueUnits.KilogramCentimeters: { return (KGFCM); }
                case TorqueUnits.KilogramMeters: { return (KGFM); }
                case TorqueUnits.KilogramMillimeters: { return (KGFMM); }
                case TorqueUnits.KilonewtonMeters: { return (KNM); }
                case TorqueUnits.NewtonCentimeters: { return (NCM); }
                case TorqueUnits.NewtonMeters: { return (NM); }
                case TorqueUnits.NewtonMillimeters: { return (NMM); }
                case TorqueUnits.OunceFeet: { return (OZFFT); }
                case TorqueUnits.OunceInches: { return (OZFIN); }
                case TorqueUnits.PoundFeet: { return (LBFFT); }
                case TorqueUnits.PoundInches: { return (LBFIN); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, TorqueUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class TorqueConverterExtensions
    {
        #region From & To Methods
        //public TorqueConverter FromDyneCentimeters(double v) { return StoreFromContext(this, v, DYNCM, "DYNCM"); }
        //public TorqueConverter FromDyneMeters(double v) { return StoreFromContext(this, v, DYNM, "DYNM"); }
        //public TorqueConverter FromDyneMillimeters(double v) { return StoreFromContext(this, v, DYNMM, "DYNMM"); }
        //public TorqueConverter FromGramCentimeters(double v) { return StoreFromContext(this, v, GFCM, "GFCM"); }
        //public TorqueConverter FromGramMeters(double v) { return StoreFromContext(this, v, GFM, "GFM"); }
        //public TorqueConverter FromGramMillimeters(double v) { return StoreFromContext(this, v, GFMM, "GFMM"); }
        //public TorqueConverter FromKilogramCentimeters(double v) { return StoreFromContext(this, v, KGFCM, "KGFCM"); }
        //public TorqueConverter FromKilogramMeters(double v) { return StoreFromContext(this, v, KGFM, "KGFM"); }
        //public TorqueConverter FromKilogramMillimeters(double v) { return StoreFromContext(this, v, KGFMM, "KGFMM"); }
        //public TorqueConverter FromKilonewtonMeters(double v) { return StoreFromContext(this, v, KNM, "KNM"); }
        //public TorqueConverter FromNewtonCentimeters(double v) { return StoreFromContext(this, v, NCM, "NCM"); }
        //public TorqueConverter FromNewtonMeters(double v) { return StoreFromContext(this, v, NM, "NM"); }
        //public TorqueConverter FromNewtonMillimeters(double v) { return StoreFromContext(this, v, NMM, "NMM"); }
        //public TorqueConverter FromOunceFeet(double v) { return StoreFromContext(this, v, OZFFT, "OZFFT"); }
        //public TorqueConverter FromOunceInches(double v) { return StoreFromContext(this, v, OZFIN, "OZFIN"); }
        //public TorqueConverter FromPoundFeet(double v) { return StoreFromContext(this, v, LBFFT, "LBFFT"); }
        //public TorqueConverter FromPoundInches(double v) { return StoreFromContext(this, v, LBFIN, "LBFIN"); }


        //public double ToDyneCentimeters() { return PerformConversion(DYNCM); }
        //public double ToDyneMeters() { return PerformConversion(DYNM); }
        //public double ToDyneMillimeters() { return PerformConversion(DYNMM); }
        //public double ToGramCentimeters() { return PerformConversion(GFCM); }
        //public double ToGramMeters() { return PerformConversion(GFM); }
        //public double ToGramMillimeters() { return PerformConversion(GFMM); }
        //public double ToKilogramCentimeters() { return PerformConversion(KGFCM); }
        //public double ToKilogramMeters() { return PerformConversion(KGFM); }
        //public double ToKilogramMillimeters() { return PerformConversion(KGFMM); }
        //public double ToKilonewtonMeters() { return PerformConversion(KNM); }
        //public double ToNewtonCentimeters() { return PerformConversion(NCM); }
        //public double ToNewtonMeters() { return PerformConversion(NM); }
        //public double ToNewtonMillimeters() { return PerformConversion(NMM); }
        //public double ToOunceFeet() { return PerformConversion(OZFFT); }
        //public double ToOunceInches() { return PerformConversion(OZFIN); }
        //public double ToPoundFeet() { return PerformConversion(LBFFT); }
        //public double ToPoundInches() { return PerformConversion(LBFIN); }
        #endregion
    }



}