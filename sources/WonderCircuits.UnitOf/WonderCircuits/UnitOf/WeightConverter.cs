using System;

namespace WonderCircuits.UnitOf
{
    public class WeightConverter : BaseNumberConverter
    {
        private static readonly double AG = 1e18;                //Attogram 
        private static readonly double CT = 5;                   //Carat
        private static readonly double CG = 1e2;                 //Centigram
        private static readonly double CWT = 1e-5;               //Centner
        private static readonly double DG = 1e1;                 //Decigram
        private static readonly double DAG = 1e-1;               //Dekagram
        private static readonly double EG = 1e-18;               //Exagram
        private static readonly double FG = 1e15;                //Femtogram
        private static readonly double GAMM = 1e6;               //Gamma
        private static readonly double GG = 1e-9;                //Gigagram
        private static readonly double G = 1;                    //Gram
        private static readonly double HG = 1e-2;                //Hectogram
        private static readonly double KG = 1e-3;                //Kilogram
        private static readonly double KIP = 1 / 453592.37;        //Kilopound
        private static readonly double TK = 1e-9;                //Kilotons (Metric)
        private static readonly double MG = 1e-6;                //Megagram
        private static readonly double MUG = 1e6;                //Microgram
        private static readonly double MILG = 1e3;               //Milligram
        private static readonly double NG = 1e9;                 //Nanogram
        private static readonly double MOZ = 4e-2;               //Ounce (Metric)
        //private static readonly double USOZ = 1 / 28.349523125;    //Ounce (US)
        private static readonly double USOZ = 1 / 28.3495;    //Ounce (US)
        private static readonly double PEG = 1e-15;              //Petagram
        private static readonly double PG = 1e12;                //Picogram
        private static readonly double LB = 1 / 453.592;           //Pound 
        private static readonly double QU = 1e-5;                //Quintal (Metric) 
        private static readonly double SLUG = 1 / 14593.9029372;   //Slug
        private static readonly double STUK = 1 / 6350.29318;      //Stone (UK)
        private static readonly double STUS = 1 / 5669.904625;     //Stone (US)
        private static readonly double TG = 1e-12;               //Teragram
        private static readonly double TI = 1 / 1016000.0;         //Ton (Imperial)
        private static readonly double TM = 1e-6;                //Tons (Metric)
        private static readonly double TUS = 1 / 907185.0;         //Ton (US)
        public WeightConverter()
        {

        }
        public WeightConverter(double value, WeightUnits units) : base(BuildFromContext(value, units))
        {

        }

        public WeightConverter From(double value, WeightUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(WeightUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(WeightUnits units)
        {
            switch (units)
            {
                case WeightUnits.Attograms: { return (AG); }
                case WeightUnits.Carats: { return (CT); }
                case WeightUnits.Centigrams: { return (CG); }
                case WeightUnits.Centners: { return (CWT); }
                case WeightUnits.Decigrams: { return (DG); }
                case WeightUnits.Dekagrams: { return (DAG); }
                case WeightUnits.Exagrams: { return (EG); }
                case WeightUnits.Femtograms: { return (FG); }
                case WeightUnits.Gamma: { return (GAMM); }
                case WeightUnits.Gigagrams: { return (GG); }
                case WeightUnits.Grams: { return (G); }
                case WeightUnits.Hectograms: { return (HG); }
                case WeightUnits.Kilograms: { return (KG); }
                case WeightUnits.Kilopounds: { return (KIP); }
                case WeightUnits.KilotonsMetric: { return (TK); }
                case WeightUnits.Megagrams: { return (MG); }
                case WeightUnits.Micrograms: { return (MUG); }
                case WeightUnits.Milligrams: { return (MILG); }
                case WeightUnits.Nanograms: { return (NG); }
                case WeightUnits.OuncesMetric: { return (MOZ); }
                case WeightUnits.OuncesUS: { return (USOZ); }
                case WeightUnits.Petagrams: { return (PEG); }
                case WeightUnits.Picograms: { return (PG); }
                case WeightUnits.Pounds: { return (LB); }
                case WeightUnits.Quintals: { return (QU); }
                case WeightUnits.Slugs: { return (SLUG); }
                case WeightUnits.StonesUK: { return (STUK); }
                case WeightUnits.StonesUS: { return (STUS); }
                case WeightUnits.Teragrams: { return (TG); }
                case WeightUnits.TonsImperial: { return (TI); }
                case WeightUnits.TonsMetric: { return (TM); }
                case WeightUnits.TonsUS: { return (TUS); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, WeightUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class WeightConverterExtensions
    {
        #region From & To Methods
        //public WeightConverter FromAttograms(double v) { return StoreFromContext(this, v, AG, "AG"); }
        //public WeightConverter FromCarats(double v) { return StoreFromContext(this, v, CT, "CT"); }
        //public WeightConverter FromCentigrams(double v) { return StoreFromContext(this, v, CG, "CG"); }
        //public WeightConverter FromCentners(double v) { return StoreFromContext(this, v, CWT, "CWT"); }
        //public WeightConverter FromDecigrams(double v) { return StoreFromContext(this, v, DG, "DG"); }
        //public WeightConverter FromDekagrams(double v) { return StoreFromContext(this, v, DAG, "DAG"); }
        //public WeightConverter FromExagrams(double v) { return StoreFromContext(this, v, EG, "EG"); }
        //public WeightConverter FromFemtograms(double v) { return StoreFromContext(this, v, FG, "FG"); }
        //public WeightConverter FromGamma(double v) { return StoreFromContext(this, v, GAMM, "GAMM"); }
        //public WeightConverter FromGigagrams(double v) { return StoreFromContext(this, v, GG, "GG"); }
        //public WeightConverter FromGrams(double v) { return StoreFromContext(this, v, G, "G"); }
        //public WeightConverter FromHectograms(double v) { return StoreFromContext(this, v, HG, "HG"); }
        //public WeightConverter FromKilograms(double v) { return StoreFromContext(this, v, KG, "KG"); }
        //public WeightConverter FromKilopounds(double v) { return StoreFromContext(this, v, KIP, "KIP"); }
        //public WeightConverter FromKilotonsMetric(double v) { return StoreFromContext(this, v, TK, "TK"); }
        //public WeightConverter FromMegagrams(double v) { return StoreFromContext(this, v, MG, "MG"); }
        //public WeightConverter FromMicrograms(double v) { return StoreFromContext(this, v, MUG, "MUG"); }
        //public WeightConverter FromMilligrams(double v) { return StoreFromContext(this, v, MILG, "MILG"); }
        //public WeightConverter FromNanograms(double v) { return StoreFromContext(this, v, NG, "NG"); }
        //public WeightConverter FromOuncesMetric(double v) { return StoreFromContext(this, v, MOZ, "MOZ"); }
        //public WeightConverter FromOuncesUS(double v) { return StoreFromContext(this, v, USOZ, "USOZ"); }
        //public WeightConverter FromPetagrams(double v) { return StoreFromContext(this, v, PEG, "PEG"); }
        //public WeightConverter FromPicograms(double v) { return StoreFromContext(this, v, PG, "PG"); }
        //public WeightConverter FromPounds(double v) { return StoreFromContext(this, v, LB, "LB"); }
        //public WeightConverter FromQuintals(double v) { return StoreFromContext(this, v, QU, "QU"); }
        //public WeightConverter FromSlugs(double v) { return StoreFromContext(this, v, SLUG, "SLUG"); }
        //public WeightConverter FromStonesUK(double v) { return StoreFromContext(this, v, STUK, "STUK"); }
        //public WeightConverter FromStonesUS(double v) { return StoreFromContext(this, v, STUS, "STUS"); }
        //public WeightConverter FromTeragrams(double v) { return StoreFromContext(this, v, TG, "TG"); }
        //public WeightConverter FromTonsImperial(double v) { return StoreFromContext(this, v, TI, "TI"); }
        //public WeightConverter FromTonsMetric(double v) { return StoreFromContext(this, v, TM, "TM"); }
        //public WeightConverter FromTonsUS(double v) { return StoreFromContext(this, v, TUS, "TUS"); }


        //public double ToAttograms() { return PerformConversion(AG); }
        //public double ToCarats() { return PerformConversion(CT); }
        //public double ToCentigrams() { return PerformConversion(CG); }
        //public double ToCentners() { return PerformConversion(CWT); }
        //public double ToDecigrams() { return PerformConversion(DG); }
        //public double ToDekagrams() { return PerformConversion(DAG); }
        //public double ToExagrams() { return PerformConversion(EG); }
        //public double ToFemtograms() { return PerformConversion(FG); }
        //public double ToGamma() { return PerformConversion(GAMM); }
        //public double ToGigagrams() { return PerformConversion(GG); }
        //public double ToGrams() { return PerformConversion(G); }
        //public double ToHectograms() { return PerformConversion(HG); }
        //public double ToKilograms() { return PerformConversion(KG); }
        //public double ToKilopounds() { return PerformConversion(KIP); }
        //public double ToKilotonsMetric() { return PerformConversion(TK); }
        //public double ToMegagrams() { return PerformConversion(MG); }
        //public double ToMicrograms() { return PerformConversion(MUG); }
        //public double ToMilligrams() { return PerformConversion(MILG); }
        //public double ToNanograms() { return PerformConversion(NG); }
        //public double ToOuncesMetric() { return PerformConversion(MOZ); }
        //public double ToOuncesUS() { return PerformConversion(USOZ); }
        //public double ToPetagrams() { return PerformConversion(PEG); }
        //public double ToPicograms() { return PerformConversion(PG); }
        //public double ToPounds() { return PerformConversion(LB); }
        //public double ToQuintals() { return PerformConversion(QU); }
        //public double ToSlugs() { return PerformConversion(SLUG); }
        //public double ToStonesUK() { return PerformConversion(STUK); }
        //public double ToStonesUS() { return PerformConversion(STUS); }
        //public double ToTeragrams() { return PerformConversion(TG); }
        //public double ToTonsImperial() { return PerformConversion(TI); }
        //public double ToTonsMetric() { return PerformConversion(TM); }
        //public double ToTonsUS() { return PerformConversion(TUS); }

        #endregion
    }


}