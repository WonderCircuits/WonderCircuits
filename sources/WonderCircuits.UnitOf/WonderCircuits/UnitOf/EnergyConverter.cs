using System;

namespace WonderCircuits.UnitOf
{
    public class EnergyConverter : BaseNumberConverter
    {
        private static readonly double AJ = 1e18;                    //Attojoule 
        private static readonly double BTU = 1 / 1055.05585262;        //British Thermal Unit 
        private static readonly double BTUTH = 1 / 1054.349999974;     //Thermochemical British Thermal Unit  
        private static readonly double BOE = 1 / 61178632e2;           //Barrel of Oil Equivalent
        private static readonly double CALIT = 1 / 4.1868;             //Calorie (International Steam)
        private static readonly double CALN = 1 / 4186.8;              //Calorie (Nutritional)
        private static readonly double CALTH = 1 / 4.184;              //Calorie (Thermochemical)
        private static readonly double DYNCM = 1 / 1e-7;               //Dyne Centimeter 
        private static readonly double EV = 1 / 1.60217733e-19;        //Electron Volt
        private static readonly double ERG = 1e7;                    //Erg 
        private static readonly double FTLBF = 0.737562149;          //Foot Pound
        private static readonly double GJ = 1e-9;                    //Gigajoule 
        private static readonly double GT = 1 / 4.184e18;              //Gigaton of TNT
        private static readonly double GWH = 1 / 36e11;                //Gigawatt Hour
        private static readonly double GFCM = 10197.16213009;        //Gram ForceConverter Centimeter
        private static readonly double GFM = 101.9716213009;         //Gram ForceConverter Meter
        private static readonly double H = 1 / 4.3597482e-18;          //Hartree EnergyConverter
        private static readonly double HPH = 1 / 2684519.537696172792; //Horsepower Hour
        private static readonly double HPHM = 1 / 2647795.5;           //Horsepower Hour (Metric)
        private static readonly double INOZF = 141.611932666;        //Inch Ounce
        private static readonly double INLBF = 8.850745792;          //Inch Pound
        private static readonly double J = 1;                        //Joule 
        private static readonly double KCALIT = 1 / 4186.8;            //Kilocalorie (International Steam)
        private static readonly double KCALTH = 1 / 4184.0;            //Kilocalorie (Thermochemical)
        private static readonly double KEV = 1 / 1.60217733e-16;       //Kiloelectron Volt
        private static readonly double KGFCM = 10.19716213009;       //Kilogram ForceConverter Centimeter
        private static readonly double KGFM = 0.1019716213009;       //Kilogram ForceConverter Meter
        private static readonly double KGT = 1 / 4184e3;               //Kilogram of TNT 
        private static readonly double KJ = 1e-3;                    //Kilojoule 
        private static readonly double KPM = 0.1019716213009;        //Kilopond Meter
        private static readonly double KT = 1 / 4.184e12;              //Kiloton of TNT
        private static readonly double KWH = 1 / 36e5;                 //Kilowatt Hour
        private static readonly double KWS = 1e-3;                   //Kilowatt Second
        private static readonly double LA = 1 / 101.325;               //Liter Atmosphere
        private static readonly double MBTU = 1 / 1055055852.62;       //Mega British Thermal Unit
        private static readonly double MEV = 1 / 1.60217733e-13;       //Megaelectron Volt
        private static readonly double MJ = 1e-6;                    //Megajoule 
        private static readonly double MT = 1 / 4.184e15;              //Megaton of TNT
        private static readonly double MWH = 1 / 36e8;                 //Megawatt Hour
        private static readonly double MUJ = 1e6;                    //Microjoule 
        private static readonly double MILJ = 1e3;                   //Millijoule 
        private static readonly double NJ = 1e9;                     //Nanojoule 
        private static readonly double NM = 1;                       //Newton Meter
        private static readonly double EP = 1 / 19561e5;               //Planck EnergyConverter
        private static readonly double PDLFT = 1 / 0.04214011;         //Poundal Foot
        private static readonly double RY = 1 / 2.179872e-18;          //Rydberg
        private static readonly double THMEC = 1 / 105505600.0;        //Therm (EC)
        private static readonly double THMUS = 1 / 105480400.0;        //Therm (US)
        private static readonly double TT = 1 / 4184e6;                //Ton of TNT
        private static readonly double WH = 1 / 36e2;                  //Watt Hour
        private static readonly double WS = 1;                       //Watt Second   
        public EnergyConverter()
        {

        }
        public EnergyConverter(double value, EnergyUnits units) : base(BuildFromContext(value, units))
        {

        }

        public EnergyConverter From(double value, EnergyUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(EnergyUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(EnergyUnits units)
        {
            switch (units)
            {
                case EnergyUnits.Attojoules: { return (AJ); }
                case EnergyUnits.BTUsInternationalStandard: { return (BTU); }
                case EnergyUnits.BTUsThermochemical: { return (BTUTH); }
                case EnergyUnits.BarrelsOfOilEquivalent: { return (BOE); }
                case EnergyUnits.CaloriesInternationalSteam: { return (CALIT); }
                case EnergyUnits.CaloriesNutritional: { return (CALN); }
                case EnergyUnits.CaloriesThermochemical: { return (CALTH); }
                case EnergyUnits.DyneCentimeters: { return (DYNCM); }
                case EnergyUnits.ElectronVolts: { return (EV); }
                case EnergyUnits.Ergs: { return (ERG); }
                case EnergyUnits.FootPounds: { return (FTLBF); }
                case EnergyUnits.Gigajoules: { return (GJ); }
                case EnergyUnits.GigatonsOfTNT: { return (GT); }
                case EnergyUnits.GigawattHours: { return (GWH); }
                case EnergyUnits.GramForceCentimeters: { return (GFCM); }
                case EnergyUnits.GramForceMeters: { return (GFM); }
                case EnergyUnits.Hartrees: { return (H); }
                case EnergyUnits.HorsepowerHours: { return (HPH); }
                case EnergyUnits.HorsepowerHoursMetric: { return (HPHM); }
                case EnergyUnits.InchOunces: { return (INOZF); }
                case EnergyUnits.InchPounds: { return (INLBF); }
                case EnergyUnits.Joules: { return (J); }
                case EnergyUnits.KilocaloriesInternationalSteam: { return (KCALIT); }
                case EnergyUnits.KilocaloriesThermochemical: { return (KCALTH); }
                case EnergyUnits.KiloelectronVolts: { return (KEV); }
                case EnergyUnits.KilogramForceCentimeters: { return (KGFCM); }
                case EnergyUnits.KilogramForceMeters: { return (KGFM); }
                case EnergyUnits.KilogramsOfTNT: { return (KGT); }
                case EnergyUnits.Kilojoules: { return (KJ); }
                case EnergyUnits.KilopondMeters: { return (KPM); }
                case EnergyUnits.KilotonsOfTNT: { return (KT); }
                case EnergyUnits.KilowattHours: { return (KWH); }
                case EnergyUnits.KilowattSeconds: { return (KWS); }
                case EnergyUnits.LiterAtmospheres: { return (LA); }
                case EnergyUnits.MegaBTUsInternationalStandard: { return (MBTU); }
                case EnergyUnits.MegaelectronVolts: { return (MEV); }
                case EnergyUnits.Megajoules: { return (MJ); }
                case EnergyUnits.MegatonsOfTNT: { return (MT); }
                case EnergyUnits.MegawattHours: { return (MWH); }
                case EnergyUnits.Microjoules: { return (MUJ); }
                case EnergyUnits.Millijoules: { return (MILJ); }
                case EnergyUnits.Nanojoules: { return (NJ); }
                case EnergyUnits.NewtonMeters: { return (NM); }
                case EnergyUnits.PlanckEnergy: { return (EP); }
                case EnergyUnits.PoundalFeet: { return (PDLFT); }
                case EnergyUnits.Rydbergs: { return (RY); }
                case EnergyUnits.ThermsEC: { return (THMEC); }
                case EnergyUnits.ThermsUS: { return (THMUS); }
                case EnergyUnits.TonsOfTNT: { return (TT); }
                case EnergyUnits.WattHours: { return (WH); }
                case EnergyUnits.WattSeconds: { return (WS); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, EnergyUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class EnergyConverterExtensions
    {
        #region From & To Methods
        //public EnergyConverter FromAttojoules(double v) { return StoreFromContext(this, v, AJ, "AJ"); }
        //public EnergyConverter FromBTUsInternationalStandard(double v) { return StoreFromContext(this, v, BTU, "BTU"); }
        //public EnergyConverter FromBTUsThermochemical(double v) { return StoreFromContext(this, v, BTUTH, "BTUTH"); }
        //public EnergyConverter FromBarrelsOfOilEquivalent(double v) { return StoreFromContext(this, v, BOE, "BOE"); }
        //public EnergyConverter FromCaloriesInternationalSteam(double v) { return StoreFromContext(this, v, CALIT, "CALIT"); }
        //public EnergyConverter FromCaloriesNutritional(double v) { return StoreFromContext(this, v, CALN, "CALN"); }
        //public EnergyConverter FromCaloriesThermochemical(double v) { return StoreFromContext(this, v, CALTH, "CALTH"); }
        //public EnergyConverter FromDyneCentimeters(double v) { return StoreFromContext(this, v, DYNCM, "DYNCM"); }
        //public EnergyConverter FromElectronVolts(double v) { return StoreFromContext(this, v, EV, "EV"); }
        //public EnergyConverter FromErgs(double v) { return StoreFromContext(this, v, ERG, "ERG"); }
        //public EnergyConverter FromFootPounds(double v) { return StoreFromContext(this, v, FTLBF, "FTLBF"); }
        //public EnergyConverter FromGigajoules(double v) { return StoreFromContext(this, v, GJ, "GJ"); }
        //public EnergyConverter FromGigatonsOfTNT(double v) { return StoreFromContext(this, v, GT, "GT"); }
        //public EnergyConverter FromGigawattHours(double v) { return StoreFromContext(this, v, GWH, "GWH"); }
        //public EnergyConverter FromGramForceCentimeters(double v) { return StoreFromContext(this, v, GFCM, "GFCM"); }
        //public EnergyConverter FromGramForceMeters(double v) { return StoreFromContext(this, v, GFM, "GFM"); }
        //public EnergyConverter FromHartrees(double v) { return StoreFromContext(this, v, H, "H"); }
        //public EnergyConverter FromHorsepowerHours(double v) { return StoreFromContext(this, v, HPH, "HPH"); }
        //public EnergyConverter FromHorsepowerHoursMetric(double v) { return StoreFromContext(this, v, HPHM, "HPHM"); }
        //public EnergyConverter FromInchOunces(double v) { return StoreFromContext(this, v, INOZF, "INOZF"); }
        //public EnergyConverter FromInchPounds(double v) { return StoreFromContext(this, v, INLBF, "INLBF"); }
        //public EnergyConverter FromJoules(double v) { return StoreFromContext(this, v, J, "J"); }
        //public EnergyConverter FromKilocaloriesInternationalSteam(double v) { return StoreFromContext(this, v, KCALIT, "KCALIT"); }
        //public EnergyConverter FromKilocaloriesThermochemical(double v) { return StoreFromContext(this, v, KCALTH, "KCALTH"); }
        //public EnergyConverter FromKiloelectronVolts(double v) { return StoreFromContext(this, v, KEV, "KEV"); }
        //public EnergyConverter FromKilogramForceCentimeters(double v) { return StoreFromContext(this, v, KGFCM, "KGFCM"); }
        //public EnergyConverter FromKilogramForceMeters(double v) { return StoreFromContext(this, v, KGFM, "KGFM"); }
        //public EnergyConverter FromKilogramsOfTNT(double v) { return StoreFromContext(this, v, KGT, "KGT"); }
        //public EnergyConverter FromKilojoules(double v) { return StoreFromContext(this, v, KJ, "KJ"); }
        //public EnergyConverter FromKilopondMeters(double v) { return StoreFromContext(this, v, KPM, "KPM"); }
        //public EnergyConverter FromKilotonsOfTNT(double v) { return StoreFromContext(this, v, KT, "KT"); }
        //public EnergyConverter FromKilowattHours(double v) { return StoreFromContext(this, v, KWH, "KWH"); }
        //public EnergyConverter FromKilowattSeconds(double v) { return StoreFromContext(this, v, KWS, "KWS"); }
        //public EnergyConverter FromLiterAtmospheres(double v) { return StoreFromContext(this, v, LA, "LA"); }
        //public EnergyConverter FromMegaBTUsInternationalStandard(double v) { return StoreFromContext(this, v, MBTU, "MBTU"); }
        //public EnergyConverter FromMegaelectronVolts(double v) { return StoreFromContext(this, v, MEV, "MEV"); }
        //public EnergyConverter FromMegajoules(double v) { return StoreFromContext(this, v, MJ, "MJ"); }
        //public EnergyConverter FromMegatonsOfTNT(double v) { return StoreFromContext(this, v, MT, "MT"); }
        //public EnergyConverter FromMegawattHours(double v) { return StoreFromContext(this, v, MWH, "MWH"); }
        //public EnergyConverter FromMicrojoules(double v) { return StoreFromContext(this, v, MUJ, "MUJ"); }
        //public EnergyConverter FromMillijoules(double v) { return StoreFromContext(this, v, MILJ, "MILJ"); }
        //public EnergyConverter FromNanojoules(double v) { return StoreFromContext(this, v, NJ, "NJ"); }
        //public EnergyConverter FromNewtonMeters(double v) { return StoreFromContext(this, v, NM, "NM"); }
        //public EnergyConverter FromPlanckEnergy(double v) { return StoreFromContext(this, v, EP, "EP"); }
        //public EnergyConverter FromPoundalFeet(double v) { return StoreFromContext(this, v, PDLFT, "PDLFT"); }
        //public EnergyConverter FromRydbergs(double v) { return StoreFromContext(this, v, RY, "RY"); }
        //public EnergyConverter FromThermsEC(double v) { return StoreFromContext(this, v, THMEC, "THMEC"); }
        //public EnergyConverter FromThermsUS(double v) { return StoreFromContext(this, v, THMUS, "THMUS"); }
        //public EnergyConverter FromTonsOfTNT(double v) { return StoreFromContext(this, v, TT, "TT"); }
        //public EnergyConverter FromWattHours(double v) { return StoreFromContext(this, v, WH, "WH"); }
        //public EnergyConverter FromWattSeconds(double v) { return StoreFromContext(this, v, WS, "WS"); }


        //public double ToAttojoules() { return PerformConversion(AJ); }
        //public double ToBTUsInternationalStandard() { return PerformConversion(BTU); }
        //public double ToBTUsThermochemical() { return PerformConversion(BTUTH); }
        //public double ToBarrelsOfOilEquivalent() { return PerformConversion(BOE); }
        //public double ToCaloriesInternationalSteam() { return PerformConversion(CALIT); }
        //public double ToCaloriesNutritional() { return PerformConversion(CALN); }
        //public double ToCaloriesThermochemical() { return PerformConversion(CALTH); }
        //public double ToDyneCentimeters() { return PerformConversion(DYNCM); }
        //public double ToElectronVolts() { return PerformConversion(EV); }
        //public double ToErgs() { return PerformConversion(ERG); }
        //public double ToFootPounds() { return PerformConversion(FTLBF); }
        //public double ToGigajoules() { return PerformConversion(GJ); }
        //public double ToGigatonsOfTNT() { return PerformConversion(GT); }
        //public double ToGigawattHours() { return PerformConversion(GWH); }
        //public double ToGramForceCentimeters() { return PerformConversion(GFCM); }
        //public double ToGramForceMeters() { return PerformConversion(GFM); }
        //public double ToHartrees() { return PerformConversion(H); }
        //public double ToHorsepowerHours() { return PerformConversion(HPH); }
        //public double ToHorsepowerHoursMetric() { return PerformConversion(HPHM); }
        //public double ToInchOunces() { return PerformConversion(INOZF); }
        //public double ToInchPounds() { return PerformConversion(INLBF); }
        //public double ToJoules() { return PerformConversion(J); }
        //public double ToKilocaloriesInternationalSteam() { return PerformConversion(KCALIT); }
        //public double ToKilocaloriesThermochemical() { return PerformConversion(KCALTH); }
        //public double ToKiloelectronVolts() { return PerformConversion(KEV); }
        //public double ToKilogramForceCentimeters() { return PerformConversion(KGFCM); }
        //public double ToKilogramForceMeters() { return PerformConversion(KGFM); }
        //public double ToKilogramsOfTNT() { return PerformConversion(KGT); }
        //public double ToKilojoules() { return PerformConversion(KJ); }
        //public double ToKilopondMeters() { return PerformConversion(KPM); }
        //public double ToKilotonsOfTNT() { return PerformConversion(KT); }
        //public double ToKilowattHours() { return PerformConversion(KWH); }
        //public double ToKilowattSeconds() { return PerformConversion(KWS); }
        //public double ToLiterAtmospheres() { return PerformConversion(LA); }
        //public double ToMegaBTUsInternationalStandard() { return PerformConversion(MBTU); }
        //public double ToMegaelectronVolts() { return PerformConversion(MEV); }
        //public double ToMegajoules() { return PerformConversion(MJ); }
        //public double ToMegatonsOfTNT() { return PerformConversion(MT); }
        //public double ToMegawattHours() { return PerformConversion(MWH); }
        //public double ToMicrojoules() { return PerformConversion(MUJ); }
        //public double ToMillijoules() { return PerformConversion(MILJ); }
        //public double ToNanojoules() { return PerformConversion(NJ); }
        //public double ToNewtonMeters() { return PerformConversion(NM); }
        //public double ToPlanckEnergy() { return PerformConversion(EP); }
        //public double ToPoundalFeet() { return PerformConversion(PDLFT); }
        //public double ToRydbergs() { return PerformConversion(RY); }
        //public double ToThermsEC() { return PerformConversion(THMEC); }
        //public double ToThermsUS() { return PerformConversion(THMUS); }
        //public double ToTonsOfTNT() { return PerformConversion(TT); }
        //public double ToWattHours() { return PerformConversion(WH); }
        //public double ToWattSeconds() { return PerformConversion(WS); }

        #endregion
    }



}