using System;

namespace WonderCircuits.UnitOf
{
    public class AccelerationConverter : BaseNumberConverter
    {
        private static readonly double AS = 1e-18;           //Attometer per Second Squared
        private static readonly double CS = 1e-2;            //Centimeter per Second Squared
        private static readonly double DS = 1e-1;            //Decimeter per Second Squared
        private static readonly double DAS = 1e1;            //Dekameter per Second Squared
        private static readonly double ES = 1e18;            //Exameter per Second Squared
        private static readonly double FTHS = 0.000084666666666667;//Foot per Hour per Second
        private static readonly double FTMS = 0.00508;       //Foot/Minute per Second
        private static readonly double FTS = 0.3048;         //Foot per Second Squared
        private static readonly double FS = 1e-15;           //Femtometer per Second Squared
        private static readonly double GAL = 1 / 1e2;          //Galileo
        private static readonly double GS = 1e9;             //Gigameter per Second Squared
        private static readonly double G = 9.80665;          //Gravity
        private static readonly double HS = 1e2;             //Hectometer per Second Squared
        private static readonly double INMS = 0.0004233333;  //Inch per Minute per Second
        private static readonly double INS = 0.0254;         //Inch per Second Squared
        private static readonly double KHS = 1 / 3.6;          //Kilometers per Hour per Second
        private static readonly double KH = 1 / 12960.0;       //Kilometers per Hour Squared
        private static readonly double KS = 1e3;             //Kilometer per Second Squared
        private static readonly double KNS = 0.514444444444; //Knot per Second
        private static readonly double MGS = 1e6;            //Megameter per Second Squared
        private static readonly double MS = 1;               //Meter per Second Squared
        private static readonly double MUGAL = 1 / 1e8;        //Microgalileo
        private static readonly double MUS = 1e-6;           //Micrometerper Second Squared
        private static readonly double MIHS = 0.44704;       //Mile per Hour per Second
        private static readonly double MIMS = 26.8224;       //Mile per Minute per Second
        private static readonly double MIS = 1609.344;       //Mile per Second Squared
        private static readonly double MILGAL = 1 / 1e5;       //Milligalileo
        private static readonly double MILS = 1e-3;          //Millimeter per Second Squared
        private static readonly double NS = 1e-9;            //Nanometer per Second Squared
        private static readonly double PES = 1e15;           //Petameter per Second Squared
        private static readonly double PS = 1e-12;           //Picometer per Second Squared
        private static readonly double TS = 1e12;            //Terameter per Second Squared
        private static readonly double YDS = 0.9144;         //Yard per Second Squared
        public AccelerationConverter()
        {

        }
        public AccelerationConverter(double value, AccelerationUnits units) : base(BuildFromContext(value, units))
        {


        }

        public AccelerationConverter From(double value, AccelerationUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(AccelerationUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, false);
        }

        private static double GetBaseConstant(AccelerationUnits units)
        {
            switch (units)
            {
                case AccelerationUnits.AttometersPerSecondSquared: { return (AS); }
                case AccelerationUnits.CentimeterPerSecondSquared: { return (CS); }
                case AccelerationUnits.DecimetersPerSecondSquared: { return (DS); }
                case AccelerationUnits.DekametersPerSecondSquared: { return (DAS); }
                case AccelerationUnits.ExametersPerSecondSquared: { return (ES); }
                case AccelerationUnits.FeetPerHourPerSecond: { return (FTHS); }
                case AccelerationUnits.FeetPerMinutePerSecond: { return (FTMS); }
                case AccelerationUnits.FeetPerSecondSquared: { return (FTS); }
                case AccelerationUnits.FemtometersPerSecondSquared: { return (FS); }
                case AccelerationUnits.Galileos: { return (GAL); }
                case AccelerationUnits.GigametersPerSecondSquared: { return (GS); }
                case AccelerationUnits.Gravity: { return (G); }
                case AccelerationUnits.HectometersPerSecondSquared: { return (HS); }
                case AccelerationUnits.InchesPerMinutePerSecond: { return (INMS); }
                case AccelerationUnits.InchesPerSecondSquared: { return (INS); }
                case AccelerationUnits.KilometersPerHourPerSecond: { return (KHS); }
                case AccelerationUnits.KilometersPerHourSquared: { return (KH); }
                case AccelerationUnits.KilometersPerSecondSquared: { return (KS); }
                case AccelerationUnits.KnotsPerSecond: { return (KNS); }
                case AccelerationUnits.MegametersPerSecondSquared: { return (MGS); }
                case AccelerationUnits.MetersPerSecondSquared: { return (MS); }
                case AccelerationUnits.Microgalileos: { return (MUGAL); }
                case AccelerationUnits.MicrometersPerSecondSquared: { return (MUS); }
                case AccelerationUnits.MilesPerHourPerSecond: { return (MIHS); }
                case AccelerationUnits.MilesPerMinutePerSecond: { return (MIMS); }
                case AccelerationUnits.MilesPerSecondSquared: { return (MIS); }
                case AccelerationUnits.Milligalileos: { return (MILGAL); }
                case AccelerationUnits.MillimetersPerSecondSquared: { return (MILS); }
                case AccelerationUnits.NanometersPerSecondSquared: { return (NS); }
                case AccelerationUnits.PetametersPerSecondSquared: { return (PES); }
                case AccelerationUnits.PicometersPerSecondSquared: { return (PS); }
                case AccelerationUnits.TerametersPerSecondSquared: { return (TS); }
                case AccelerationUnits.YardsPerSecondSquared: { return (YDS); }
                default: { return 0; }

            }
        }
        private static NumberConverterContext BuildFromContext(double value, AccelerationUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class AccelerationConverterExtensions
    {
        #region From & To Methods
        //public AccelerationConverter FromAttometersPerSecondSquared(double v) { return StoreFromContext(this, v, AS, "AS"); }
        //public AccelerationConverter FromCentimeterPerSecondSquared(double v) { return StoreFromContext(this, v, CS, "CS"); }
        //public AccelerationConverter FromDecimetersPerSecondSquared(double v) { return StoreFromContext(this, v, DS, "DS"); }
        //public AccelerationConverter FromDekametersPerSecondSquared(double v) { return StoreFromContext(this, v, DAS, "DAS"); }
        //public AccelerationConverter FromExametersPerSecondSquared(double v) { return StoreFromContext(this, v, ES, "ES"); }
        //public AccelerationConverter FromFeetPerHourPerSecond(double v) { return StoreFromContext(this, v, FTHS, "FTHS"); }
        //public AccelerationConverter FromFeetPerMinutePerSecond(double v) { return StoreFromContext(this, v, FTMS, "FTMS"); }
        //public AccelerationConverter FromFeetPerSecondSquared(double v) { return StoreFromContext(this, v, FTS, "FTS"); }
        //public AccelerationConverter FromFemtometersPerSecondSquared(double v) { return StoreFromContext(this, v, FS, "FS"); }
        //public AccelerationConverter FromGalileos(double v) { return StoreFromContext(this, v, GAL, "GAL"); }
        //public AccelerationConverter FromGigametersPerSecondSquared(double v) { return StoreFromContext(this, v, GS, "GS"); }
        //public AccelerationConverter FromGravity(double v) { return StoreFromContext(this, v, G, "G"); }
        //public AccelerationConverter FromHectometersPerSecondSquared(double v) { return StoreFromContext(this, v, HS, "HS"); }
        //public AccelerationConverter FromInchesPerMinutePerSecond(double v) { return StoreFromContext(this, v, INMS, "INMS"); }
        //public AccelerationConverter FromInchesPerSecondSquared(double v) { return StoreFromContext(this, v, INS, "INS"); }
        //public AccelerationConverter FromKilometersPerHourPerSecond(double v) { return StoreFromContext(this, v, KHS, "KHS"); }
        //public AccelerationConverter FromKilometersPerHourSquared(double v) { return StoreFromContext(this, v, KH, "KH"); }
        //public AccelerationConverter FromKilometersPerSecondSquared(double v) { return StoreFromContext(this, v, KS, "KS"); }
        //public AccelerationConverter FromKnotsPerSecond(double v) { return StoreFromContext(this, v, KNS, "KNS"); }
        //public AccelerationConverter FromMegametersPerSecondSquared(double v) { return StoreFromContext(this, v, MGS, "MGS"); }
        //public AccelerationConverter FromMetersPerSecondSquared(double v) { return StoreFromContext(this, v, MS, "MS"); }
        //public AccelerationConverter FromMicrogalileos(double v) { return StoreFromContext(this, v, MUGAL, "MUGAL"); }
        //public AccelerationConverter FromMicrometersPerSecondSquared(double v) { return StoreFromContext(this, v, MUS, "MUS"); }
        //public AccelerationConverter FromMilesPerHourPerSecond(double v) { return StoreFromContext(this, v, MIHS, "MIHS"); }
        //public AccelerationConverter FromMilesPerMinutePerSecond(double v) { return StoreFromContext(this, v, MIMS, "MIMS"); }
        //public AccelerationConverter FromMilesPerSecondSquared(double v) { return StoreFromContext(this, v, MIS, "MIS"); }
        //public AccelerationConverter FromMilligalileos(double v) { return StoreFromContext(this, v, MILGAL, "MILGAL"); }
        //public AccelerationConverter FromMillimetersPerSecondSquared(double v) { return StoreFromContext(this, v, MILS, "MILS"); }
        //public AccelerationConverter FromNanometersPerSecondSquared(double v) { return StoreFromContext(this, v, NS, "NS"); }
        //public AccelerationConverter FromPetametersPerSecondSquared(double v) { return StoreFromContext(this, v, PES, "PES"); }
        //public AccelerationConverter FromPicometersPerSecondSquared(double v) { return StoreFromContext(this, v, PS, "PS"); }
        //public AccelerationConverter FromTerametersPerSecondSquared(double v) { return StoreFromContext(this, v, TS, "TS"); }
        //public AccelerationConverter FromYardsPerSecondSquared(double v) { return StoreFromContext(this, v, YDS, "YDS"); }

        //public double ToAttometersPerSecondSquared() { return PerformConversion(AS); }
        //public double ToCentimeterPerSecondSquared() { return PerformConversion(CS); }
        //public double ToDecimetersPerSecondSquared() { return PerformConversion(DS); }
        //public double ToDekametersPerSecondSquared() { return PerformConversion(DAS); }
        //public double ToExametersPerSecondSquared() { return PerformConversion(ES); }
        //public double ToFeetPerHourPerSecond() { return PerformConversion(FTHS); }
        //public double ToFeetPerMinutePerSecond() { return PerformConversion(FTMS); }
        //public double ToFeetPerSecondSquared() { return PerformConversion(FTS); }
        //public double ToFemtometersPerSecondSquared() { return PerformConversion(FS); }
        //public double ToGalileos() { return PerformConversion(GAL); }
        //public double ToGigametersPerSecondSquared() { return PerformConversion(GS); }
        //public double ToGravity() { return PerformConversion(G); }
        //public double ToHectometersPerSecondSquared() { return PerformConversion(HS); }
        //public double ToInchesPerMinutePerSecond() { return PerformConversion(INMS); }
        //public double ToInchesPerSecondSquared() { return PerformConversion(INS); }
        //public double ToKilometersPerHourPerSecond() { return PerformConversion(KHS); }
        //public double ToKilometersPerHourSquared() { return PerformConversion(KH); }
        //public double ToKilometersPerSecondSquared() { return PerformConversion(KS); }
        //public double ToKnotsPerSecond() { return PerformConversion(KNS); }
        //public double ToMegametersPerSecondSquared() { return PerformConversion(MGS); }
        //public double ToMetersPerSecondSquared() { return PerformConversion(MS); }
        //public double ToMicrogalileos() { return PerformConversion(MUGAL); }
        //public double ToMicrometersPerSecondSquared() { return PerformConversion(MUS); }
        //public double ToMilesPerHourPerSecond() { return PerformConversion(MIHS); }
        //public double ToMilesPerMinutePerSecond() { return PerformConversion(MIMS); }
        //public double ToMilesPerSecondSquared() { return PerformConversion(MIS); }
        //public double ToMilligalileos() { return PerformConversion(MILGAL); }
        //public double ToMillimetersPerSecondSquared() { return PerformConversion(MILS); }
        //public double ToNanometersPerSecondSquared() { return PerformConversion(NS); }
        //public double ToPetametersPerSecondSquared() { return PerformConversion(PES); }
        //public double ToPicometersPerSecondSquared() { return PerformConversion(PS); }
        //public double ToTerametersPerSecondSquared() { return PerformConversion(TS); }
        //public double ToYardsPerSecondSquared() { return PerformConversion(YDS); }
        #endregion
    }


}