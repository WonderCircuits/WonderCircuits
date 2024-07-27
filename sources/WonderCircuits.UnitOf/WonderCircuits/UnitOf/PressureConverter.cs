using System;

namespace WonderCircuits.UnitOf
{
    public class PressureConverter : BaseNumberConverter
    {
        private static readonly double APA = 1e18;               //Attopascal
        private static readonly double BAR = 1e-5;               //Bar
        private static readonly double BA = 1e1;                 //Barye 
        private static readonly double CMHG = 1 / 1333.22;         //Centimeter Mercury (0C)
        private static readonly double CMW4 = 1 / 98.0638;         //Centimeter Water (4C)
        private static readonly double CPA = 1e2;                //Centipascal
        private static readonly double DBAR = 1e-4;              //Decibar 
        private static readonly double DPA = 1e1;                //Decipascal
        private static readonly double DAPA = 1e-1;              //Dekapascal
        private static readonly double DYNCM = 1e1;              //Dyne per Square Centimeter
        private static readonly double EPA = 1e-18;              //Exapascal
        private static readonly double FSW = 1 / 3064.30593138;    //Foot Sea Water (15С)
        private static readonly double FTW4 = 1 / 2988.98;         //Foot Water (4C)
        private static readonly double FTW60 = 1 / 2986.116;       //Foot Water (60F)
        private static readonly double FPA = 1e15;               //Femtopascal
        private static readonly double GPA = 1e-9;               //Gigapascal
        private static readonly double GFCM = 1 / 98.0665;         //Gram ForceConverter per Square Centimeter
        private static readonly double HPA = 1e-2;               //Hectopascal
        private static readonly double INHG32 = 1 / 3386.38;       //Inch Mercury (32F)
        private static readonly double INHG60 = 1 / 3376.85;       //Inch Mercury (60F)
        private static readonly double INW4 = 1 / 249.082;         //Inch Water (4C)
        private static readonly double INW60 = 1 / 248.843;        //Inch Water (60F)
        private static readonly double KSI = 1 / 6894757.293178;   //KSI
        private static readonly double KGFCM = 1 / 98066.5;        //Kilogram ForceConverter per Square Centimeter
        private static readonly double KGFM = 1 / 9.80665;         //Kilogram ForceConverter per Square Meter   
        private static readonly double KFGMM = 1 / 9806650.0;      //Kilogram ForceConverter per Square Millimeter
        private static readonly double KNM = 1e-3;               //Kilonewton per Square Meter
        private static readonly double KPA = 1e-3;               //Kilopascal
        private static readonly double KIPFIN = 1 / 6894757.293178;//Kip ForceConverter per Square Inch
        private static readonly double TFFTL = 1 / 107251.780116;  //Ton ForceConverter per Square Foot (Long)
        private static readonly double TFINL = 1 / 15444256.3367;  //Ton ForceConverter per Square Inch (Long)
        private static readonly double MPA = 1e-6;               //Megapascal
        private static readonly double MSW = 1e-4;               //Meter Sea Water
        private static readonly double MW4 = 1 / 9806.38;          //Meter Water (4C)
        private static readonly double MUBAR = 1e1;              //Microbar 
        private static readonly double MUPA = 1e6;               //Micropascal
        private static readonly double MILBAR = 1e-2;            //Millibar 
        private static readonly double MMHG = 1 / 133.322;         //Millimeter Mercury (0C)
        private static readonly double MMW4 = 1 / 9.80638;         //Millimeter Water (4C)
        private static readonly double MILPA = 1e3;              //Millipascal
        private static readonly double NPA = 1e9;                //Nanopascal
        private static readonly double NCM = 1e-4;               //Newton per Square Centimeter
        private static readonly double NM = 1;                   //Newton per Square Meter
        private static readonly double NMM = 1e-6;               //Newton per Square Millimeter
        private static readonly double PSI = 1 / 6894.757293178;   //PSI
        private static readonly double PA = 1;                   //Pascal
        private static readonly double PEPA = 1e-15;             //Petapascal
        private static readonly double PPA = 1e12;               //Picopascal
        private static readonly double PIZ = 1e-3;               //Pieze 
        private static readonly double PDLFT = 1 / 1.48816394357;  //Poundal per Square Foot
        private static readonly double LBFFT = 1 / 47.8802589804;  //Pound ForceConverter per Square Foot
        private static readonly double LBFIN = 1 / 6894.757293178; //Pound ForceConverter per Square Inch
        private static readonly double TFFTS = 1 / 95760.51796068; //Ton ForceConverter per Square Foot (Short)
        private static readonly double TFINS = 1 / 13789514.58634; //Ton ForceConverter per Square Inch (Short)
        private static readonly double ATM = 1 / 101325.0;         //Standard Atmosphere
        private static readonly double SM = 1e-3;                //Sthene per Square Meter
        private static readonly double AT = 1 / 98066.5;           //Atmosphere Technical
        private static readonly double TPA = 1e-12;              //Terapascal
        private static readonly double TORR = 1 / 133.3223684211;  //Torr

        public PressureConverter()
        {

        }
        public PressureConverter(double value, PressureUnits units) : base(BuildFromContext(value, units))
        {

        }

        public PressureConverter From(double value, PressureUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(PressureUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(PressureUnits units)
        {
            switch (units)
            {
            case PressureUnits.Attopascals: { return (APA); }
            case PressureUnits.Bars: { return (BAR); }
            case PressureUnits.Baryes: { return (BA); }
            case PressureUnits.CentimetersOfMercury0C: { return (CMHG); }
            case PressureUnits.CentimetersOfWater4C: { return (CMW4); }
            case PressureUnits.Centipascals: { return (CPA); }
            case PressureUnits.Decibars: { return (DBAR); }
            case PressureUnits.Decipascals: { return (DPA); }
            case PressureUnits.Dekapascals: { return (DAPA); }
            case PressureUnits.DynesPerSquareCentimeter: { return (DYNCM); }
            case PressureUnits.Exapascals: { return (EPA); }
            case PressureUnits.FeetOfSeaWater: { return (FSW); }
            case PressureUnits.FeetOfWater4C: { return (FTW4); }
            case PressureUnits.FeetOfWater60F: { return (FTW60); }
            case PressureUnits.Femtopascals: { return (FPA); }
            case PressureUnits.Gigapascals: { return (GPA); }
            case PressureUnits.GramsPerSquareCentimeter: { return (GFCM); }
            case PressureUnits.Hectopascals: { return (HPA); }
            case PressureUnits.InchesOfMercury32F: { return (INHG32); }
            case PressureUnits.InchesOfMercury60F: { return (INHG60); }
            case PressureUnits.InchesOfWater4C: { return (INW4); }
            case PressureUnits.InchesOfWater60F: { return (INW60); }
            case PressureUnits.KSI: { return (KSI); }
            case PressureUnits.KilogramsPerSquareCentimeter: { return (KGFCM); }
            case PressureUnits.KilogramsPerSquareMeter: { return (KGFM); }
            case PressureUnits.KilogramsPerSquareMillimeter: { return (KFGMM); }
            case PressureUnits.KilonewtonsPerSquareMeter: { return (KNM); }
            case PressureUnits.Kilopascals: { return (KPA); }
            case PressureUnits.KipsPerSquareInch: { return (KIPFIN); }
            case PressureUnits.LongTonsPerSquareFoot: { return (TFFTL); }
            case PressureUnits.LongTonsPerSquareInch: { return (TFINL); }
            case PressureUnits.Megapascals: { return (MPA); }
            case PressureUnits.MetersOfSeaWater: { return (MSW); }
            case PressureUnits.MetersOfWater4C: { return (MW4); }
            case PressureUnits.Microbars: { return (MUBAR); }
            case PressureUnits.Micropascals: { return (MUPA); }
            case PressureUnits.Millibars: { return (MILBAR); }
            case PressureUnits.MillimetersOfMercury0C: { return (MMHG); }
            case PressureUnits.MillimetersOfWater4C: { return (MMW4); }
            case PressureUnits.Millipascals: { return (MILPA); }
            case PressureUnits.Nanopascals: { return (NPA); }
            case PressureUnits.NewtonsPerSquareCentimeter: { return (NCM); }
            case PressureUnits.NewtonsPerSquareMeter: { return (NM); }
            case PressureUnits.NewtonsPerSquareMillimeter: { return (NMM); }
            case PressureUnits.PSI: { return (PSI); }
            case PressureUnits.Pascals: { return (PA); }
            case PressureUnits.Petapascals: { return (PEPA); }
            case PressureUnits.Picopascals: { return (PPA); }
            case PressureUnits.Pieze: { return (PIZ); }
            case PressureUnits.PoundalsPerSquareFoot: { return (PDLFT); }
            case PressureUnits.PoundsPerSquareFoot: { return (LBFFT); }
            case PressureUnits.PoundsPerSquareInch: { return (LBFIN); }
            case PressureUnits.ShortTonsPerSquareFoot: { return (TFFTS); }
            case PressureUnits.ShortTonsPerSquareInch: { return (TFINS); }
            case PressureUnits.StandardAtmospheres: { return (ATM); }
            case PressureUnits.SthenesPerSquareMeter: { return (SM); }
            case PressureUnits.TechnicalAtmospheres: { return (AT); }
            case PressureUnits.Terapascals: { return (TPA); }
            case PressureUnits.Torrs: { return (TORR); }

            default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, PressureUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class PressureConverterExtensions
    {
        #region From & To Methods
        //public PressureConverter FromAttopascals(double v) { return StoreFromContext(this, v, APA, "APA"); }
        //public PressureConverter FromBars(double v) { return StoreFromContext(this, v, BAR, "BAR"); }
        //public PressureConverter FromBaryes(double v) { return StoreFromContext(this, v, BA, "BA"); }
        //public PressureConverter FromCentimetersOfMercury0C(double v) { return StoreFromContext(this, v, CMHG, "CMHG"); }
        //public PressureConverter FromCentimetersOfWater4C(double v) { return StoreFromContext(this, v, CMW4, "CMW4"); }
        //public PressureConverter FromCentipascals(double v) { return StoreFromContext(this, v, CPA, "CPA"); }
        //public PressureConverter FromDecibars(double v) { return StoreFromContext(this, v, DBAR, "DBAR"); }
        //public PressureConverter FromDecipascals(double v) { return StoreFromContext(this, v, DPA, "DPA"); }
        //public PressureConverter FromDekapascals(double v) { return StoreFromContext(this, v, DAPA, "DAPA"); }
        //public PressureConverter FromDynesPerSquareCentimeter(double v) { return StoreFromContext(this, v, DYNCM, "DYNCM"); }
        //public PressureConverter FromExapascals(double v) { return StoreFromContext(this, v, EPA, "EPA"); }
        //public PressureConverter FromFeetOfSeaWater(double v) { return StoreFromContext(this, v, FSW, "FSW"); }
        //public PressureConverter FromFeetOfWater4C(double v) { return StoreFromContext(this, v, FTW4, "FTW4"); }
        //public PressureConverter FromFeetOfWater60F(double v) { return StoreFromContext(this, v, FTW60, "FTW60"); }
        //public PressureConverter FromFemtopascals(double v) { return StoreFromContext(this, v, FPA, "FPA"); }
        //public PressureConverter FromGigapascals(double v) { return StoreFromContext(this, v, GPA, "GPA"); }
        //public PressureConverter FromGramsPerSquareCentimeter(double v) { return StoreFromContext(this, v, GFCM, "GFCM"); }
        //public PressureConverter FromHectopascals(double v) { return StoreFromContext(this, v, HPA, "HPA"); }
        //public PressureConverter FromInchesOfMercury32F(double v) { return StoreFromContext(this, v, INHG32, "INHG32"); }
        //public PressureConverter FromInchesOfMercury60F(double v) { return StoreFromContext(this, v, INHG60, "INHG60"); }
        //public PressureConverter FromInchesOfWater4C(double v) { return StoreFromContext(this, v, INW4, "INW4"); }
        //public PressureConverter FromInchesOfWater60F(double v) { return StoreFromContext(this, v, INW60, "INW60"); }
        //public PressureConverter FromKSI(double v) { return StoreFromContext(this, v, KSI, "KSI"); }
        //public PressureConverter FromKilogramsPerSquareCentimeter(double v) { return StoreFromContext(this, v, KGFCM, "KGFCM"); }
        //public PressureConverter FromKilogramsPerSquareMeter(double v) { return StoreFromContext(this, v, KGFM, "KGFM"); }
        //public PressureConverter FromKilogramsPerSquareMillimeter(double v) { return StoreFromContext(this, v, KFGMM, "KFGMM"); }
        //public PressureConverter FromKilonewtonsPerSquareMeter(double v) { return StoreFromContext(this, v, KNM, "KNM"); }
        //public PressureConverter FromKilopascals(double v) { return StoreFromContext(this, v, KPA, "KPA"); }
        //public PressureConverter FromKipsPerSquareInch(double v) { return StoreFromContext(this, v, KIPFIN, "KIPFIN"); }
        //public PressureConverter FromLongTonsPerSquareFoot(double v) { return StoreFromContext(this, v, TFFTL, "TFFTL"); }
        //public PressureConverter FromLongTonsPerSquareInch(double v) { return StoreFromContext(this, v, TFINL, "TFINL"); }
        //public PressureConverter FromMegapascals(double v) { return StoreFromContext(this, v, MPA, "MPA"); }
        //public PressureConverter FromMetersOfSeaWater(double v) { return StoreFromContext(this, v, MSW, "MSW"); }
        //public PressureConverter FromMetersOfWater4C(double v) { return StoreFromContext(this, v, MW4, "MW4"); }
        //public PressureConverter FromMicrobars(double v) { return StoreFromContext(this, v, MUBAR, "MUBAR"); }
        //public PressureConverter FromMicropascals(double v) { return StoreFromContext(this, v, MUPA, "MUPA"); }
        //public PressureConverter FromMillibars(double v) { return StoreFromContext(this, v, MILBAR, "MILBAR"); }
        //public PressureConverter FromMillimetersOfMercury0C(double v) { return StoreFromContext(this, v, MMHG, "MMHG"); }
        //public PressureConverter FromMillimetersOfWater4C(double v) { return StoreFromContext(this, v, MMW4, "MMW4"); }
        //public PressureConverter FromMillipascals(double v) { return StoreFromContext(this, v, MILPA, "MILPA"); }
        //public PressureConverter FromNanopascals(double v) { return StoreFromContext(this, v, NPA, "NPA"); }
        //public PressureConverter FromNewtonsPerSquareCentimeter(double v) { return StoreFromContext(this, v, NCM, "NCM"); }
        //public PressureConverter FromNewtonsPerSquareMeter(double v) { return StoreFromContext(this, v, NM, "NM"); }
        //public PressureConverter FromNewtonsPerSquareMillimeter(double v) { return StoreFromContext(this, v, NMM, "NMM"); }
        //public PressureConverter FromPSI(double v) { return StoreFromContext(this, v, PSI, "PSI"); }
        //public PressureConverter FromPascals(double v) { return StoreFromContext(this, v, PA, "PA"); }
        //public PressureConverter FromPetapascals(double v) { return StoreFromContext(this, v, PEPA, "PEPA"); }
        //public PressureConverter FromPicopascals(double v) { return StoreFromContext(this, v, PPA, "PPA"); }
        //public PressureConverter FromPieze(double v) { return StoreFromContext(this, v, PIZ, "PIZ"); }
        //public PressureConverter FromPoundalsPerSquareFoot(double v) { return StoreFromContext(this, v, PDLFT, "PDLFT"); }
        //public PressureConverter FromPoundsPerSquareFoot(double v) { return StoreFromContext(this, v, LBFFT, "LBFFT"); }
        //public PressureConverter FromPoundsPerSquareInch(double v) { return StoreFromContext(this, v, LBFIN, "LBFIN"); }
        //public PressureConverter FromShortTonsPerSquareFoot(double v) { return StoreFromContext(this, v, TFFTS, "TFFTS"); }
        //public PressureConverter FromShortTonsPerSquareInch(double v) { return StoreFromContext(this, v, TFINS, "TFINS"); }
        //public PressureConverter FromStandardAtmospheres(double v) { return StoreFromContext(this, v, ATM, "ATM"); }
        //public PressureConverter FromSthenesPerSquareMeter(double v) { return StoreFromContext(this, v, SM, "SM"); }
        //public PressureConverter FromTechnicalAtmospheres(double v) { return StoreFromContext(this, v, AT, "AT"); }
        //public PressureConverter FromTerapascals(double v) { return StoreFromContext(this, v, TPA, "TPA"); }
        //public PressureConverter FromTorrs(double v) { return StoreFromContext(this, v, TORR, "TORR"); }


        //public double ToAttopascals() { return PerformConversion(APA); }
        //public double ToBars() { return PerformConversion(BAR); }
        //public double ToBaryes() { return PerformConversion(BA); }
        //public double ToCentimetersOfMercury0C() { return PerformConversion(CMHG); }
        //public double ToCentimetersOfWater4C() { return PerformConversion(CMW4); }
        //public double ToCentipascals() { return PerformConversion(CPA); }
        //public double ToDecibars() { return PerformConversion(DBAR); }
        //public double ToDecipascals() { return PerformConversion(DPA); }
        //public double ToDekapascals() { return PerformConversion(DAPA); }
        //public double ToDynesPerSquareCentimeter() { return PerformConversion(DYNCM); }
        //public double ToExapascals() { return PerformConversion(EPA); }
        //public double ToFeetOfSeaWater() { return PerformConversion(FSW); }
        //public double ToFeetOfWater4C() { return PerformConversion(FTW4); }
        //public double ToFeetOfWater60F() { return PerformConversion(FTW60); }
        //public double ToFemtopascals() { return PerformConversion(FPA); }
        //public double ToGigapascals() { return PerformConversion(GPA); }
        //public double ToGramsPerSquareCentimeter() { return PerformConversion(GFCM); }
        //public double ToHectopascals() { return PerformConversion(HPA); }
        //public double ToInchesOfMercury32F() { return PerformConversion(INHG32); }
        //public double ToInchesOfMercury60F() { return PerformConversion(INHG60); }
        //public double ToInchesOfWater4C() { return PerformConversion(INW4); }
        //public double ToInchesOfWater60F() { return PerformConversion(INW60); }
        //public double ToKSI() { return PerformConversion(KSI); }
        //public double ToKilogramsPerSquareCentimeter() { return PerformConversion(KGFCM); }
        //public double ToKilogramsPerSquareMeter() { return PerformConversion(KGFM); }
        //public double ToKilogramsPerSquareMillimeter() { return PerformConversion(KFGMM); }
        //public double ToKilonewtonsPerSquareMeter() { return PerformConversion(KNM); }
        //public double ToKilopascals() { return PerformConversion(KPA); }
        //public double ToKipsPerSquareInch() { return PerformConversion(KIPFIN); }
        //public double ToLongTonsPerSquareFoot() { return PerformConversion(TFFTL); }
        //public double ToLongTonsPerSquareInch() { return PerformConversion(TFINL); }
        //public double ToMegapascals() { return PerformConversion(MPA); }
        //public double ToMetersOfSeaWater() { return PerformConversion(MSW); }
        //public double ToMetersOfWater4C() { return PerformConversion(MW4); }
        //public double ToMicrobars() { return PerformConversion(MUBAR); }
        //public double ToMicropascals() { return PerformConversion(MUPA); }
        //public double ToMillibars() { return PerformConversion(MILBAR); }
        //public double ToMillimetersOfMercury0C() { return PerformConversion(MMHG); }
        //public double ToMillimetersOfWater4C() { return PerformConversion(MMW4); }
        //public double ToMillipascals() { return PerformConversion(MILPA); }
        //public double ToNanopascals() { return PerformConversion(NPA); }
        //public double ToNewtonsPerSquareCentimeter() { return PerformConversion(NCM); }
        //public double ToNewtonsPerSquareMeter() { return PerformConversion(NM); }
        //public double ToNewtonsPerSquareMillimeter() { return PerformConversion(NMM); }
        //public double ToPSI() { return PerformConversion(PSI); }
        //public double ToPascals() { return PerformConversion(PA); }
        //public double ToPetapascals() { return PerformConversion(PEPA); }
        //public double ToPicopascals() { return PerformConversion(PPA); }
        //public double ToPieze() { return PerformConversion(PIZ); }
        //public double ToPoundalsPerSquareFoot() { return PerformConversion(PDLFT); }
        //public double ToPoundsPerSquareFoot() { return PerformConversion(LBFFT); }
        //public double ToPoundsPerSquareInch() { return PerformConversion(LBFIN); }
        //public double ToShortTonsPerSquareFoot() { return PerformConversion(TFFTS); }
        //public double ToShortTonsPerSquareInch() { return PerformConversion(TFINS); }
        //public double ToStandardAtmospheres() { return PerformConversion(ATM); }
        //public double ToSthenesPerSquareMeter() { return PerformConversion(SM); }
        //public double ToTechnicalAtmospheres() { return PerformConversion(AT); }
        //public double ToTerapascals() { return PerformConversion(TPA); }
        //public double ToTorrs() { return PerformConversion(TORR); }
        #endregion
    }


}