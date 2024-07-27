using System;

namespace WonderCircuits.UnitOf
{
    public class MetricPrefixConverter : BaseNumberConverter
    {
        private static readonly double A = 1e-18;    //Atto
        private static readonly double C = 1e-2;     //Centi
        private static readonly double D = 1e-1;     //Deci
        private static readonly double DA = 1e1;     //Deka
        private static readonly double E = 1e18;     //Exa
        private static readonly double F = 1e-15;    //Femto
        private static readonly double G = 1e9;      //Giga
        private static readonly double H = 1e2;      //Hecto
        private static readonly double K = 1e3;      //Kilo
        private static readonly double M = 1e6;      //Mega
        private static readonly double MU = 1e-6;    //Micro
        private static readonly double MIL = 1e-3;   //Milli
        private static readonly double N = 1e-9;     //Nano
        private static readonly double NN = 1e0;     //No Prefix
        private static readonly double PE = 1e15;    //Peta
        private static readonly double P = 1e-12;    //Pico
        private static readonly double T = 1e12;     //Tera
        private static readonly double YO = 1e-24;   //Yocto
        private static readonly double Y = 1e24;     //Yotta
        private static readonly double ZO = 1e-21;   //Zepto
        private static readonly double Z = 1e21;     //Zetta
        public MetricPrefixConverter()
        {

        }
        public MetricPrefixConverter(double value, MetricPrefixUnits units) : base(BuildFromContext(value, units))
        {

        }

        public MetricPrefixConverter From(double value, MetricPrefixUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(MetricPrefixUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, false);
        }

        private static double GetBaseConstant(MetricPrefixUnits units)
        {
            switch (units)
            {
                case MetricPrefixUnits.Atto: { return (A); }
                case MetricPrefixUnits.Centi: { return (C); }
                case MetricPrefixUnits.Deci: { return (D); }
                case MetricPrefixUnits.Deka: { return (DA); }
                case MetricPrefixUnits.Exa: { return (E); }
                case MetricPrefixUnits.Femto: { return (F); }
                case MetricPrefixUnits.Giga: { return (G); }
                case MetricPrefixUnits.Hecto: { return (H); }
                case MetricPrefixUnits.Kilo: { return (K); }
                case MetricPrefixUnits.Mega: { return (M); }
                case MetricPrefixUnits.Micro: { return (MU); }
                case MetricPrefixUnits.Milli: { return (MIL); }
                case MetricPrefixUnits.Nano: { return (N); }
                case MetricPrefixUnits.NoPrefix: { return (NN); }
                case MetricPrefixUnits.Peta: { return (PE); }
                case MetricPrefixUnits.Pico: { return (P); }
                case MetricPrefixUnits.Tera: { return (T); }
                case MetricPrefixUnits.Yocto: { return (YO); }
                case MetricPrefixUnits.Yotta: { return (Y); }
                case MetricPrefixUnits.Zepto: { return (ZO); }
                case MetricPrefixUnits.Zetta: { return (Z); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, MetricPrefixUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class MetricPrefixConverterExtensions
    {
        #region From & To Methods

        //public MetricPrefixConverter FromAtto(double v) { return StoreFromContext(this, v, A, "A"); }
        //public MetricPrefixConverter FromCenti(double v) { return StoreFromContext(this, v, C, "C"); }
        //public MetricPrefixConverter FromDeci(double v) { return StoreFromContext(this, v, D, "D"); }
        //public MetricPrefixConverter FromDeka(double v) { return StoreFromContext(this, v, DA, "DA"); }
        //public MetricPrefixConverter FromExa(double v) { return StoreFromContext(this, v, E, "E"); }
        //public MetricPrefixConverter FromFemto(double v) { return StoreFromContext(this, v, F, "F"); }
        //public MetricPrefixConverter FromGiga(double v) { return StoreFromContext(this, v, G, "G"); }
        //public MetricPrefixConverter FromHecto(double v) { return StoreFromContext(this, v, H, "H"); }
        //public MetricPrefixConverter FromKilo(double v) { return StoreFromContext(this, v, K, "K"); }
        //public MetricPrefixConverter FromMega(double v) { return StoreFromContext(this, v, M, "M"); }
        //public MetricPrefixConverter FromMicro(double v) { return StoreFromContext(this, v, MU, "MU"); }
        //public MetricPrefixConverter FromMilli(double v) { return StoreFromContext(this, v, MIL, "MIL"); }
        //public MetricPrefixConverter FromNano(double v) { return StoreFromContext(this, v, N, "N"); }
        //public MetricPrefixConverter FromNoPrefix(double v) { return StoreFromContext(this, v, NN, "NN"); }
        //public MetricPrefixConverter FromPeta(double v) { return StoreFromContext(this, v, PE, "PE"); }
        //public MetricPrefixConverter FromPico(double v) { return StoreFromContext(this, v, P, "P"); }
        //public MetricPrefixConverter FromTera(double v) { return StoreFromContext(this, v, T, "T"); }
        //public MetricPrefixConverter FromYocto(double v) { return StoreFromContext(this, v, YO, "YO"); }
        //public MetricPrefixConverter FromYotta(double v) { return StoreFromContext(this, v, Y, "Y"); }
        //public MetricPrefixConverter FromZepto(double v) { return StoreFromContext(this, v, ZO, "ZO"); }
        //public MetricPrefixConverter FromZetta(double v) { return StoreFromContext(this, v, Z, "Z"); }


        //public double ToAtto() { return PerformConversion(A); }
        //public double ToCenti() { return PerformConversion(C); }
        //public double ToDeci() { return PerformConversion(D); }
        //public double ToDeka() { return PerformConversion(DA); }
        //public double ToExa() { return PerformConversion(E); }
        //public double ToFemto() { return PerformConversion(F); }
        //public double ToGiga() { return PerformConversion(G); }
        //public double ToHecto() { return PerformConversion(H); }
        //public double ToKilo() { return PerformConversion(K); }
        //public double ToMega() { return PerformConversion(M); }
        //public double ToMicro() { return PerformConversion(MU); }
        //public double ToMilli() { return PerformConversion(MIL); }
        //public double ToNano() { return PerformConversion(N); }
        //public double ToNoPrefix() { return PerformConversion(NN); }
        //public double ToPeta() { return PerformConversion(PE); }
        //public double ToPico() { return PerformConversion(P); }
        //public double ToTera() { return PerformConversion(T); }
        //public double ToYocto() { return PerformConversion(YO); }
        //public double ToYotta() { return PerformConversion(Y); }
        //public double ToZepto() { return PerformConversion(ZO); }
        //public double ToZetta() { return PerformConversion(Z); }
        #endregion
    }


}