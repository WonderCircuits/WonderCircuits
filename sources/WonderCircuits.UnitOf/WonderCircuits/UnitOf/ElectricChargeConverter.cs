using System;

namespace WonderCircuits.UnitOf
{
    public class ElectricChargeConverter : BaseNumberConverter
    {
        private static readonly double ABC = 1e5;                //Abcoulomb
        private static readonly double AH = 1 / 0.0036;            //Ampere Hour
        private static readonly double AM = 1 / 0.00006;           //Ampere Minute
        private static readonly double AS = 1e6;                 //Ampere Second
        private static readonly double C = 1e6;                  //Coulomb
        private static readonly double EMU = 1e5;                //EMU of Charge
        private static readonly double ESU = 2.99792457999957e15;//ESU of Charge
        private static readonly double E = 1 / 1.60217646e-25;     //Electron Vharge
        private static readonly double F = 1e6;                  //Farad Volt
        private static readonly double FA12 = 1 / 0.0964853103;    //Faraday (Carbon 12)
        private static readonly double FACH = 1 / 0.0964957007;    //Faraday (Chemistry)
        private static readonly double FAPH = 1 / 0.0965219008;    //Faraday (Physics)
        private static readonly double FR = 2.99792457999957e15; //Franklin
        private static readonly double KC = 1e3;                 //Kilocoulomb
        private static readonly double MC = 1;                   //Megacoulomb
        private static readonly double MUC = 1e12;               //Microcoulomb
        private static readonly double MILC = 1e9;               //Millicoulomb
        private static readonly double NC = 1e15;                //Nanocoulomb
        private static readonly double PC = 1e18;                //Picocoulomb
        private static readonly double STC = 2.99792457999957e15;//Statcoulomb
        public ElectricChargeConverter()
        {

        }
        public ElectricChargeConverter(double value, ElectricChargeUnits units) : base(BuildFromContext(value, units))
        {

        }

        public ElectricChargeConverter From(double value, ElectricChargeUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(ElectricChargeUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(ElectricChargeUnits units)
        {
            switch (units)
            {
                case ElectricChargeUnits.Abcoulombs: { return (ABC); }
                case ElectricChargeUnits.AmpereHours: { return (AH); }
                case ElectricChargeUnits.AmpereMinutes: { return (AM); }
                case ElectricChargeUnits.AmpereSeconds: { return (AS); }
                case ElectricChargeUnits.Coulombs: { return (C); }
                case ElectricChargeUnits.EMUsOfCharge: { return (EMU); }
                case ElectricChargeUnits.ESUsOfCharge: { return (ESU); }
                case ElectricChargeUnits.ElectronCharge: { return (E); }
                case ElectricChargeUnits.FaradVolts: { return (F); }
                case ElectricChargeUnits.FaradayCarbon12: { return (FA12); }
                case ElectricChargeUnits.FaradayChemistry: { return (FACH); }
                case ElectricChargeUnits.FaradayPhysics: { return (FAPH); }
                case ElectricChargeUnits.Franklins: { return (FR); }
                case ElectricChargeUnits.Kilocoulombs: { return (KC); }
                case ElectricChargeUnits.Megacoulombs: { return (MC); }
                case ElectricChargeUnits.Microcoulombs: { return (MUC); }
                case ElectricChargeUnits.Millicoulombs: { return (MILC); }
                case ElectricChargeUnits.Nanocoulombs: { return (NC); }
                case ElectricChargeUnits.Picocoulombs: { return (PC); }
                case ElectricChargeUnits.Statcoulombs: { return (STC); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, ElectricChargeUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class ElectricChargeConverterExtensions
    {
        #region From & To Methods
        //public ElectricChargeConverter FromAbcoulombs(double v) { return StoreFromContext(this, v, ABC, "ABC"); }
        //public ElectricChargeConverter FromAmpereHours(double v) { return StoreFromContext(this, v, AH, "AH"); }
        //public ElectricChargeConverter FromAmpereMinutes(double v) { return StoreFromContext(this, v, AM, "AM"); }
        //public ElectricChargeConverter FromAmpereSeconds(double v) { return StoreFromContext(this, v, AS, "AS"); }
        //public ElectricChargeConverter FromCoulombs(double v) { return StoreFromContext(this, v, C, "C"); }
        //public ElectricChargeConverter FromEMUsOfCharge(double v) { return StoreFromContext(this, v, EMU, "EMU"); }
        //public ElectricChargeConverter FromESUsOfCharge(double v) { return StoreFromContext(this, v, ESU, "ESU"); }
        //public ElectricChargeConverter FromElectronCharge(double v) { return StoreFromContext(this, v, E, "E"); }
        //public ElectricChargeConverter FromFaradVolts(double v) { return StoreFromContext(this, v, F, "F"); }
        //public ElectricChargeConverter FromFaradayCarbon12(double v) { return StoreFromContext(this, v, FA12, "FA12"); }
        //public ElectricChargeConverter FromFaradayChemistry(double v) { return StoreFromContext(this, v, FACH, "FACH"); }
        //public ElectricChargeConverter FromFaradayPhysics(double v) { return StoreFromContext(this, v, FAPH, "FAPH"); }
        //public ElectricChargeConverter FromFranklins(double v) { return StoreFromContext(this, v, FR, "FR"); }
        //public ElectricChargeConverter FromKilocoulombs(double v) { return StoreFromContext(this, v, KC, "KC"); }
        //public ElectricChargeConverter FromMegacoulombs(double v) { return StoreFromContext(this, v, MC, "MC"); }
        //public ElectricChargeConverter FromMicrocoulombs(double v) { return StoreFromContext(this, v, MUC, "MUC"); }
        //public ElectricChargeConverter FromMillicoulombs(double v) { return StoreFromContext(this, v, MILC, "MILC"); }
        //public ElectricChargeConverter FromNanocoulombs(double v) { return StoreFromContext(this, v, NC, "NC"); }
        //public ElectricChargeConverter FromPicocoulombs(double v) { return StoreFromContext(this, v, PC, "PC"); }
        //public ElectricChargeConverter FromStatcoulombs(double v) { return StoreFromContext(this, v, STC, "STC"); }

        //public double ToAbcoulombs() { return PerformConversion(ABC); }
        //public double ToAmpereHours() { return PerformConversion(AH); }
        //public double ToAmpereMinutes() { return PerformConversion(AM); }
        //public double ToAmpereSeconds() { return PerformConversion(AS); }
        //public double ToCoulombs() { return PerformConversion(C); }
        //public double ToEMUsOfCharge() { return PerformConversion(EMU); }
        //public double ToESUsOfCharge() { return PerformConversion(ESU); }
        //public double ToElectronCharge() { return PerformConversion(E); }
        //public double ToFaradVolts() { return PerformConversion(F); }
        //public double ToFaradayCarbon12() { return PerformConversion(FA12); }
        //public double ToFaradayChemistry() { return PerformConversion(FACH); }
        //public double ToFaradayPhysics() { return PerformConversion(FAPH); }
        //public double ToFranklins() { return PerformConversion(FR); }
        //public double ToKilocoulombs() { return PerformConversion(KC); }
        //public double ToMegacoulombs() { return PerformConversion(MC); }
        //public double ToMicrocoulombs() { return PerformConversion(MUC); }
        //public double ToMillicoulombs() { return PerformConversion(MILC); }
        //public double ToNanocoulombs() { return PerformConversion(NC); }
        //public double ToPicocoulombs() { return PerformConversion(PC); }
        //public double ToStatcoulombs() { return PerformConversion(STC); }

        #endregion
    }



}