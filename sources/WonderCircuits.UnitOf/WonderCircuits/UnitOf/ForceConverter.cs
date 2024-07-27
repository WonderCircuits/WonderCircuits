using System;

namespace WonderCircuits.UnitOf
{
    public class ForceConverter : BaseNumberConverter
    {
        private static readonly double AUF = 12137804.11081;         //Atomic Unit of ForceConverter
        private static readonly double AN = 1e18;                    //Attonewton
        private static readonly double CN = 1e2;                     //Centinewton
        private static readonly double DN = 1e1;                     //DeciNewton
        private static readonly double DAN = 1e-1;                   //Dekanewton  
        private static readonly double DYN = 1e5;                    //Dyne
        private static readonly double EN = 1e-18;                   //Exanewton
        private static readonly double FN = 1e15;                    //Femtonewton
        private static readonly double GN = 1e-9;                    //Giganewton
        private static readonly double GF = 1 / 9.80665e-3;            //Gram ForceConverter
        private static readonly double GFF = 1 / 9.80665;              //Grave ForceConverter
        private static readonly double HN = 1e-2;                    //Hectonewton 
        private static readonly double JCM = 1e2;                    //Joule per Centimeter 
        private static readonly double JM = 1;                       //Joule per Meter
        private static readonly double KGF = 1 / 9.80665;              //Kilogram force
        private static readonly double KN = 1e-3;                    //Kilonewton
        private static readonly double KP = 1 / 9.80665;               //Kilopond
        private static readonly double KIP = 1 / 4448.221615255;       //Kilopound ForceConverter
        private static readonly double LTF = 1 / 9964.01641818352;     //Long Ton ForceConverter
        private static readonly double MN = 1e-6;                    //Meganewton
        private static readonly double TFM = 1 / 9806.65;              //Ton ForceConverter (Metric)
        private static readonly double MUN = 1e6;                    //Micronewton
        private static readonly double MGF = 1 / 9.80665e-3;           //Milligrave ForceConverter
        private static readonly double MILN = 1e3;                   //Millinewton
        private static readonly double NN = 1e9;                     //Nanonewton
        private static readonly double N = 1;                        //Newton
        private static readonly double OZF = 1 / 0.27801385095378125;  //Ounce ForceConverter
        private static readonly double PEN = 1e-15;                  //Petanewton
        private static readonly double PN = 1e12;                    //Piconewton
        private static readonly double P = 1 / 9.80665e-3;             //Pond
        private static readonly double LBFT = 1 / 0.138254954376;      //Pound Foot per Second Squared
        private static readonly double LBF = 1 / 4.4482216152605;      //Pound ForceConverter
        private static readonly double PDL = 1 / 0.138254954376;       //Poundal
        private static readonly double TFS = 1 / 8896.443230521;       //Ton ForceConverter (Short)
        private static readonly double SN = 1 / 1e3;                   //Sthene
        private static readonly double TN = 1e-12;                   //Teranewton   
        public ForceConverter()
        {

        }
        public ForceConverter(double value, ForceUnits units) : base(BuildFromContext(value, units))
        {

        }

        public ForceConverter From(double value, ForceUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(ForceUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(ForceUnits units)
        {
            switch (units)
            {
                case ForceUnits.AtomicUnitsOfForce: { return (AUF); }
                case ForceUnits.Attonewtons: { return (AN); }
                case ForceUnits.Centinewtons: { return (CN); }
                case ForceUnits.Decinewtons: { return (DN); }
                case ForceUnits.Dekanewtons: { return (DAN); }
                case ForceUnits.Dynes: { return (DYN); }
                case ForceUnits.Exanewtons: { return (EN); }
                case ForceUnits.Femtonewtons: { return (FN); }
                case ForceUnits.Giganewtons: { return (GN); }
                case ForceUnits.GramForces: { return (GF); }
                case ForceUnits.GraveForces: { return (GFF); }
                case ForceUnits.Hectonewtons: { return (HN); }
                case ForceUnits.JouleCentimeters: { return (JCM); }
                case ForceUnits.JouleMeters: { return (JM); }
                case ForceUnits.KilogramForces: { return (KGF); }
                case ForceUnits.Kilonewtons: { return (KN); }
                case ForceUnits.Kiloponds: { return (KP); }
                case ForceUnits.KilopoundForces: { return (KIP); }
                case ForceUnits.LongTonForces: { return (LTF); }
                case ForceUnits.Meganewtons: { return (MN); }
                case ForceUnits.MetricTonForces: { return (TFM); }
                case ForceUnits.Micronewtons: { return (MUN); }
                case ForceUnits.MilligraveForces: { return (MGF); }
                case ForceUnits.Millinewtons: { return (MILN); }
                case ForceUnits.Nanonewtons: { return (NN); }
                case ForceUnits.Newtons: { return (N); }
                case ForceUnits.OunceForces: { return (OZF); }
                case ForceUnits.Petanewtons: { return (PEN); }
                case ForceUnits.Piconewtons: { return (PN); }
                case ForceUnits.Ponds: { return (P); }
                case ForceUnits.PoundFeetPerSecondSquared: { return (LBFT); }
                case ForceUnits.PoundForces: { return (LBF); }
                case ForceUnits.Poundals: { return (PDL); }
                case ForceUnits.ShortTonForces: { return (TFS); }
                case ForceUnits.Sthenes: { return (SN); }
                case ForceUnits.Teranewtons: { return (TN); }

                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, ForceUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class ForceConverterExtensions
    {
        #region From & To Methods
        //public ForceConverter FromAtomicUnitsOfForce(double v) { return StoreFromContext(this, v, AUF, "AUF"); }
        //public ForceConverter FromAttonewtons(double v) { return StoreFromContext(this, v, AN, "AN"); }
        //public ForceConverter FromCentinewtons(double v) { return StoreFromContext(this, v, CN, "CN"); }
        //public ForceConverter FromDecinewtons(double v) { return StoreFromContext(this, v, DN, "DN"); }
        //public ForceConverter FromDekanewtons(double v) { return StoreFromContext(this, v, DAN, "DAN"); }
        //public ForceConverter FromDynes(double v) { return StoreFromContext(this, v, DYN, "DYN"); }
        //public ForceConverter FromExanewtons(double v) { return StoreFromContext(this, v, EN, "EN"); }
        //public ForceConverter FromFemtonewtons(double v) { return StoreFromContext(this, v, FN, "FN"); }
        //public ForceConverter FromGiganewtons(double v) { return StoreFromContext(this, v, GN, "GN"); }
        //public ForceConverter FromGramForces(double v) { return StoreFromContext(this, v, GF, "GF"); }
        //public ForceConverter FromGraveForces(double v) { return StoreFromContext(this, v, GFF, "GFF"); }
        //public ForceConverter FromHectonewtons(double v) { return StoreFromContext(this, v, HN, "HN"); }
        //public ForceConverter FromJouleCentimeters(double v) { return StoreFromContext(this, v, JCM, "JCM"); }
        //public ForceConverter FromJouleMeters(double v) { return StoreFromContext(this, v, JM, "JM"); }
        //public ForceConverter FromKilogramForces(double v) { return StoreFromContext(this, v, KGF, "KGF"); }
        //public ForceConverter FromKilonewtons(double v) { return StoreFromContext(this, v, KN, "KN"); }
        //public ForceConverter FromKiloponds(double v) { return StoreFromContext(this, v, KP, "KP"); }
        //public ForceConverter FromKilopoundForces(double v) { return StoreFromContext(this, v, KIP, "KIP"); }
        //public ForceConverter FromLongTonForces(double v) { return StoreFromContext(this, v, LTF, "LTF"); }
        //public ForceConverter FromMeganewtons(double v) { return StoreFromContext(this, v, MN, "MN"); }
        //public ForceConverter FromMetricTonForces(double v) { return StoreFromContext(this, v, TFM, "TFM"); }
        //public ForceConverter FromMicronewtons(double v) { return StoreFromContext(this, v, MUN, "MUN"); }
        //public ForceConverter FromMilligraveForces(double v) { return StoreFromContext(this, v, MGF, "MGF"); }
        //public ForceConverter FromMillinewtons(double v) { return StoreFromContext(this, v, MILN, "MILN"); }
        //public ForceConverter FromNanonewtons(double v) { return StoreFromContext(this, v, NN, "NN"); }
        //public ForceConverter FromNewtons(double v) { return StoreFromContext(this, v, N, "N"); }
        //public ForceConverter FromOunceForces(double v) { return StoreFromContext(this, v, OZF, "OZF"); }
        //public ForceConverter FromPetanewtons(double v) { return StoreFromContext(this, v, PEN, "PEN"); }
        //public ForceConverter FromPiconewtons(double v) { return StoreFromContext(this, v, PN, "PN"); }
        //public ForceConverter FromPonds(double v) { return StoreFromContext(this, v, P, "P"); }
        //public ForceConverter FromPoundFeetPerSecondSquared(double v) { return StoreFromContext(this, v, LBFT, "LBFT"); }
        //public ForceConverter FromPoundForces(double v) { return StoreFromContext(this, v, LBF, "LBF"); }
        //public ForceConverter FromPoundals(double v) { return StoreFromContext(this, v, PDL, "PDL"); }
        //public ForceConverter FromShortTonForces(double v) { return StoreFromContext(this, v, TFS, "TFS"); }
        //public ForceConverter FromSthenes(double v) { return StoreFromContext(this, v, SN, "SN"); }
        //public ForceConverter FromTeranewtons(double v) { return StoreFromContext(this, v, TN, "TN"); }

        //public double ToAtomicUnitsOfForce() { return PerformConversion(AUF); }
        //public double ToAttonewtons() { return PerformConversion(AN); }
        //public double ToCentinewtons() { return PerformConversion(CN); }
        //public double ToDecinewtons() { return PerformConversion(DN); }
        //public double ToDekanewtons() { return PerformConversion(DAN); }
        //public double ToDynes() { return PerformConversion(DYN); }
        //public double ToExanewtons() { return PerformConversion(EN); }
        //public double ToFemtonewtons() { return PerformConversion(FN); }
        //public double ToGiganewtons() { return PerformConversion(GN); }
        //public double ToGramForces() { return PerformConversion(GF); }
        //public double ToGraveForces() { return PerformConversion(GFF); }
        //public double ToHectonewtons() { return PerformConversion(HN); }
        //public double ToJouleCentimeters() { return PerformConversion(JCM); }
        //public double ToJouleMeters() { return PerformConversion(JM); }
        //public double ToKilogramForces() { return PerformConversion(KGF); }
        //public double ToKilonewtons() { return PerformConversion(KN); }
        //public double ToKiloponds() { return PerformConversion(KP); }
        //public double ToKilopoundForces() { return PerformConversion(KIP); }
        //public double ToLongTonForces() { return PerformConversion(LTF); }
        //public double ToMeganewtons() { return PerformConversion(MN); }
        //public double ToMetricTonForces() { return PerformConversion(TFM); }
        //public double ToMicronewtons() { return PerformConversion(MUN); }
        //public double ToMilligraveForces() { return PerformConversion(MGF); }
        //public double ToMillinewtons() { return PerformConversion(MILN); }
        //public double ToNanonewtons() { return PerformConversion(NN); }
        //public double ToNewtons() { return PerformConversion(N); }
        //public double ToOunceForces() { return PerformConversion(OZF); }
        //public double ToPetanewtons() { return PerformConversion(PEN); }
        //public double ToPiconewtons() { return PerformConversion(PN); }
        //public double ToPonds() { return PerformConversion(P); }
        //public double ToPoundFeetPerSecondSquared() { return PerformConversion(LBFT); }
        //public double ToPoundForces() { return PerformConversion(LBF); }
        //public double ToPoundals() { return PerformConversion(PDL); }
        //public double ToShortTonForces() { return PerformConversion(TFS); }
        //public double ToSthenes() { return PerformConversion(SN); }
        //public double ToTeranewtons() { return PerformConversion(TN); }

        #endregion
    }


}