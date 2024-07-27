using System;

namespace WonderCircuits.UnitOf
{
    public class LengthConverter : BaseNumberConverter
    {
        private static readonly double A = 1e10;                     //Angstrom
        private static readonly double AM = 1e18;                    //Attometer 
        private static readonly double BC = 1 / (0.2286 / 27.0);         //Barleycorn 
        private static readonly double CBLIMP = 1 / 185.3184;          //Cable LengthConverter (Imperial)
        private static readonly double CBLIN = 1 / 185.2;              //Cable LengthConverter (International)
        private static readonly double CBLUS = 1 / 219.456;            //Cable LengthConverter (US)
        private static readonly double CL = 1 / 0.000254;              //Caliber 
        private static readonly double CIN = 1 / 0.000254;             //Centiinch 
        private static readonly double CM = 1e2;                     //Centimeter 
        private static readonly double CH = 1 / 20.1168;               //Chain 
        private static readonly double CU = 1 / 0.4572;                //Cubit
        private static readonly double DM = 1e1;                     //Decimeter 
        private static readonly double DAM = 1e-1;                   //Dekameter
        private static readonly double ELL = 1 / 1.143;                //Ell
        private static readonly double EM = 1e-18;                   //Exameter 
        private static readonly double FTM = 1 / 1.8288;               //Fathom 
        private static readonly double FT = 1 / 0.3048;                //Foot 
        private static readonly double FM = 1e15;                    //Femtometer 
        private static readonly double FING = 1 / 0.1143;              //Finger 
        private static readonly double FUR = 1 / 201.168;              //Furlong 
        private static readonly double GM = 1e-9;                    //Gigameter 
        private static readonly double HAND = 1 / 0.1016;              //Hand 
        private static readonly double HM = 1e-2;                    //Hectometer 
        private static readonly double IN = 1 / 0.0254;                //Inch 
        private static readonly double KM = 1e-3;                    //Kilometer 
        private static readonly double KYD = 1 / 914.4;                //Kiloyard 
        private static readonly double LEA = 1 / 4828.032;             //League 
        private static readonly double LY = 1 / 9.46073047258e15;      //Lightyear
        private static readonly double LNK = 1 / 0.201168;             //Link 
        private static readonly double MM = 1e-6;                    //Megameter
        private static readonly double M = 1;                        //Meter 
        private static readonly double MUIN = 1 / (0.0000254 / 1000.0);  //Microinch 
        private static readonly double MUM = 1e6;                    //Micrometer 
        private static readonly double MURM = 1e6;                   //Micron 
        private static readonly double MI = 1 / 1609.344;              //Mile 
        private static readonly double MILM = 1e3;                   //Millimeter
        private static readonly double NAIL = 1 / 0.05715;             //Nail 
        private static readonly double NM = 1e9;                     //Nanometer 
        private static readonly double NLEAIN = 1 / 5556.0;            //Nautical League (International) 
        private static readonly double NLEAUK = 1 / 5559.552;          //Nautical League (UK)
        private static readonly double NMIINT = 1 / 1852.0;            //Nautical Mile (International)
        private static readonly double NMIUK = 1 / 1853.184;           //Nautical Mile (UK)
        private static readonly double NMIUS = 1 / 1853.248;           //Nautical Mile (US) 
        private static readonly double PER = 1 / 5.0292;               //Perch
        private static readonly double PEM = 1e-15;                  //Petameter 
        private static readonly double PM = 1e12;                    //Picometer 
        private static readonly double POL = 1 / 5.0292;               //Pole
        private static readonly double RD = 1 / 5.0292;                //Rod
        private static readonly double ROPE = 1 / 6.096;               //Rope 
        private static readonly double SPAN = 1 / 0.2286;              //Span 
        private static readonly double TM = 1e-12;                   //Terameter 
        private static readonly double TIN = 1 / 0.0000254;            //Thousandth of Inch
        private static readonly double YD = 1 / 0.9144;                //Yard
        public LengthConverter()
        {

        }
        public LengthConverter(double value, LengthUnits units) : base(BuildFromContext(value, units))
        {

        }

        public LengthConverter From(double value, LengthUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(LengthUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(LengthUnits units)
        {
            switch (units)
            {
                case LengthUnits.Angstroms: { return (A); }
                case LengthUnits.Attometers: { return (AM); }
                case LengthUnits.Barleycorns: { return (BC); }
                case LengthUnits.CablesImperial: { return (CBLIMP); }
                case LengthUnits.CablesInternational: { return (CBLIN); }
                case LengthUnits.CablesUSCustomary: { return (CBLUS); }
                case LengthUnits.Caliber: { return (CL); }
                case LengthUnits.CentiInches: { return (CIN); }
                case LengthUnits.Centimeters: { return (CM); }
                case LengthUnits.Chains: { return (CH); }
                case LengthUnits.Cubits: { return (CU); }
                case LengthUnits.Decimeters: { return (DM); }
                case LengthUnits.Dekameters: { return (DAM); }
                case LengthUnits.Ells: { return (ELL); }
                case LengthUnits.Exameters: { return (EM); }
                case LengthUnits.Fathoms: { return (FTM); }
                case LengthUnits.Feet: { return (FT); }
                case LengthUnits.Femtometers: { return (FM); }
                case LengthUnits.Fingers: { return (FING); }
                case LengthUnits.Furlongs: { return (FUR); }
                case LengthUnits.Gigameters: { return (GM); }
                case LengthUnits.Hands: { return (HAND); }
                case LengthUnits.Hectometers: { return (HM); }
                case LengthUnits.Inches: { return (IN); }
                case LengthUnits.Kilometers: { return (KM); }
                case LengthUnits.Kiloyards: { return (KYD); }
                case LengthUnits.Leagues: { return (LEA); }
                case LengthUnits.LightYears: { return (LY); }
                case LengthUnits.Links: { return (LNK); }
                case LengthUnits.Megameters: { return (MM); }
                case LengthUnits.Meters: { return (M); }
                case LengthUnits.MicroInches: { return (MUIN); }
                case LengthUnits.Micrometers: { return (MUM); }
                case LengthUnits.Microns: { return (MURM); }
                case LengthUnits.Miles: { return (MI); }
                case LengthUnits.Millimeters: { return (MILM); }
                case LengthUnits.Nails: { return (NAIL); }
                case LengthUnits.Nanometers: { return (NM); }
                case LengthUnits.NauticalLeaguesInternational: { return (NLEAIN); }
                case LengthUnits.NauticalLeaguesUK: { return (NLEAUK); }
                case LengthUnits.NauticalMilesInternational: { return (NMIINT); }
                case LengthUnits.NauticalMilesUK: { return (NMIUK); }
                case LengthUnits.NauticalMilesUSCustomary: { return (NMIUS); }
                case LengthUnits.Perches: { return (PER); }
                case LengthUnits.Petameters: { return (PEM); }
                case LengthUnits.Picometers: { return (PM); }
                case LengthUnits.Poles: { return (POL); }
                case LengthUnits.Rods: { return (RD); }
                case LengthUnits.Ropes: { return (ROPE); }
                case LengthUnits.Spans: { return (SPAN); }
                case LengthUnits.Terameters: { return (TM); }
                case LengthUnits.ThousandthInches: { return (TIN); }
                case LengthUnits.Yards: { return (YD); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, LengthUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class LengthConverterExtensions
    {
        #region From & To Methods
        //public LengthConverter FromAngstroms(double v) { return StoreFromContext(this, v, A, "NumberConverterContext"); }
        //public LengthConverter FromAttometers(double v) { return StoreFromContext(this, v, AM, "AM"); }
        //public LengthConverter FromBarleycorns(double v) { return StoreFromContext(this, v, BC, "BC"); }
        //public LengthConverter FromCablesImperial(double v) { return StoreFromContext(this, v, CBLIMP, "CBLIMP"); }
        //public LengthConverter FromCablesInternational(double v) { return StoreFromContext(this, v, CBLIN, "CBLIN"); }
        //public LengthConverter FromCablesUSCustomary(double v) { return StoreFromContext(this, v, CBLUS, "CBLUS"); }
        //public LengthConverter FromCaliber(double v) { return StoreFromContext(this, v, CL, "CL"); }
        //public LengthConverter FromCentiInches(double v) { return StoreFromContext(this, v, CIN, "CIN"); }
        //public LengthConverter FromCentimeters(double v) { return StoreFromContext(this, v, CM, "CM"); }
        //public LengthConverter FromChains(double v) { return StoreFromContext(this, v, CH, "CH"); }
        //public LengthConverter FromCubits(double v) { return StoreFromContext(this, v, CU, "CU"); }
        //public LengthConverter FromDecimeters(double v) { return StoreFromContext(this, v, DM, "DM"); }
        //public LengthConverter FromDekameters(double v) { return StoreFromContext(this, v, DAM, "DAM"); }
        //public LengthConverter FromElls(double v) { return StoreFromContext(this, v, ELL, "ELL"); }
        //public LengthConverter FromExameters(double v) { return StoreFromContext(this, v, EM, "EM"); }
        //public LengthConverter FromFathoms(double v) { return StoreFromContext(this, v, FTM, "FTM"); }
        //public LengthConverter FromFeet(double v) { return StoreFromContext(this, v, FT, "FT"); }
        //public LengthConverter FromFemtometers(double v) { return StoreFromContext(this, v, FM, "FM"); }
        //public LengthConverter FromFingers(double v) { return StoreFromContext(this, v, FING, "FING"); }
        //public LengthConverter FromFurlongs(double v) { return StoreFromContext(this, v, FUR, "FUR"); }
        //public LengthConverter FromGigameters(double v) { return StoreFromContext(this, v, GM, "GM"); }
        //public LengthConverter FromHands(double v) { return StoreFromContext(this, v, HAND, "HAND"); }
        //public LengthConverter FromHectometers(double v) { return StoreFromContext(this, v, HM, "HM"); }
        //public LengthConverter FromInches(double v) { return StoreFromContext(this, v, IN, "IN"); }
        //public LengthConverter FromKilometers(double v) { return StoreFromContext(this, v, KM, "KM"); }
        //public LengthConverter FromKiloyards(double v) { return StoreFromContext(this, v, KYD, "KYD"); }
        //public LengthConverter FromLeagues(double v) { return StoreFromContext(this, v, LEA, "LEA"); }
        //public LengthConverter FromLightYears(double v) { return StoreFromContext(this, v, LY, "LY"); }
        //public LengthConverter FromLinks(double v) { return StoreFromContext(this, v, LNK, "LNK"); }
        //public LengthConverter FromMegameters(double v) { return StoreFromContext(this, v, MM, "MM"); }
        //public LengthConverter FromMeters(double v) { return StoreFromContext(this, v, M, "M"); }
        //public LengthConverter FromMicroInches(double v) { return StoreFromContext(this, v, MUIN, "MUIN"); }
        //public LengthConverter FromMicrometers(double v) { return StoreFromContext(this, v, MUM, "MUM"); }
        //public LengthConverter FromMicrons(double v) { return StoreFromContext(this, v, MURM, "MURM"); }
        //public LengthConverter FromMiles(double v) { return StoreFromContext(this, v, MI, "MI"); }
        //public LengthConverter FromMillimeters(double v) { return StoreFromContext(this, v, MILM, "MILM"); }
        //public LengthConverter FromNails(double v) { return StoreFromContext(this, v, NAIL, "NAIL"); }
        //public LengthConverter FromNanometers(double v) { return StoreFromContext(this, v, NM, "NM"); }
        //public LengthConverter FromNauticalLeaguesInternational(double v) { return StoreFromContext(this, v, NLEAIN, "NLEAIN"); }
        //public LengthConverter FromNauticalLeaguesUK(double v) { return StoreFromContext(this, v, NLEAUK, "NLEAUK"); }
        //public LengthConverter FromNauticalMilesInternational(double v) { return StoreFromContext(this, v, NMIINT, "NMIINT"); }
        //public LengthConverter FromNauticalMilesUK(double v) { return StoreFromContext(this, v, NMIUK, "NMIUK"); }
        //public LengthConverter FromNauticalMilesUSCustomary(double v) { return StoreFromContext(this, v, NMIUS, "NMIUS"); }
        //public LengthConverter FromPerches(double v) { return StoreFromContext(this, v, PER, "PER"); }
        //public LengthConverter FromPetameters(double v) { return StoreFromContext(this, v, PEM, "PEM"); }
        //public LengthConverter FromPicometers(double v) { return StoreFromContext(this, v, PM, "PM"); }
        //public LengthConverter FromPoles(double v) { return StoreFromContext(this, v, POL, "POL"); }
        //public LengthConverter FromRods(double v) { return StoreFromContext(this, v, RD, "RD"); }
        //public LengthConverter FromRopes(double v) { return StoreFromContext(this, v, ROPE, "ROPE"); }
        //public LengthConverter FromSpans(double v) { return StoreFromContext(this, v, SPAN, "SPAN"); }
        //public LengthConverter FromTerameters(double v) { return StoreFromContext(this, v, TM, "TM"); }
        //public LengthConverter FromThousandthInches(double v) { return StoreFromContext(this, v, TIN, "TIN"); }
        //public LengthConverter FromYards(double v) { return StoreFromContext(this, v, YD, "YD"); }


        //public double ToAngstroms() { return PerformConversion(A); }
        //public double ToAttometers() { return PerformConversion(AM); }
        //public double ToBarleycorns() { return PerformConversion(BC); }
        //public double ToCablesImperial() { return PerformConversion(CBLIMP); }
        //public double ToCablesInternational() { return PerformConversion(CBLIN); }
        //public double ToCablesUSCustomary() { return PerformConversion(CBLUS); }
        //public double ToCaliber() { return PerformConversion(CL); }
        //public double ToCentiInches() { return PerformConversion(CIN); }
        //public double ToCentimeters() { return PerformConversion(CM); }
        //public double ToChains() { return PerformConversion(CH); }
        //public double ToCubits() { return PerformConversion(CU); }
        //public double ToDecimeters() { return PerformConversion(DM); }
        //public double ToDekameters() { return PerformConversion(DAM); }
        //public double ToElls() { return PerformConversion(ELL); }
        //public double ToExameters() { return PerformConversion(EM); }
        //public double ToFathoms() { return PerformConversion(FTM); }
        //public double ToFeet() { return PerformConversion(FT); }
        //public double ToFemtometers() { return PerformConversion(FM); }
        //public double ToFingers() { return PerformConversion(FING); }
        //public double ToFurlongs() { return PerformConversion(FUR); }
        //public double ToGigameters() { return PerformConversion(GM); }
        //public double ToHands() { return PerformConversion(HAND); }
        //public double ToHectometers() { return PerformConversion(HM); }
        //public double ToInches() { return PerformConversion(IN); }
        //public double ToKilometers() { return PerformConversion(KM); }
        //public double ToKiloyards() { return PerformConversion(KYD); }
        //public double ToLeagues() { return PerformConversion(LEA); }
        //public double ToLightYears() { return PerformConversion(LY); }
        //public double ToLinks() { return PerformConversion(LNK); }
        //public double ToMegameters() { return PerformConversion(MM); }
        //public double ToMeters() { return PerformConversion(M); }
        //public double ToMicroInches() { return PerformConversion(MUIN); }
        //public double ToMicrometers() { return PerformConversion(MUM); }
        //public double ToMicrons() { return PerformConversion(MURM); }
        //public double ToMiles() { return PerformConversion(MI); }
        //public double ToMillimeters() { return PerformConversion(MILM); }
        //public double ToNails() { return PerformConversion(NAIL); }
        //public double ToNanometers() { return PerformConversion(NM); }
        //public double ToNauticalLeaguesInternational() { return PerformConversion(NLEAIN); }
        //public double ToNauticalLeaguesUK() { return PerformConversion(NLEAUK); }
        //public double ToNauticalMilesInternational() { return PerformConversion(NMIINT); }
        //public double ToNauticalMilesUK() { return PerformConversion(NMIUK); }
        //public double ToNauticalMilesUSCustomary() { return PerformConversion(NMIUS); }
        //public double ToPerches() { return PerformConversion(PER); }
        //public double ToPetameters() { return PerformConversion(PEM); }
        //public double ToPicometers() { return PerformConversion(PM); }
        //public double ToPoles() { return PerformConversion(POL); }
        //public double ToRods() { return PerformConversion(RD); }
        //public double ToRopes() { return PerformConversion(ROPE); }
        //public double ToSpans() { return PerformConversion(SPAN); }
        //public double ToTerameters() { return PerformConversion(TM); }
        //public double ToThousandthInches() { return PerformConversion(TIN); }
        //public double ToYards() { return PerformConversion(YD); }
        #endregion
    }


}