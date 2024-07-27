using System;

namespace WonderCircuits.UnitOf
{
    public class DataStorageConverter : BaseNumberConverter
    {
        private static readonly double B = 1.0 * 8.0 * 1024.0 * 1024.0;  //Bit
        private static readonly double BL = 1.0 * 1.0 * 2.0 * 1024.0;    //Block
        private static readonly double BD2 = 1 / 51200.0;                  //Blu-ray Disc (Double-Layer)
        private static readonly double BD1 = 1 / 25600.0;                  //Blu-ray Disc (Single-Layer)
        private static readonly double BY = 1.0 * 1.0 * 1024.0 * 1024.0; //Byte
        private static readonly double CD74 = 1 / (665096.0 / 1024.0);       //CD (74 Minute)
        private static readonly double CD80 = 1 / 702.170607567;           //CD (80 Minute)
        private static readonly double D22 = 1 / 17408.0;                  //DVD (2 Layer 2 Side)
        private static readonly double D12 = 1 / 9625.6;                   //DVD (1 Layer 2 Side)
        private static readonly double D21 = 1 / 8704.0;                   //DVD (2 Layer 1 Side)
        private static readonly double D11 = 1 / 4812.8;                   //DVD (1 Layer 1 Side)
        private static readonly double EBI = 8 / Math.Pow(1024, 4);      //Exabit
        private static readonly double EB = 1 / Math.Pow(1024, 4);       //Exabyte 
        private static readonly double F35DD = 1 / (711.75 / 1024.0);        //Floppy Disk (3.5 DD)
        private static readonly double F35ED = 1 / (2847.0 / 1024.0);        //Floppy Disk (3.5 ED)
        private static readonly double F35HD = 1 / (1423.5 / 1024.0);        //Floppy Disk (3.5 HD)
        private static readonly double F525DD = 1 / (355.875 / 1024.0);      //Floppy Disk (5.25 DD)
        private static readonly double F525HD = 1 / (1185.5 / 1024.0);       //Floppy Disk (5.25 HD)
        private static readonly double GBI = 8 / Math.Pow(1024, 1);      //Gigabit
        private static readonly double GB = 1 / Math.Pow(1024, 1);       //Gigbyte
        private static readonly double KBI = 8 * 1024;                   //Kilobit
        private static readonly double KB = 1024;                        //Kilobyte
        private static readonly double MBI = 8;                          //Megabit
        private static readonly double MB = 1;                           //Megabyte
        private static readonly double NI = 1.0 * 2.0 * 1024.0 * 1024.0; //Nibble 
        private static readonly double PBI = 8 / Math.Pow(1024, 3);     //Petabit
        private static readonly double PB = 1 / Math.Pow(1024, 3);      //Petabyte
        private static readonly double SIEBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 5); //SI Exabit
        private static readonly double SIEB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 5);  //SI Exabyte
        private static readonly double SIGBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 2); //SI Gigabit
        private static readonly double SIGB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 2);  //SI Gigbyte
        private static readonly double SIKBI = 8 * 1024.0 * (1024 / 1000.0);                       //SI Kilobit
        private static readonly double SIKB = 1 * 1024.0 * (1024 / 1000.0);                        //SI Kilobyte
        private static readonly double SIMBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 1); //SI Megabit
        private static readonly double SIMB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 1);  //SI Megabyte
        private static readonly double SIPBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 4); //SI Petabit
        private static readonly double SIPB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 4);  //SI Petabyte
        private static readonly double SITBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 3); //SI Terabit
        private static readonly double SITB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 3);  //SI Terabyte
        private static readonly double SIYBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 7); //SI Yottabit
        private static readonly double SIYB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 7);  //SI Yottabyte
        private static readonly double SIZBI = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 6); //SI Zettabit
        private static readonly double SIZB = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 6);  //SI Zettabyte   
        private static readonly double TBI = 8 / Math.Pow(1024, 2);      //Terabit
        private static readonly double TB = 1 / Math.Pow(1024, 2);       //Terabyte
        private static readonly double W = 1.0 * 1.0 * 512.0 * 1024.0;   //Word
        private static readonly double YBI = 8 / Math.Pow(1024, 6);      //Yottabit
        private static readonly double YB = 1 / Math.Pow(1024, 6);       //Yottabyte
        private static readonly double ZBI = 8 / Math.Pow(1024, 5);      //Zettabit
        private static readonly double ZB = 1 / Math.Pow(1024, 5);       //Zettabyte
        public DataStorageConverter()
        {

        }
        public DataStorageConverter(double value, DataStorageUnits units) : base(BuildFromContext(value, units))
        {

        }

        public DataStorageConverter From(double value, DataStorageUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(DataStorageUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(DataStorageUnits units)
        {
            switch (units)
            {
                case DataStorageUnits.Bits: { return (B); }
                case DataStorageUnits.Blocks: { return (BL); }
                case DataStorageUnits.BluRay_DoubleLayer: { return (BD2); }
                case DataStorageUnits.BluRay_SingleLayer: { return (BD1); }
                case DataStorageUnits.Bytes: { return (BY); }
                case DataStorageUnits.CDs_74Minutes: { return (CD74); }
                case DataStorageUnits.CDs_80Minutes: { return (CD80); }
                case DataStorageUnits.DVDs_DoubleSidedDoubleLayer: { return (D22); }
                case DataStorageUnits.DVDs_DoubleSidedSingleLayer: { return (D12); }
                case DataStorageUnits.DVDs_SingleSidedDoubleLayer: { return (D21); }
                case DataStorageUnits.DVDs_SingleSidedSingleLayer: { return (D11); }
                case DataStorageUnits.Exabits: { return (EBI); }
                case DataStorageUnits.Exabytes: { return (EB); }
                case DataStorageUnits.FloppyDisks_35DD: { return (F35DD); }
                case DataStorageUnits.FloppyDisks_35ED: { return (F35ED); }
                case DataStorageUnits.FloppyDisks_35HD: { return (F35HD); }
                case DataStorageUnits.FloppyDisks_525DD: { return (F525DD); }
                case DataStorageUnits.FloppyDisks_525HD: { return (F525HD); }
                case DataStorageUnits.Gigabits: { return (GBI); }
                case DataStorageUnits.Gigabytes: { return (GB); }
                case DataStorageUnits.Kilobits: { return (KBI); }
                case DataStorageUnits.Kilobytes: { return (KB); }
                case DataStorageUnits.Megabits: { return (MBI); }
                case DataStorageUnits.Megabytes: { return (MB); }
                case DataStorageUnits.Nibbles: { return (NI); }
                case DataStorageUnits.Petabits: { return (PBI); }
                case DataStorageUnits.Petabytes: { return (PB); }
                case DataStorageUnits.SIUnitExabits: { return (SIEBI); }
                case DataStorageUnits.SIUnitExabytes: { return (SIEB); }
                case DataStorageUnits.SIUnitGigabits: { return (SIGBI); }
                case DataStorageUnits.SIUnitGigabytes: { return (SIGB); }
                case DataStorageUnits.SIUnitKilobits: { return (SIKBI); }
                case DataStorageUnits.SIUnitKilobytes: { return (SIKB); }
                case DataStorageUnits.SIUnitMegabits: { return (SIMBI); }
                case DataStorageUnits.SIUnitMegabytes: { return (SIMB); }
                case DataStorageUnits.SIUnitPetabits: { return (SIPBI); }
                case DataStorageUnits.SIUnitPetabytes: { return (SIPB); }
                case DataStorageUnits.SIUnitTerabits: { return (SITBI); }
                case DataStorageUnits.SIUnitTerabytes: { return (SITB); }
                case DataStorageUnits.SIUnitYottabits: { return (SIYBI); }
                case DataStorageUnits.SIUnitYottabytes: { return (SIYB); }
                case DataStorageUnits.SIUnitZettabits: { return (SIZBI); }
                case DataStorageUnits.SIUnitZettabytes: { return (SIZB); }
                case DataStorageUnits.Terabits: { return (TBI); }
                case DataStorageUnits.Terabytes: { return (TB); }
                case DataStorageUnits.Words: { return (W); }
                case DataStorageUnits.Yottabits: { return (YBI); }
                case DataStorageUnits.Yottabytes: { return (YB); }
                case DataStorageUnits.Zettabits: { return (ZBI); }
                case DataStorageUnits.Zettabytes: { return (ZB); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, DataStorageUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class DataStorageConverterExtensions
    {
        #region From & To Methods
        //public DataStorageConverter FromBits(double v) { return StoreFromContext(this, v, B, "B"); }
        //public DataStorageConverter FromBlocks(double v) { return StoreFromContext(this, v, BL, "BL"); }
        //public DataStorageConverter FromBluRay_DoubleLayer(double v) { return StoreFromContext(this, v, BD2, "BD2"); }
        //public DataStorageConverter FromBluRay_SingleLayer(double v) { return StoreFromContext(this, v, BD1, "BD1"); }
        //public DataStorageConverter FromBytes(double v) { return StoreFromContext(this, v, BY, "BY"); }
        //public DataStorageConverter FromCDs_74Minutes(double v) { return StoreFromContext(this, v, CD74, "CD74"); }
        //public DataStorageConverter FromCDs_80Minutes(double v) { return StoreFromContext(this, v, CD80, "CD80"); }
        //public DataStorageConverter FromDVDs_DoubleSidedDoubleLayer(double v) { return StoreFromContext(this, v, D22, "D22"); }
        //public DataStorageConverter FromDVDs_DoubleSidedSingleLayer(double v) { return StoreFromContext(this, v, D12, "D12"); }
        //public DataStorageConverter FromDVDs_SingleSidedDoubleLayer(double v) { return StoreFromContext(this, v, D21, "D21"); }
        //public DataStorageConverter FromDVDs_SingleSidedSingleLayer(double v) { return StoreFromContext(this, v, D11, "D11"); }
        //public DataStorageConverter FromExabits(double v) { return StoreFromContext(this, v, EBI, "EBI"); }
        //public DataStorageConverter FromExabytes(double v) { return StoreFromContext(this, v, EB, "EB"); }
        //public DataStorageConverter FromFloppyDisks_35DD(double v) { return StoreFromContext(this, v, F35DD, "F35DD"); }
        //public DataStorageConverter FromFloppyDisks_35ED(double v) { return StoreFromContext(this, v, F35ED, "F35ED"); }
        //public DataStorageConverter FromFloppyDisks_35HD(double v) { return StoreFromContext(this, v, F35HD, "F35HD"); }
        //public DataStorageConverter FromFloppyDisks_525DD(double v) { return StoreFromContext(this, v, F525DD, "F525DD"); }
        //public DataStorageConverter FromFloppyDisks_525HD(double v) { return StoreFromContext(this, v, F525HD, "F525HD"); }
        //public DataStorageConverter FromGigabits(double v) { return StoreFromContext(this, v, GBI, "GBI"); }
        //public DataStorageConverter FromGigabytes(double v) { return StoreFromContext(this, v, GB, "GB"); }
        //public DataStorageConverter FromKilobits(double v) { return StoreFromContext(this, v, KBI, "KBI"); }
        //public DataStorageConverter FromKilobytes(double v) { return StoreFromContext(this, v, KB, "KB"); }
        //public DataStorageConverter FromMegabits(double v) { return StoreFromContext(this, v, MBI, "MBI"); }
        //public DataStorageConverter FromMegabytes(double v) { return StoreFromContext(this, v, MB, "MB"); }
        //public DataStorageConverter FromNibbles(double v) { return StoreFromContext(this, v, NI, "NI"); }
        //public DataStorageConverter FromPetabits(double v) { return StoreFromContext(this, v, PBI, "PBI"); }
        //public DataStorageConverter FromPetabytes(double v) { return StoreFromContext(this, v, PB, "PB"); }
        //public DataStorageConverter FromSIUnitExabits(double v) { return StoreFromContext(this, v, SIEBI, "SIEBI"); }
        //public DataStorageConverter FromSIUnitExabytes(double v) { return StoreFromContext(this, v, SIEB, "SIEB"); }
        //public DataStorageConverter FromSIUnitGigabits(double v) { return StoreFromContext(this, v, SIGBI, "SIGBI"); }
        //public DataStorageConverter FromSIUnitGigabytes(double v) { return StoreFromContext(this, v, SIGB, "SIGB"); }
        //public DataStorageConverter FromSIUnitKilobits(double v) { return StoreFromContext(this, v, SIKBI, "SIKBI"); }
        //public DataStorageConverter FromSIUnitKilobytes(double v) { return StoreFromContext(this, v, SIKB, "SIKB"); }
        //public DataStorageConverter FromSIUnitMegabits(double v) { return StoreFromContext(this, v, SIMBI, "SIMBI"); }
        //public DataStorageConverter FromSIUnitMegabytes(double v) { return StoreFromContext(this, v, SIMB, "SIMB"); }
        //public DataStorageConverter FromSIUnitPetabits(double v) { return StoreFromContext(this, v, SIPBI, "SIPBI"); }
        //public DataStorageConverter FromSIUnitPetabytes(double v) { return StoreFromContext(this, v, SIPB, "SIPB"); }
        //public DataStorageConverter FromSIUnitTerabits(double v) { return StoreFromContext(this, v, SITBI, "SITBI"); }
        //public DataStorageConverter FromSIUnitTerabytes(double v) { return StoreFromContext(this, v, SITB, "SITB"); }
        //public DataStorageConverter FromSIUnitYottabits(double v) { return StoreFromContext(this, v, SIYBI, "SIYBI"); }
        //public DataStorageConverter FromSIUnitYottabytes(double v) { return StoreFromContext(this, v, SIYB, "SIYB"); }
        //public DataStorageConverter FromSIUnitZettabits(double v) { return StoreFromContext(this, v, SIZBI, "SIZBI"); }
        //public DataStorageConverter FromSIUnitZettabytes(double v) { return StoreFromContext(this, v, SIZB, "SIZB"); }
        //public DataStorageConverter FromTerabits(double v) { return StoreFromContext(this, v, TBI, "TBI"); }
        //public DataStorageConverter FromTerabytes(double v) { return StoreFromContext(this, v, TB, "TB"); }
        //public DataStorageConverter FromWords(double v) { return StoreFromContext(this, v, W, "W"); }
        //public DataStorageConverter FromYottabits(double v) { return StoreFromContext(this, v, YBI, "YBI"); }
        //public DataStorageConverter FromYottabytes(double v) { return StoreFromContext(this, v, YB, "YB"); }
        //public DataStorageConverter FromZettabits(double v) { return StoreFromContext(this, v, ZBI, "ZBI"); }
        //public DataStorageConverter FromZettabytes(double v) { return StoreFromContext(this, v, ZB, "ZB"); }

        //public double ToBits() { return PerformConversion(B); }
        //public double ToBlocks() { return PerformConversion(BL); }
        //public double ToBluRay_DoubleLayer() { return PerformConversion(BD2); }
        //public double ToBluRay_SingleLayer() { return PerformConversion(BD1); }
        //public double ToBytes() { return PerformConversion(BY); }
        //public double ToCDs_74Minutes() { return PerformConversion(CD74); }
        //public double ToCDs_80Minutes() { return PerformConversion(CD80); }
        //public double ToDVDs_DoubleSidedDoubleLayer() { return PerformConversion(D22); }
        //public double ToDVDs_DoubleSidedSingleLayer() { return PerformConversion(D12); }
        //public double ToDVDs_SingleSidedDoubleLayer() { return PerformConversion(D21); }
        //public double ToDVDs_SingleSidedSingleLayer() { return PerformConversion(D11); }
        //public double ToExabits() { return PerformConversion(EBI); }
        //public double ToExabytes() { return PerformConversion(EB); }
        //public double ToFloppyDisks_35DD() { return PerformConversion(F35DD); }
        //public double ToFloppyDisks_35ED() { return PerformConversion(F35ED); }
        //public double ToFloppyDisks_35HD() { return PerformConversion(F35HD); }
        //public double ToFloppyDisks_525DD() { return PerformConversion(F525DD); }
        //public double ToFloppyDisks_525HD() { return PerformConversion(F525HD); }
        //public double ToGigabits() { return PerformConversion(GBI); }
        //public double ToGigabytes() { return PerformConversion(GB); }
        //public double ToKilobits() { return PerformConversion(KBI); }
        //public double ToKilobytes() { return PerformConversion(KB); }
        //public double ToMegabits() { return PerformConversion(MBI); }
        //public double ToMegabytes() { return PerformConversion(MB); }
        //public double ToNibbles() { return PerformConversion(NI); }
        //public double ToPetabits() { return PerformConversion(PBI); }
        //public double ToPetabytes() { return PerformConversion(PB); }
        //public double ToSIUnitExabits() { return PerformConversion(SIEBI); }
        //public double ToSIUnitExabytes() { return PerformConversion(SIEB); }
        //public double ToSIUnitGigabits() { return PerformConversion(SIGBI); }
        //public double ToSIUnitGigabytes() { return PerformConversion(SIGB); }
        //public double ToSIUnitKilobits() { return PerformConversion(SIKBI); }
        //public double ToSIUnitKilobytes() { return PerformConversion(SIKB); }
        //public double ToSIUnitMegabits() { return PerformConversion(SIMBI); }
        //public double ToSIUnitMegabytes() { return PerformConversion(SIMB); }
        //public double ToSIUnitPetabits() { return PerformConversion(SIPBI); }
        //public double ToSIUnitPetabytes() { return PerformConversion(SIPB); }
        //public double ToSIUnitTerabits() { return PerformConversion(SITBI); }
        //public double ToSIUnitTerabytes() { return PerformConversion(SITB); }
        //public double ToSIUnitYottabits() { return PerformConversion(SIYBI); }
        //public double ToSIUnitYottabytes() { return PerformConversion(SIYB); }
        //public double ToSIUnitZettabits() { return PerformConversion(SIZBI); }
        //public double ToSIUnitZettabytes() { return PerformConversion(SIZB); }
        //public double ToTerabits() { return PerformConversion(TBI); }
        //public double ToTerabytes() { return PerformConversion(TB); }
        //public double ToWords() { return PerformConversion(W); }
        //public double ToYottabits() { return PerformConversion(YBI); }
        //public double ToYottabytes() { return PerformConversion(YB); }
        //public double ToZettabits() { return PerformConversion(ZBI); }
        //public double ToZettabytes() { return PerformConversion(ZB); }

        #endregion
    }



}