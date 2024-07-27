using System;

namespace WonderCircuits.UnitOf
{
    public class FuelEconomyConverter : BaseNumberConverter
    {
        private static readonly double CML = 1e5;                //Centimeter per Liter
        private static readonly double DAML = 1e2;               //Dekameter per Liter
        private static readonly double EML = 1e-15;              //Exameter per Liter
        private static readonly double GML = 1e-6;               //Gigameter per Liter
        private static readonly double HML = 1e1;                //Hectometer per Liter
        private static readonly double KMGALUK = 4.546099293921; //Kilometer per Gallon (UK)
        private static readonly double KMGALUS = 3.7854117834;   //Kilometer per Gallon (US)
        private static readonly double KML = 1;                  //Kilometer per Liter
        private static readonly double MML = 1e-3;               //Megameter per Liter
        private static readonly double MCM = 1;                  //Meter per Cubic Centimeter
        private static readonly double MFT = 28316.84659319;     //Meter per Cubic Foot
        private static readonly double MIN = 16.38706400127;     //Meter per Cubic Inch
        private static readonly double MM = 1e6;                 //Meter per Cubic Meter
        private static readonly double MYD = 764554.8581679;     //Meter per Cubic Yard
        private static readonly double MCUPUK = 284.1312059185;  //Meter per Cup (UK)
        private static readonly double MCUPUS = 236.5882364849;  //Meter per Cup (US)
        private static readonly double MFOZUK = 28.41312059185;  //Meter per Fluid Ounce (UK)
        private static readonly double MFOZUS = 29.57352956411;  //Meter per Fluid Ounce (US)
        private static readonly double MGALUK = 4546.099293921;  //Meter per Gallon (UK)
        private static readonly double MGALUS = 3785.4117834;    //Meter per Gallon (US)
        private static readonly double ML = 1e3;                 //Meter per Liter
        private static readonly double MPTUK = 568.2624116755;   //Meter per Pint (UK)
        private static readonly double MPTUS = 473.1764729698;   //Meter per Pint (US)
        private static readonly double MQTUK = 1136.524822963;   //Meter per Quart (UK)
        private static readonly double MQTUS = 946.3529463874;   //Meter per Quart (US)
        private static readonly double MIGALUK = 2.824809362797; //Mile per Gallon (UK)
        private static readonly double MIGALUS = 2.352145832948; //Mile per Gallon (US)
        private static readonly double MIL = 1 / 1.609344;         //Mile per Liter (US)
        private static readonly double NMIGAL = 1 / 0.4895755247;  //Nautical Mile per Gallon (US)   
        private static readonly double NMIL = 1 / 1.85324496;      //Nautical Mile per Liter
        private static readonly double PML = 1e-12;              //Petameter per Liter
        private static readonly double TML = 1e-9;               //Terameter per Liter   
        public FuelEconomyConverter()
        {

        }
        public FuelEconomyConverter(double value, FuelEconomyUnits units) : base(BuildFromContext(value, units))
        {

        }

        public FuelEconomyConverter From(double value, FuelEconomyUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(FuelEconomyUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(FuelEconomyUnits units)
        {
            switch (units)
            {
                case FuelEconomyUnits.CentimetersPerLiter: { return (CML); }
                case FuelEconomyUnits.DekametersPerLiter: { return (DAML); }
                case FuelEconomyUnits.ExametersPerLiter: { return (EML); }
                case FuelEconomyUnits.GigametersPerLiter: { return (GML); }
                case FuelEconomyUnits.HectometersPerLiter: { return (HML); }
                case FuelEconomyUnits.KilometersPerGallonUK: { return (KMGALUK); }
                case FuelEconomyUnits.KilometersPerGallonUS: { return (KMGALUS); }
                case FuelEconomyUnits.KilometersPerLiter: { return (KML); }
                case FuelEconomyUnits.MegametersPerLiter: { return (MML); }
                case FuelEconomyUnits.MetersPerCubicCentimeter: { return (MCM); }
                case FuelEconomyUnits.MetersPerCubicFoot: { return (MFT); }
                case FuelEconomyUnits.MetersPerCubicInch: { return (MIN); }
                case FuelEconomyUnits.MetersPerCubicMeter: { return (MM); }
                case FuelEconomyUnits.MetersPerCubicYard: { return (MYD); }
                case FuelEconomyUnits.MetersPerCupUK: { return (MCUPUK); }
                case FuelEconomyUnits.MetersPerCupUS: { return (MCUPUS); }
                case FuelEconomyUnits.MetersPerFluidOunceUK: { return (MFOZUK); }
                case FuelEconomyUnits.MetersPerFluidOunceUS: { return (MFOZUS); }
                case FuelEconomyUnits.MetersPerGallonUK: { return (MGALUK); }
                case FuelEconomyUnits.MetersPerGallonUS: { return (MGALUS); }
                case FuelEconomyUnits.MetersPerLiter: { return (ML); }
                case FuelEconomyUnits.MetersPerPintUK: { return (MPTUK); }
                case FuelEconomyUnits.MetersPerPintUS: { return (MPTUS); }
                case FuelEconomyUnits.MetersPerQuartUK: { return (MQTUK); }
                case FuelEconomyUnits.MetersPerQuartUS: { return (MQTUS); }
                case FuelEconomyUnits.MilesPerGallonUK: { return (MIGALUK); }
                case FuelEconomyUnits.MilesPerGallonUS: { return (MIGALUS); }
                case FuelEconomyUnits.MilesPerLiterUS: { return (MIL); }
                case FuelEconomyUnits.NauticalMilesPerGallonUS: { return (NMIGAL); }
                case FuelEconomyUnits.NauticalMilesPerLiter: { return (NMIL); }
                case FuelEconomyUnits.PetametersPerLiter: { return (PML); }
                case FuelEconomyUnits.TerametersPerLiter: { return (TML); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, FuelEconomyUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class FuelEconomyConverterExtensions
    {
        #region From & To Methods
        //public FuelEconomyConverter FromCentimetersPerLiter(double v) { return StoreFromContext(this, v, CML, "CML"); }
        //public FuelEconomyConverter FromDekametersPerLiter(double v) { return StoreFromContext(this, v, DAML, "DAML"); }
        //public FuelEconomyConverter FromExametersPerLiter(double v) { return StoreFromContext(this, v, EML, "EML"); }
        //public FuelEconomyConverter FromGigametersPerLiter(double v) { return StoreFromContext(this, v, GML, "GML"); }
        //public FuelEconomyConverter FromHectometersPerLiter(double v) { return StoreFromContext(this, v, HML, "HML"); }
        //public FuelEconomyConverter FromKilometersPerGallonUK(double v) { return StoreFromContext(this, v, KMGALUK, "KMGALUK"); }
        //public FuelEconomyConverter FromKilometersPerGallonUS(double v) { return StoreFromContext(this, v, KMGALUS, "KMGALUS"); }
        //public FuelEconomyConverter FromKilometersPerLiter(double v) { return StoreFromContext(this, v, KML, "KML"); }
        //public FuelEconomyConverter FromMegametersPerLiter(double v) { return StoreFromContext(this, v, MML, "MML"); }
        //public FuelEconomyConverter FromMetersPerCubicCentimeter(double v) { return StoreFromContext(this, v, MCM, "MCM"); }
        //public FuelEconomyConverter FromMetersPerCubicFoot(double v) { return StoreFromContext(this, v, MFT, "MFT"); }
        //public FuelEconomyConverter FromMetersPerCubicInch(double v) { return StoreFromContext(this, v, MIN, "MIN"); }
        //public FuelEconomyConverter FromMetersPerCubicMeter(double v) { return StoreFromContext(this, v, MM, "MM"); }
        //public FuelEconomyConverter FromMetersPerCubicYard(double v) { return StoreFromContext(this, v, MYD, "MYD"); }
        //public FuelEconomyConverter FromMetersPerCupUK(double v) { return StoreFromContext(this, v, MCUPUK, "MCUPUK"); }
        //public FuelEconomyConverter FromMetersPerCupUS(double v) { return StoreFromContext(this, v, MCUPUS, "MCUPUS"); }
        //public FuelEconomyConverter FromMetersPerFluidOunceUK(double v) { return StoreFromContext(this, v, MFOZUK, "MFOZUK"); }
        //public FuelEconomyConverter FromMetersPerFluidOunceUS(double v) { return StoreFromContext(this, v, MFOZUS, "MFOZUS"); }
        //public FuelEconomyConverter FromMetersPerGallonUK(double v) { return StoreFromContext(this, v, MGALUK, "MGALUK"); }
        //public FuelEconomyConverter FromMetersPerGallonUS(double v) { return StoreFromContext(this, v, MGALUS, "MGALUS"); }
        //public FuelEconomyConverter FromMetersPerLiter(double v) { return StoreFromContext(this, v, ML, "ML"); }
        //public FuelEconomyConverter FromMetersPerPintUK(double v) { return StoreFromContext(this, v, MPTUK, "MPTUK"); }
        //public FuelEconomyConverter FromMetersPerPintUS(double v) { return StoreFromContext(this, v, MPTUS, "MPTUS"); }
        //public FuelEconomyConverter FromMetersPerQuartUK(double v) { return StoreFromContext(this, v, MQTUK, "MQTUK"); }
        //public FuelEconomyConverter FromMetersPerQuartUS(double v) { return StoreFromContext(this, v, MQTUS, "MQTUS"); }
        //public FuelEconomyConverter FromMilesPerGallonUK(double v) { return StoreFromContext(this, v, MIGALUK, "MIGALUK"); }
        //public FuelEconomyConverter FromMilesPerGallonUS(double v) { return StoreFromContext(this, v, MIGALUS, "MIGALUS"); }
        //public FuelEconomyConverter FromMilesPerLiterUS(double v) { return StoreFromContext(this, v, MIL, "MIL"); }
        //public FuelEconomyConverter FromNauticalMilesPerGallonUS(double v) { return StoreFromContext(this, v, NMIGAL, "NMIGAL"); }
        //public FuelEconomyConverter FromNauticalMilesPerLiter(double v) { return StoreFromContext(this, v, NMIL, "NMIL"); }
        //public FuelEconomyConverter FromPetametersPerLiter(double v) { return StoreFromContext(this, v, PML, "PML"); }
        //public FuelEconomyConverter FromTerametersPerLiter(double v) { return StoreFromContext(this, v, TML, "TML"); }


        //public double ToCentimetersPerLiter() { return PerformConversion(CML); }
        //public double ToDekametersPerLiter() { return PerformConversion(DAML); }
        //public double ToExametersPerLiter() { return PerformConversion(EML); }
        //public double ToGigametersPerLiter() { return PerformConversion(GML); }
        //public double ToHectometersPerLiter() { return PerformConversion(HML); }
        //public double ToKilometersPerGallonUK() { return PerformConversion(KMGALUK); }
        //public double ToKilometersPerGallonUS() { return PerformConversion(KMGALUS); }
        //public double ToKilometersPerLiter() { return PerformConversion(KML); }
        //public double ToMegametersPerLiter() { return PerformConversion(MML); }
        //public double ToMetersPerCubicCentimeter() { return PerformConversion(MCM); }
        //public double ToMetersPerCubicFoot() { return PerformConversion(MFT); }
        //public double ToMetersPerCubicInch() { return PerformConversion(MIN); }
        //public double ToMetersPerCubicMeter() { return PerformConversion(MM); }
        //public double ToMetersPerCubicYard() { return PerformConversion(MYD); }
        //public double ToMetersPerCupUK() { return PerformConversion(MCUPUK); }
        //public double ToMetersPerCupUS() { return PerformConversion(MCUPUS); }
        //public double ToMetersPerFluidOunceUK() { return PerformConversion(MFOZUK); }
        //public double ToMetersPerFluidOunceUS() { return PerformConversion(MFOZUS); }
        //public double ToMetersPerGallonUK() { return PerformConversion(MGALUK); }
        //public double ToMetersPerGallonUS() { return PerformConversion(MGALUS); }
        //public double ToMetersPerLiter() { return PerformConversion(ML); }
        //public double ToMetersPerPintUK() { return PerformConversion(MPTUK); }
        //public double ToMetersPerPintUS() { return PerformConversion(MPTUS); }
        //public double ToMetersPerQuartUK() { return PerformConversion(MQTUK); }
        //public double ToMetersPerQuartUS() { return PerformConversion(MQTUS); }
        //public double ToMilesPerGallonUK() { return PerformConversion(MIGALUK); }
        //public double ToMilesPerGallonUS() { return PerformConversion(MIGALUS); }
        //public double ToMilesPerLiterUS() { return PerformConversion(MIL); }
        //public double ToNauticalMilesPerGallonUS() { return PerformConversion(NMIGAL); }
        //public double ToNauticalMilesPerLiter() { return PerformConversion(NMIL); }
        //public double ToPetametersPerLiter() { return PerformConversion(PML); }
        //public double ToTerametersPerLiter() { return PerformConversion(TML); }
        #endregion
    }


}