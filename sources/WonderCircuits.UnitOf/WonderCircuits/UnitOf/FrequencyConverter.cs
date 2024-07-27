using System;

namespace WonderCircuits.UnitOf
{
    public class FrequencyConverter : BaseNumberConverter
    {
        private static readonly double AHZ = 1e24;   //Attohertz 
        private static readonly double CHZ = 1e8;    //Centihertz
        private static readonly double CS = 1e6;     //Cycle per Second
        private static readonly double DHZ = 1e7;    //Decihertz   
        private static readonly double DAHZ = 1e5;   //Dekahertz   
        private static readonly double EHZ = 1e-12;  //Exahertz
        private static readonly double FHZ = 1e21;   //Femtohertz 
        private static readonly double GHZ = 1e-3;   //Gigahertz
        private static readonly double HHZ = 1e4;    //Hectohertz  
        private static readonly double HZ = 1e6;     //Hertz
        private static readonly double KHZ = 1e3;    //Kilohertz 
        private static readonly double MHZ = 1;      //Megahertz
        private static readonly double MUHZ = 1e12;  //Microhertz
        private static readonly double MIHZ = 1e9;   //Millihertz
        private static readonly double NHZ = 1e15;   //Nanohertz
        private static readonly double PEHZ = 1e-9;  //Petahertz
        private static readonly double PHZ = 1e18;   //Picohertz 
        private static readonly double RD = 864e8;   //Revolution per Day 
        private static readonly double RH = 36e8;    //Revolution per Hour
        private static readonly double RM = 6e7;     //Revolution per Minute
        private static readonly double RS = 1e6;     //Revolution per Second
        private static readonly double THZ = 1e-6;   //Terahertz

        public FrequencyConverter()
        {

        }
        public FrequencyConverter(double value, FrequencyUnits units) : base(BuildFromContext(value, units))
        {

        }

        public FrequencyConverter From(double value, FrequencyUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(FrequencyUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(FrequencyUnits units)
        {
            switch (units)
            {
                case FrequencyUnits.Attohertz: { return (AHZ); }
                case FrequencyUnits.Centihertz: { return (CHZ); }
                case FrequencyUnits.CyclesPerSecond: { return (CS); }
                case FrequencyUnits.Decihertz: { return (DHZ); }
                case FrequencyUnits.Dekahertz: { return (DAHZ); }
                case FrequencyUnits.Exahertz: { return (EHZ); }
                case FrequencyUnits.Femtohertz: { return (FHZ); }
                case FrequencyUnits.Gigahertz: { return (GHZ); }
                case FrequencyUnits.Hectohertz: { return (HHZ); }
                case FrequencyUnits.Hertz: { return (HZ); }
                case FrequencyUnits.Kilohertz: { return (KHZ); }
                case FrequencyUnits.Megahertz: { return (MHZ); }
                case FrequencyUnits.Microhertz: { return (MUHZ); }
                case FrequencyUnits.Millihertz: { return (MIHZ); }
                case FrequencyUnits.Nanohertz: { return (NHZ); }
                case FrequencyUnits.Petahertz: { return (PEHZ); }
                case FrequencyUnits.Picohertz: { return (PHZ); }
                case FrequencyUnits.RevolutionsPerDay: { return (RD); }
                case FrequencyUnits.RevolutionsPerHour: { return (RH); }
                case FrequencyUnits.RevolutionsPerMinute: { return (RM); }
                case FrequencyUnits.RevolutionsPerSecond: { return (RS); }
                case FrequencyUnits.Terahertz: { return (THZ); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, FrequencyUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class FrequencyConverterExtensions
    {
        #region From & To Methods
        //public FrequencyConverter FromAttohertz(double v) { return StoreFromContext(this, v, AHZ, "AHZ"); }
        //public FrequencyConverter FromCentihertz(double v) { return StoreFromContext(this, v, CHZ, "CHZ"); }
        //public FrequencyConverter FromCyclesPerSecond(double v) { return StoreFromContext(this, v, CS, "CS"); }
        //public FrequencyConverter FromDecihertz(double v) { return StoreFromContext(this, v, DHZ, "DHZ"); }
        //public FrequencyConverter FromDekahertz(double v) { return StoreFromContext(this, v, DAHZ, "DAHZ"); }
        //public FrequencyConverter FromExahertz(double v) { return StoreFromContext(this, v, EHZ, "EHZ"); }
        //public FrequencyConverter FromFemtohertz(double v) { return StoreFromContext(this, v, FHZ, "FHZ"); }
        //public FrequencyConverter FromGigahertz(double v) { return StoreFromContext(this, v, GHZ, "GHZ"); }
        //public FrequencyConverter FromHectohertz(double v) { return StoreFromContext(this, v, HHZ, "HHZ"); }
        //public FrequencyConverter FromHertz(double v) { return StoreFromContext(this, v, HZ, "HZ"); }
        //public FrequencyConverter FromKilohertz(double v) { return StoreFromContext(this, v, KHZ, "KHZ"); }
        //public FrequencyConverter FromMegahertz(double v) { return StoreFromContext(this, v, MHZ, "MHZ"); }
        //public FrequencyConverter FromMicrohertz(double v) { return StoreFromContext(this, v, MUHZ, "MUHZ"); }
        //public FrequencyConverter FromMillihertz(double v) { return StoreFromContext(this, v, MIHZ, "MIHZ"); }
        //public FrequencyConverter FromNanohertz(double v) { return StoreFromContext(this, v, NHZ, "NHZ"); }
        //public FrequencyConverter FromPetahertz(double v) { return StoreFromContext(this, v, PEHZ, "PEHZ"); }
        //public FrequencyConverter FromPicohertz(double v) { return StoreFromContext(this, v, PHZ, "PHZ"); }
        //public FrequencyConverter FromRevolutionsPerDay(double v) { return StoreFromContext(this, v, RD, "RD"); }
        //public FrequencyConverter FromRevolutionsPerHour(double v) { return StoreFromContext(this, v, RH, "RH"); }
        //public FrequencyConverter FromRevolutionsPerMinute(double v) { return StoreFromContext(this, v, RM, "RM"); }
        //public FrequencyConverter FromRevolutionsPerSecond(double v) { return StoreFromContext(this, v, RS, "RS"); }
        //public FrequencyConverter FromTerahertz(double v) { return StoreFromContext(this, v, THZ, "THZ"); }


        //public double ToAttohertz() { return PerformConversion(AHZ); }
        //public double ToCentihertz() { return PerformConversion(CHZ); }
        //public double ToCyclesPerSecond() { return PerformConversion(CS); }
        //public double ToDecihertz() { return PerformConversion(DHZ); }
        //public double ToDekahertz() { return PerformConversion(DAHZ); }
        //public double ToExahertz() { return PerformConversion(EHZ); }
        //public double ToFemtohertz() { return PerformConversion(FHZ); }
        //public double ToGigahertz() { return PerformConversion(GHZ); }
        //public double ToHectohertz() { return PerformConversion(HHZ); }
        //public double ToHertz() { return PerformConversion(HZ); }
        //public double ToKilohertz() { return PerformConversion(KHZ); }
        //public double ToMegahertz() { return PerformConversion(MHZ); }
        //public double ToMicrohertz() { return PerformConversion(MUHZ); }
        //public double ToMillihertz() { return PerformConversion(MIHZ); }
        //public double ToNanohertz() { return PerformConversion(NHZ); }
        //public double ToPetahertz() { return PerformConversion(PEHZ); }
        //public double ToPicohertz() { return PerformConversion(PHZ); }
        //public double ToRevolutionsPerDay() { return PerformConversion(RD); }
        //public double ToRevolutionsPerHour() { return PerformConversion(RH); }
        //public double ToRevolutionsPerMinute() { return PerformConversion(RM); }
        //public double ToRevolutionsPerSecond() { return PerformConversion(RS); }
        //public double ToTerahertz() { return PerformConversion(THZ); }
        #endregion
    }


}