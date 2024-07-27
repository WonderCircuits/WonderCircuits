using System;

namespace WonderCircuits.UnitOf
{
    public class AreaConverter : BaseNumberConverter
    {
        private static readonly double AC = 1 / 4046.8564224;  //Acre
        private static readonly double A = 1e-2;             //Are
        private static readonly double AR = 1 / 3418.740000066;//Arpent
        private static readonly double B = 1e28;             //Barn
        private static readonly double CRIN = 1973.52524139; //Circular Inch
        private static readonly double CRMIL = 1973525241.39;//Circular Mil
        private static readonly double HA = 1e-4;            //Hactare
        private static readonly double HS = 1 / 647497.027584; //Homestead 
        private static readonly double R = 1 / 1011.7141056;   //Rood
        private static readonly double S = 1 / 0.09290304;     //Sabin
        private static readonly double C = 1e4;              //Square Centimeter
        private static readonly double CH = 1 / 404.68564224;  //Square Chain
        private static readonly double D = 1e2;              //Square Decimeter
        private static readonly double DA = 1e-2;            //Square Dekameter
        private static readonly double FT = 1 / 0.09290304;    //Square Foot
        private static readonly double H = 1e-4;             //Square Hectometer
        private static readonly double IN = 1 / 0.00064516;    //Square Inch
        private static readonly double TIN = 1 / (0.00064516 / 1000000);    //Square Inch
        private static readonly double MUIN = 1 / (0.00064516 / 1000000000000);    //Square Inch

        private static readonly double K = 1e-6;             //Square Kilometer
        private static readonly double M = 1;                //Square Meter
        private static readonly double MU = 1e12;            //Square Micrometer  
        private static readonly double MI = 1 / 2589988.110336;//Square Mile
        private static readonly double MIL = 1e6;            //Square millimeter  
        private static readonly double N = 1e18;             //Square Nanometer
        private static readonly double PE = 1 / 25.29285264;   //Square Perch
        private static readonly double PO = 1 / 25.29285264;   //Square Pole
        private static readonly double ROD = 1 / 25.29285264;  //Square Rod
        private static readonly double YD = 1 / 0.83612736;    //Square Yard
        public AreaConverter()
        {

        }
        public AreaConverter(double value, AreaUnits units) : base(BuildFromContext(value, units))
        {

        }

        public AreaConverter From(double value, AreaUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(AreaUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(AreaUnits units)
        {
            switch (units)
            {
                case AreaUnits.Acres: { return (AC); }
                case AreaUnits.Ares: { return (A); }
                case AreaUnits.Arpents: { return (AR); }
                case AreaUnits.Barns: { return (B); }
                case AreaUnits.CircularInches: { return (CRIN); }
                case AreaUnits.CircularMils: { return (CRMIL); }
                case AreaUnits.Hectares: { return (HA); }
                case AreaUnits.Homesteads: { return (HS); }
                case AreaUnits.Roods: { return (R); }
                case AreaUnits.Sabins: { return (S); }
                case AreaUnits.SquareCentimeters: { return (C); }
                case AreaUnits.SquareChains: { return (CH); }
                case AreaUnits.SquareDecimeters: { return (D); }
                case AreaUnits.SquareDekameters: { return (DA); }
                case AreaUnits.SquareFeet: { return (FT); }
                case AreaUnits.SquareHectometers: { return (H); }
                case AreaUnits.SquareInches: { return (IN); }
                case AreaUnits.SquareThousandthInches: { return (IN); }
                case AreaUnits.SquareMicroInches: { return (IN); }
                case AreaUnits.SquareKilometers: { return (K); }
                case AreaUnits.SquareMeters: { return (M); }
                case AreaUnits.SquareMicrometers: { return (MU); }
                case AreaUnits.SquareMiles: { return (MI); }
                case AreaUnits.SquareMillimeters: { return (MIL); }
                case AreaUnits.SquareNanometers: { return (N); }
                case AreaUnits.SquarePerches: { return (PE); }
                case AreaUnits.SquarePoles: { return (PO); }
                case AreaUnits.SquareRods: { return (ROD); }
                case AreaUnits.SquareYards: { return (YD); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, AreaUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class AreaConverterExtensions
    {
        #region From & To Methods
        //public AreaConverter FromAcres(double v) { return StoreFromContext(this, v, AC, "AC"); }
        //public AreaConverter FromAres(double v) { return StoreFromContext(this, v, A, "A"); }
        //public AreaConverter FromArpents(double v) { return StoreFromContext(this, v, AR, "AR"); }
        //public AreaConverter FromBarns(double v) { return StoreFromContext(this, v, B, "B"); }
        //public AreaConverter FromCircularInches(double v) { return StoreFromContext(this, v, CRIN, "CRIN"); }
        //public AreaConverter FromCircularMils(double v) { return StoreFromContext(this, v, CRMIL, "CRMIL"); }
        //public AreaConverter FromHectares(double v) { return StoreFromContext(this, v, HA, "HA"); }
        //public AreaConverter FromHomesteads(double v) { return StoreFromContext(this, v, HS, "HS"); }
        //public AreaConverter FromRoods(double v) { return StoreFromContext(this, v, R, "R"); }
        //public AreaConverter FromSabins(double v) { return StoreFromContext(this, v, S, "S"); }
        //public AreaConverter FromSquareCentimeters(double v) { return StoreFromContext(this, v, C, "C"); }
        //public AreaConverter FromSquareChains(double v) { return StoreFromContext(this, v, CH, "CH"); }
        //public AreaConverter FromSquareDecimeters(double v) { return StoreFromContext(this, v, D, "D"); }
        //public AreaConverter FromSquareDekameters(double v) { return StoreFromContext(this, v, DA, "DA"); }
        //public AreaConverter FromSquareFeet(double v) { return StoreFromContext(this, v, FT, "FT"); }
        //public AreaConverter FromSquareHectometers(double v) { return StoreFromContext(this, v, H, "H"); }
        //public AreaConverter FromSquareInches(double v) { return StoreFromContext(this, v, IN, "IN"); }
        //public AreaConverter FromSquareThousandthInches(double v) { return StoreFromContext(this, v, TIN, "TIN"); }
        //public AreaConverter FromSquareMicroInches(double v) { return StoreFromContext(this, v, MUIN, "MUIN"); }
        //public AreaConverter FromSquareKilometers(double v) { return StoreFromContext(this, v, K, "K"); }
        //public AreaConverter FromSquareMeters(double v) { return StoreFromContext(this, v, M, "M"); }
        //public AreaConverter FromSquareMicrometers(double v) { return StoreFromContext(this, v, MU, "MU"); }
        //public AreaConverter FromSquareMiles(double v) { return StoreFromContext(this, v, MI, "MI"); }
        //public AreaConverter FromSquareMillimeters(double v) { return StoreFromContext(this, v, MIL, "MIL"); }
        //public AreaConverter FromSquareNanometers(double v) { return StoreFromContext(this, v, N, "N"); }
        //public AreaConverter FromSquarePerches(double v) { return StoreFromContext(this, v, PE, "PE"); }
        //public AreaConverter FromSquarePoles(double v) { return StoreFromContext(this, v, PO, "PO"); }
        //public AreaConverter FromSquareRods(double v) { return StoreFromContext(this, v, ROD, "ROD"); }
        //public AreaConverter FromSquareYards(double v) { return StoreFromContext(this, v, YD, "YD"); }

        //public double ToAcres() { return PerformConversion(AC); }
        //public double ToAres() { return PerformConversion(A); }
        //public double ToArpents() { return PerformConversion(AR); }
        //public double ToBarns() { return PerformConversion(B); }
        //public double ToCircularInches() { return PerformConversion(CRIN); }
        //public double ToCircularMils() { return PerformConversion(CRMIL); }
        //public double ToHectares() { return PerformConversion(HA); }
        //public double ToHomesteads() { return PerformConversion(HS); }
        //public double ToRoods() { return PerformConversion(R); }
        //public double ToSabins() { return PerformConversion(S); }
        //public double ToSquareCentimeters() { return PerformConversion(C); }
        //public double ToSquareChains() { return PerformConversion(CH); }
        //public double ToSquareDecimeters() { return PerformConversion(D); }
        //public double ToSquareDekameters() { return PerformConversion(DA); }
        //public double ToSquareFeet() { return PerformConversion(FT); }
        //public double ToSquareHectometers() { return PerformConversion(H); }
        //public double ToSquareInches() { return PerformConversion(IN); }
        //public double ToSquareThousandthInches() { return PerformConversion(TIN); }
        //public double ToSquareMicroInches() { return PerformConversion(MUIN); }
        //public double ToSquareKilometers() { return PerformConversion(K); }
        //public double ToSquareMeters() { return PerformConversion(M); }
        //public double ToSquareMicrometers() { return PerformConversion(MU); }
        //public double ToSquareMiles() { return PerformConversion(MI); }
        //public double ToSquareMillimeters() { return PerformConversion(MIL); }
        //public double ToSquareNanometers() { return PerformConversion(N); }
        //public double ToSquarePerches() { return PerformConversion(PE); }
        //public double ToSquarePoles() { return PerformConversion(PO); }
        //public double ToSquareRods() { return PerformConversion(ROD); }
        //public double ToSquareYards() { return PerformConversion(YD); }
        #endregion
    }



}