using System;

namespace WonderCircuits.UnitOf
{
    public class VolumeConverter : BaseNumberConverter
    {
        private static readonly double ACFTUS = 0.0008107083295205;  //Acre Foot (US)
        private static readonly double ACIN = 0.009728558325479;     //Acre Inch
        private static readonly double ACFTO = 0.0008107131937899;   //Acre Foot
        private static readonly double AL = 1e21;                    //Attoliter
        private static readonly double BBLO = 6.289810770432;        //Barrel (Oil)
        private static readonly double BBLUK = 6.110256897197;       //Barrel (UK) 
        private static readonly double BBLUS = 8.386414360576;       //Barrel (US)
        private static readonly double FBM = 423.7760006579;         //Board Foot
        private static readonly double CL = 1e5;                     //Centiliter 
        private static readonly double CORD = 0.2758958337616;       //Cord 
        private static readonly double CM = 1e6;                     //Cubic Centimeter
        private static readonly double DM = 1e3;                     //Cubic Decimeter
        private static readonly double FT = 35.31466672148;          //Cubic Foot
        private static readonly double IN = 61023.74409473;          //Cubic Inch
        private static readonly double KM = 1e-9;                    //Cubic Kilometer
        private static readonly double M = 1;                        //Cubic Meter
        private static readonly double MI = 2.399127585789e-10;      //Cubic Mile
        private static readonly double MM = 1e9;                     //Cubic Millimeter
        private static readonly double YD = 1.307950619314;          //Cubic Yard
        private static readonly double CUPM = 4e3;                   //Cup (Metric)
        private static readonly double CUPUK = 3519.507972785;       //Cup (UK)
        private static readonly double CUPUS = 4226.75283773;        //Cup (US)
        private static readonly double DL = 1e4;                     //Deciliter 
        private static readonly double DECI = 1e1;                   //Decistere 
        private static readonly double DAL = 1e2;                    //Dekaliter 
        private static readonly double DEKA = 0.1;                   //Dekastere
        private static readonly double DSTSPNUK = 84468.19134685;    //Dessertspoon (UK)
        private static readonly double DSTSPNUS = 101442.0681055;    //Dessertspoon (US)
        private static readonly double DROP = 2e7;                   //Drop
        private static readonly double EL = 1e-15;                   //Exaliter 
        private static readonly double FL = 1e18;                    //Femtoliter
        private static readonly double FLOZUK = 35195.07972785;      //Fluid Ounce (UK)
        private static readonly double FLOZUS = 33814.02270184;      //Fluid Ounce (US)
        private static readonly double GALUK = 219.9692482991;       //Gallon (UK)
        private static readonly double GALUS = 264.1720523581;       //Gallon (US)
        private static readonly double GL = 1e-6;                    //Gigaliter 
        private static readonly double GILUK = 7039.015945571;       //Fill (UK)
        private static readonly double GILUS = 8453.505675461;       //Gill (US)
        private static readonly double HL = 1e1;                     //Hectoliter 
        private static readonly double HOG = 4.193207180288;         //Hogshead
        private static readonly double CCF = 0.3531466672149;        //100 Cubic Feet
        private static readonly double KL = 1;                       //Kiloliter 
        private static readonly double L = 1e3;                      //Liter
        private static readonly double ML = 1e-3;                    //Megaliter 
        private static readonly double MUL = 1e9;                    //Microliter 
        private static readonly double MILL = 1e6;                   //Milliliter 
        private static readonly double MINIUK = 16893638.26937;      //Minim (UK)    
        private static readonly double MINIUS = 16230730.89688;      //Minim (US)
        private static readonly double NL = 1e12;                    //Nanoliter 
        private static readonly double PEL = 1e-12;                  //Petaliter 
        private static readonly double PL = 1e15;                    //Picoliter 
        private static readonly double PTUK = 1759.753986393;        //Pint (UK)
        private static readonly double PTUS = 2113.376418865;        //Pint (US) 
        private static readonly double QTUK = 879.8769931964;        //Quart (UK)
        private static readonly double QTUS = 1056.688209433;        //Quart (US)
        private static readonly double REGTON = 0.3531466672149;     //Register Ton
        private static readonly double ST = 1;                       //Stere 
        private static readonly double TBSPM = 66666.66666667;       //Tablespoon (Metric)
        private static readonly double TBSPUK = 56312.12756457;      //Tablespoon (UK)
        private static readonly double TBSPUS = 67628.04540369;      //Tablespoon (US)
        private static readonly double TSPM = 2e5;                   //Teaspoon (Metric)
        private static readonly double TSPUK = 168936.3826937;       //Teaspoon (UK)
        private static readonly double TSPUS = 202884.1362111;       //Teaspoon (US)
        private static readonly double TL = 1e-9;                    //Teraliter 
        private static readonly double TUN = 1.048301795072;         //Tun
        public VolumeConverter()
        {

        }
        public VolumeConverter(double value, VolumeUnits units) : base(BuildFromContext(value, units))
        {

        }

        public VolumeConverter From(double value, VolumeUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(VolumeUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(VolumeUnits units)
        {
            switch (units)
            {
                case VolumeUnits.AcreFeetUSSurvey: { return (ACFTUS); }
                case VolumeUnits.AcreInches: { return (ACIN); }
                case VolumeUnits.ArceFeet: { return (ACFTO); }
                case VolumeUnits.Attoliters: { return (AL); }
                case VolumeUnits.BarrelsOfOil: { return (BBLO); }
                case VolumeUnits.BarrelsUK: { return (BBLUK); }
                case VolumeUnits.BarrelsUS: { return (BBLUS); }
                case VolumeUnits.BoardFeet: { return (FBM); }
                case VolumeUnits.Centiliters: { return (CL); }
                case VolumeUnits.Cords: { return (CORD); }
                case VolumeUnits.CubicCentimeters: { return (CM); }
                case VolumeUnits.CubicDecimeters: { return (DM); }
                case VolumeUnits.CubicFeet: { return (FT); }
                case VolumeUnits.CubicInches: { return (IN); }
                case VolumeUnits.CubicKilometers: { return (KM); }
                case VolumeUnits.CubicMeters: { return (M); }
                case VolumeUnits.CubicMiles: { return (MI); }
                case VolumeUnits.CubicMillimeters: { return (MM); }
                case VolumeUnits.CubicYards: { return (YD); }
                case VolumeUnits.CupsMetric: { return (CUPM); }
                case VolumeUnits.CupsUK: { return (CUPUK); }
                case VolumeUnits.CupsUS: { return (CUPUS); }
                case VolumeUnits.Deciliters: { return (DL); }
                case VolumeUnits.Decisteres: { return (DECI); }
                case VolumeUnits.Dekaliters: { return (DAL); }
                case VolumeUnits.Dekasteres: { return (DEKA); }
                case VolumeUnits.DessertspoonsUK: { return (DSTSPNUK); }
                case VolumeUnits.DessertspoonsUS: { return (DSTSPNUS); }
                case VolumeUnits.Drops: { return (DROP); }
                case VolumeUnits.Exaliters: { return (EL); }
                case VolumeUnits.Femtoliters: { return (FL); }
                case VolumeUnits.FluidOuncesUK: { return (FLOZUK); }
                case VolumeUnits.FluidOuncesUS: { return (FLOZUS); }
                case VolumeUnits.GallonsUK: { return (GALUK); }
                case VolumeUnits.GallonsUS: { return (GALUS); }
                case VolumeUnits.Gigaliters: { return (GL); }
                case VolumeUnits.GillsUK: { return (GILUK); }
                case VolumeUnits.GillsUS: { return (GILUS); }
                case VolumeUnits.Hectoliters: { return (HL); }
                case VolumeUnits.Hogsheads: { return (HOG); }
                case VolumeUnits.HundredCubicFeet: { return (CCF); }
                case VolumeUnits.Kiloliters: { return (KL); }
                case VolumeUnits.Liters: { return (L); }
                case VolumeUnits.Megaliters: { return (ML); }
                case VolumeUnits.Microliters: { return (MUL); }
                case VolumeUnits.Milliliters: { return (MILL); }
                case VolumeUnits.MinimsUK: { return (MINIUK); }
                case VolumeUnits.MinimsUS: { return (MINIUS); }
                case VolumeUnits.Nanoliters: { return (NL); }
                case VolumeUnits.Petaliters: { return (PEL); }
                case VolumeUnits.Picoliters: { return (PL); }
                case VolumeUnits.PintsUK: { return (PTUK); }
                case VolumeUnits.PintsUS: { return (PTUS); }
                case VolumeUnits.QuartsUK: { return (QTUK); }
                case VolumeUnits.QuartsUS: { return (QTUS); }
                case VolumeUnits.RegisterTons: { return (REGTON); }
                case VolumeUnits.Steres: { return (ST); }
                case VolumeUnits.TablespoonsMetric: { return (TBSPM); }
                case VolumeUnits.TablespoonsUK: { return (TBSPUK); }
                case VolumeUnits.TablespoonsUS: { return (TBSPUS); }
                case VolumeUnits.TeaspoonsMetric: { return (TSPM); }
                case VolumeUnits.TeaspoonsUK: { return (TSPUK); }
                case VolumeUnits.TeaspoonsUS: { return (TSPUS); }
                case VolumeUnits.Teraliters: { return (TL); }
                case VolumeUnits.Tuns: { return (TUN); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, VolumeUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class VolumeConverterExtensions
    {
        #region From & To Methods
        //public VolumeConverter FromAcreFeetUSSurvey(double v) { return StoreFromContext(this, v, ACFTUS, "ACFTUS"); }
        //public VolumeConverter FromAcreInches(double v) { return StoreFromContext(this, v, ACIN, "ACIN"); }
        //public VolumeConverter FromArceFeet(double v) { return StoreFromContext(this, v, ACFTO, "ACFTO"); }
        //public VolumeConverter FromAttoliters(double v) { return StoreFromContext(this, v, AL, "AL"); }
        //public VolumeConverter FromBarrelsOfOil(double v) { return StoreFromContext(this, v, BBLO, "BBLO"); }
        //public VolumeConverter FromBarrelsUK(double v) { return StoreFromContext(this, v, BBLUK, "BBLUK"); }
        //public VolumeConverter FromBarrelsUS(double v) { return StoreFromContext(this, v, BBLUS, "BBLUS"); }
        //public VolumeConverter FromBoardFeet(double v) { return StoreFromContext(this, v, FBM, "FBM"); }
        //public VolumeConverter FromCentiliters(double v) { return StoreFromContext(this, v, CL, "CL"); }
        //public VolumeConverter FromCords(double v) { return StoreFromContext(this, v, CORD, "CORD"); }
        //public VolumeConverter FromCubicCentimeters(double v) { return StoreFromContext(this, v, CM, "CM"); }
        //public VolumeConverter FromCubicDecimeters(double v) { return StoreFromContext(this, v, DM, "DM"); }
        //public VolumeConverter FromCubicFeet(double v) { return StoreFromContext(this, v, FT, "FT"); }
        //public VolumeConverter FromCubicInches(double v) { return StoreFromContext(this, v, IN, "IN"); }
        //public VolumeConverter FromCubicKilometers(double v) { return StoreFromContext(this, v, KM, "KM"); }
        //public VolumeConverter FromCubicMeters(double v) { return StoreFromContext(this, v, M, "M"); }
        //public VolumeConverter FromCubicMiles(double v) { return StoreFromContext(this, v, MI, "MI"); }
        //public VolumeConverter FromCubicMillimeters(double v) { return StoreFromContext(this, v, MM, "MM"); }
        //public VolumeConverter FromCubicYards(double v) { return StoreFromContext(this, v, YD, "YD"); }
        //public VolumeConverter FromCupsMetric(double v) { return StoreFromContext(this, v, CUPM, "CUPM"); }
        //public VolumeConverter FromCupsUK(double v) { return StoreFromContext(this, v, CUPUK, "CUPUK"); }
        //public VolumeConverter FromCupsUS(double v) { return StoreFromContext(this, v, CUPUS, "CUPUS"); }
        //public VolumeConverter FromDeciliters(double v) { return StoreFromContext(this, v, DL, "DL"); }
        //public VolumeConverter FromDecisteres(double v) { return StoreFromContext(this, v, DECI, "DECI"); }
        //public VolumeConverter FromDekaliters(double v) { return StoreFromContext(this, v, DAL, "DAL"); }
        //public VolumeConverter FromDekasteres(double v) { return StoreFromContext(this, v, DEKA, "DEKA"); }
        //public VolumeConverter FromDessertspoonsUK(double v) { return StoreFromContext(this, v, DSTSPNUK, "DSTSPNUK"); }
        //public VolumeConverter FromDessertspoonsUS(double v) { return StoreFromContext(this, v, DSTSPNUS, "DSTSPNUS"); }
        //public VolumeConverter FromDrops(double v) { return StoreFromContext(this, v, DROP, "DROP"); }
        //public VolumeConverter FromExaliters(double v) { return StoreFromContext(this, v, EL, "EL"); }
        //public VolumeConverter FromFemtoliters(double v) { return StoreFromContext(this, v, FL, "FL"); }
        //public VolumeConverter FromFluidOuncesUK(double v) { return StoreFromContext(this, v, FLOZUK, "FLOZUK"); }
        //public VolumeConverter FromFluidOuncesUS(double v) { return StoreFromContext(this, v, FLOZUS, "FLOZUS"); }
        //public VolumeConverter FromGallonsUK(double v) { return StoreFromContext(this, v, GALUK, "GALUK"); }
        //public VolumeConverter FromGallonsUS(double v) { return StoreFromContext(this, v, GALUS, "GALUS"); }
        //public VolumeConverter FromGigaliters(double v) { return StoreFromContext(this, v, GL, "GL"); }
        //public VolumeConverter FromGillsUK(double v) { return StoreFromContext(this, v, GILUK, "GILUK"); }
        //public VolumeConverter FromGillsUS(double v) { return StoreFromContext(this, v, GILUS, "GILUS"); }
        //public VolumeConverter FromHectoliters(double v) { return StoreFromContext(this, v, HL, "HL"); }
        //public VolumeConverter FromHogsheads(double v) { return StoreFromContext(this, v, HOG, "HOG"); }
        //public VolumeConverter FromHundredCubicFeet(double v) { return StoreFromContext(this, v, CCF, "CCF"); }
        //public VolumeConverter FromKiloliters(double v) { return StoreFromContext(this, v, KL, "KL"); }
        //public VolumeConverter FromLiters(double v) { return StoreFromContext(this, v, L, "L"); }
        //public VolumeConverter FromMegaliters(double v) { return StoreFromContext(this, v, ML, "ML"); }
        //public VolumeConverter FromMicroliters(double v) { return StoreFromContext(this, v, MUL, "MUL"); }
        //public VolumeConverter FromMilliliters(double v) { return StoreFromContext(this, v, MILL, "MILL"); }
        //public VolumeConverter FromMinimsUK(double v) { return StoreFromContext(this, v, MINIUK, "MINIUK"); }
        //public VolumeConverter FromMinimsUS(double v) { return StoreFromContext(this, v, MINIUS, "MINIUS"); }
        //public VolumeConverter FromNanoliters(double v) { return StoreFromContext(this, v, NL, "NL"); }
        //public VolumeConverter FromPetaliters(double v) { return StoreFromContext(this, v, PEL, "PEL"); }
        //public VolumeConverter FromPicoliters(double v) { return StoreFromContext(this, v, PL, "PL"); }
        //public VolumeConverter FromPintsUK(double v) { return StoreFromContext(this, v, PTUK, "PTUK"); }
        //public VolumeConverter FromPintsUS(double v) { return StoreFromContext(this, v, PTUS, "PTUS"); }
        //public VolumeConverter FromQuartsUK(double v) { return StoreFromContext(this, v, QTUK, "QTUK"); }
        //public VolumeConverter FromQuartsUS(double v) { return StoreFromContext(this, v, QTUS, "QTUS"); }
        //public VolumeConverter FromRegisterTons(double v) { return StoreFromContext(this, v, REGTON, "REGTON"); }
        //public VolumeConverter FromSteres(double v) { return StoreFromContext(this, v, ST, "ST"); }
        //public VolumeConverter FromTablespoonsMetric(double v) { return StoreFromContext(this, v, TBSPM, "TBSPM"); }
        //public VolumeConverter FromTablespoonsUK(double v) { return StoreFromContext(this, v, TBSPUK, "TBSPUK"); }
        //public VolumeConverter FromTablespoonsUS(double v) { return StoreFromContext(this, v, TBSPUS, "TBSPUS"); }
        //public VolumeConverter FromTeaspoonsMetric(double v) { return StoreFromContext(this, v, TSPM, "TSPM"); }
        //public VolumeConverter FromTeaspoonsUK(double v) { return StoreFromContext(this, v, TSPUK, "TSPUK"); }
        //public VolumeConverter FromTeaspoonsUS(double v) { return StoreFromContext(this, v, TSPUS, "TSPUS"); }
        //public VolumeConverter FromTeraliters(double v) { return StoreFromContext(this, v, TL, "TL"); }
        //public VolumeConverter FromTuns(double v) { return StoreFromContext(this, v, TUN, "TUN"); }

        //public double ToAcreFeetUSSurvey() { return PerformConversion(ACFTUS); }
        //public double ToAcreInches() { return PerformConversion(ACIN); }
        //public double ToArceFeet() { return PerformConversion(ACFTO); }
        //public double ToAttoliters() { return PerformConversion(AL); }
        //public double ToBarrelsOfOil() { return PerformConversion(BBLO); }
        //public double ToBarrelsUK() { return PerformConversion(BBLUK); }
        //public double ToBarrelsUS() { return PerformConversion(BBLUS); }
        //public double ToBoardFeet() { return PerformConversion(FBM); }
        //public double ToCentiliters() { return PerformConversion(CL); }
        //public double ToCords() { return PerformConversion(CORD); }
        //public double ToCubicCentimeters() { return PerformConversion(CM); }
        //public double ToCubicDecimeters() { return PerformConversion(DM); }
        //public double ToCubicFeet() { return PerformConversion(FT); }
        //public double ToCubicInches() { return PerformConversion(IN); }
        //public double ToCubicKilometers() { return PerformConversion(KM); }
        //public double ToCubicMeters() { return PerformConversion(M); }
        //public double ToCubicMiles() { return PerformConversion(MI); }
        //public double ToCubicMillimeters() { return PerformConversion(MM); }
        //public double ToCubicYards() { return PerformConversion(YD); }
        //public double ToCupsMetric() { return PerformConversion(CUPM); }
        //public double ToCupsUK() { return PerformConversion(CUPUK); }
        //public double ToCupsUS() { return PerformConversion(CUPUS); }
        //public double ToDeciliters() { return PerformConversion(DL); }
        //public double ToDecisteres() { return PerformConversion(DECI); }
        //public double ToDekaliters() { return PerformConversion(DAL); }
        //public double ToDekasteres() { return PerformConversion(DEKA); }
        //public double ToDessertspoonsUK() { return PerformConversion(DSTSPNUK); }
        //public double ToDessertspoonsUS() { return PerformConversion(DSTSPNUS); }
        //public double ToDrops() { return PerformConversion(DROP); }
        //public double ToExaliters() { return PerformConversion(EL); }
        //public double ToFemtoliters() { return PerformConversion(FL); }
        //public double ToFluidOuncesUK() { return PerformConversion(FLOZUK); }
        //public double ToFluidOuncesUS() { return PerformConversion(FLOZUS); }
        //public double ToGallonsUK() { return PerformConversion(GALUK); }
        //public double ToGallonsUS() { return PerformConversion(GALUS); }
        //public double ToGigaliters() { return PerformConversion(GL); }
        //public double ToGillsUK() { return PerformConversion(GILUK); }
        //public double ToGillsUS() { return PerformConversion(GILUS); }
        //public double ToHectoliters() { return PerformConversion(HL); }
        //public double ToHogsheads() { return PerformConversion(HOG); }
        //public double ToHundredCubicFeet() { return PerformConversion(CCF); }
        //public double ToKiloliters() { return PerformConversion(KL); }
        //public double ToLiters() { return PerformConversion(L); }
        //public double ToMegaliters() { return PerformConversion(ML); }
        //public double ToMicroliters() { return PerformConversion(MUL); }
        //public double ToMilliliters() { return PerformConversion(MILL); }
        //public double ToMinimsUK() { return PerformConversion(MINIUK); }
        //public double ToMinimsUS() { return PerformConversion(MINIUS); }
        //public double ToNanoliters() { return PerformConversion(NL); }
        //public double ToPetaliters() { return PerformConversion(PEL); }
        //public double ToPicoliters() { return PerformConversion(PL); }
        //public double ToPintsUK() { return PerformConversion(PTUK); }
        //public double ToPintsUS() { return PerformConversion(PTUS); }
        //public double ToQuartsUK() { return PerformConversion(QTUK); }
        //public double ToQuartsUS() { return PerformConversion(QTUS); }
        //public double ToRegisterTons() { return PerformConversion(REGTON); }
        //public double ToSteres() { return PerformConversion(ST); }
        //public double ToTablespoonsMetric() { return PerformConversion(TBSPM); }
        //public double ToTablespoonsUK() { return PerformConversion(TBSPUK); }
        //public double ToTablespoonsUS() { return PerformConversion(TBSPUS); }
        //public double ToTeaspoonsMetric() { return PerformConversion(TSPM); }
        //public double ToTeaspoonsUK() { return PerformConversion(TSPUK); }
        //public double ToTeaspoonsUS() { return PerformConversion(TSPUS); }
        //public double ToTeraliters() { return PerformConversion(TL); }
        //public double ToTuns() { return PerformConversion(TUN); }
        #endregion
    }



}