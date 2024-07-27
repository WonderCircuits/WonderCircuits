using System;
using System.Net;

namespace WonderCircuits.UnitOf
{
    public class DataTransferRateConverter : BaseNumberConverter
    {
        private static readonly double BIS = 1.0 * 8.0 * 1024.0 * 1024.0;            //Bit per Second
        private static readonly double BS = 1.0 * 1.0 * 1024.0 * 1024.0;             //Byte per Second
        private static readonly double E10 = 1.0 * 8.0 * 1024.0 * 1024.0 / (Math.Pow(1000, 2) * 10.0);      //10 Base-T Ethernet
        private static readonly double E100 = 1.0 * 8.0 * 1024.0 * 1024.0 / (Math.Pow(1000, 2) * 100.0);    //100 Base-T Ethernet
        private static readonly double E1000 = 1.0 * 8.0 * 1024.0 * 1024.0 / (Math.Pow(1000, 2) * 1000.0);  //1000 Base-T Ethernet
        private static readonly double FW400 = 0.02 * 1.048576;                      //FireWire 400
        private static readonly double FW800 = 0.01 * 1.048576;                      //FireWire 800
        private static readonly double FW3200 = 0.0025 * 1.048576;                   //FireWire S1600 and S3200 
        private static readonly double GBIS = 8 / Math.Pow(1024, 1);                 //Gigabit per Second
        private static readonly double GBS = 1 / Math.Pow(1024, 1);                  //Gigabyte per Second
        private static readonly double ISDND = 65.536;                               //ISDN (Dual Channel) 
        private static readonly double ISDNS = 131.072;                              //ISDN (Single Channel) 
        private static readonly double KBIS = 8 * 1024;                              //Kilobit per Second
        private static readonly double KBS = 1024;                                   //Kilobyte per Second
        private static readonly double MBIS = 8;                                     //Megabit per Second
        private static readonly double MBS = 1;                                      //Megabyte per Second
        private static readonly double M110 = 1 / 110.0 * (8.0 * 1024.0 * 1024.0);   //110 BPS Modem
        private static readonly double M1200 = 1 / 1200.0 * (8.0 * 1024.0 * 1024.0); //1200 BPS Modem
        private static readonly double M14K = 1 / 14400.0 * (8.0 * 1024.0 * 1024.0); //14.4 KBPS Modem
        private static readonly double M2400 = 1 / 2400.0 * (8.0 * 1024.0 * 1024.0); //2400 BPS Modem
        private static readonly double M28K = 1 / 28800.0 * (8.0 * 1024.0 * 1024.0); //28.8 KBPS Modem
        private static readonly double M300 = 1 / 300.0 * (8.0 * 1024.0 * 1024.0);   //300 BPS Modem
        private static readonly double M33K = 1 / 33600.0 * (8.0 * 1024.0 * 1024.0); //33.6 KBPS Modem
        private static readonly double M56K = 1 / 56000.0 * (8.0 * 1024.0 * 1024.0); //56 KBPS Modem
        private static readonly double M9600 = 1 / 9600.0 * (8.0 * 1024.0 * 1024.0); //9600 BPS Modem
        private static readonly double OC1 = 1 / 6.48 * 1.048576;                    //OC1
        private static readonly double OC12 = 1 / (6.48 * 12.0) * 1.048576;          //OC12
        private static readonly double OC192 = 1 / (6.48 * 192.0) * 1.048576;        //OC192
        private static readonly double OC24 = 1 / (6.48 * 24.0) * 1.048576;          //OC24
        private static readonly double OC3 = 1 / (6.48 * 3.0) * 1.048576;            //OC3
        private static readonly double OC48 = 1 / (6.48 * 48.0) * 1.048576;          //OC48
        private static readonly double OC768 = 1 / (6.48 * 768.0) * 1.048576;        //OC768
        private static readonly double PBIS = 8 / Math.Pow(1024, 3);                 //Petabit per Second
        private static readonly double PBS = 1 / Math.Pow(1024, 3);                  //Petabyte per Second
        private static readonly double SIGBIS = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 2);        //SI Gigabit per Second
        private static readonly double SIGBS = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 2);         //SI Gigabyte per Second
        private static readonly double SIKBIS = 8 * 1024.0 * (1024 / 1000.0);                              //SI Kilobit per Second
        private static readonly double SIKBS = 1 * 1024.0 * (1024 / 1000.0);                               //SI Kilobyte per Second
        private static readonly double SIMBIS = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 1);        //SI Megabit per Second
        private static readonly double SIMBS = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 1);         //SI Megabyte per Second
        private static readonly double SIPBIS = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 4);        //SI Petabit per Second
        private static readonly double SIPBS = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 4);         //SI Petabyte per Second
        private static readonly double SITBIS = 8 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 3);        //SI Terabit per Second
        private static readonly double SITBS = 1 * 1024.0 * (1024 / 1000.0) / Math.Pow(1000, 3);         //SI Terabyte per Second
        private static readonly double TBIS = 8 / Math.Pow(1024, 2);                 //Terabit per Second
        private static readonly double TBS = 1 / Math.Pow(1024, 2);                  //Terabyte per Second
        private static readonly double USB1 = 1 / 1.5 * 1.048576;                    //USB 1.X
        private static readonly double USB2 = 1 / 35.0 * 1.048576;                   //USB 2.X
        private static readonly double USB3 = 1 / 625.0 * 1.048576;                  //USB 3.0
        private static readonly double USB31 = 1 / 1250.0 * 1.048576;                //USB 3.1
        public DataTransferRateConverter()
        {

        }
        public DataTransferRateConverter(double value, DataTransferRateUnits units) : base(BuildFromContext(value, units))
        {

        }

        public DataTransferRateConverter From(double value, DataTransferRateUnits units)
        {
            StoreFromContext(BuildFromContext(value, units));
            return this;
        }
        public double To(DataTransferRateUnits units)
        {
            var toConstant = GetBaseConstant(units);
            return PerformConversion(toConstant, true);
        }

        private static double GetBaseConstant(DataTransferRateUnits units)
        {
            switch (units)
            {
                case DataTransferRateUnits.BitsPerSecond: { return (BIS); }
                case DataTransferRateUnits.BytesPerSecond: { return (BS); }
                case DataTransferRateUnits.EthernetsBase10: { return (E10); }
                case DataTransferRateUnits.EthernetsBase100: { return (E100); }
                case DataTransferRateUnits.EthernetsBase1000: { return (E1000); }
                case DataTransferRateUnits.FireWires400: { return (FW400); }
                case DataTransferRateUnits.FireWires800: { return (FW800); }
                case DataTransferRateUnits.FireWiresS1600_S3200: { return (FW3200); }
                case DataTransferRateUnits.GigabitsPerSecond: { return (GBIS); }
                case DataTransferRateUnits.GigabytesPerSecond: { return (GBS); }
                case DataTransferRateUnits.ISDNsDual: { return (ISDND); }
                case DataTransferRateUnits.ISDNsSingle: { return (ISDNS); }
                case DataTransferRateUnits.KilobitsPerSecond: { return (KBIS); }
                case DataTransferRateUnits.KilobytesPerSecond: { return (KBS); }
                case DataTransferRateUnits.MegabitsPerSecond: { return (MBIS); }
                case DataTransferRateUnits.MegabytesPerSecond: { return (MBS); }
                case DataTransferRateUnits.Modems110b: { return (M110); }
                case DataTransferRateUnits.Modems1200b: { return (M1200); }
                case DataTransferRateUnits.Modems14_4k: { return (M14K); }
                case DataTransferRateUnits.Modems2400b: { return (M2400); }
                case DataTransferRateUnits.Modems28_8k: { return (M28K); }
                case DataTransferRateUnits.Modems300b: { return (M300); }
                case DataTransferRateUnits.Modems33_6k: { return (M33K); }
                case DataTransferRateUnits.Modems56k: { return (M56K); }
                case DataTransferRateUnits.Modems9600b: { return (M9600); }
                case DataTransferRateUnits.OCs1: { return (OC1); }
                case DataTransferRateUnits.OCs12: { return (OC12); }
                case DataTransferRateUnits.OCs192: { return (OC192); }
                case DataTransferRateUnits.OCs24: { return (OC24); }
                case DataTransferRateUnits.OCs3: { return (OC3); }
                case DataTransferRateUnits.OCs48: { return (OC48); }
                case DataTransferRateUnits.OCs768: { return (OC768); }
                case DataTransferRateUnits.PetabitsPerSecond: { return (PBIS); }
                case DataTransferRateUnits.PetabytesPerSecond: { return (PBS); }
                case DataTransferRateUnits.SIUnitGigabitsPerSecond: { return (SIGBIS); }
                case DataTransferRateUnits.SIUnitGigabytesPerSecond: { return (SIGBS); }
                case DataTransferRateUnits.SIUnitKilobitsPerSecond: { return (SIKBIS); }
                case DataTransferRateUnits.SIUnitKilobytesPerSecond: { return (SIKBS); }
                case DataTransferRateUnits.SIUnitMegabitsPerSecond: { return (SIMBIS); }
                case DataTransferRateUnits.SIUnitMegabytesPerSecond: { return (SIMBS); }
                case DataTransferRateUnits.SIUnitPetabitsPerSecond: { return (SIPBIS); }
                case DataTransferRateUnits.SIUnitPetabytesPerSecond: { return (SIPBS); }
                case DataTransferRateUnits.SIUnitTerabitsPerSecond: { return (SITBIS); }
                case DataTransferRateUnits.SIUnitTerabytesPerSecond: { return (SITBS); }
                case DataTransferRateUnits.TerabitsPerSecond: { return (TBIS); }
                case DataTransferRateUnits.TerabytesPerSecond: { return (TBS); }
                case DataTransferRateUnits.USBs1_0: { return (USB1); }
                case DataTransferRateUnits.USBs2_0: { return (USB2); }
                case DataTransferRateUnits.USBs3_0: { return (USB3); }
                case DataTransferRateUnits.USBs3_1: { return (USB31); }
                default: { return 0; }
            }
        }
        private static NumberConverterContext BuildFromContext(double value, DataTransferRateUnits units)
        {
            return new NumberConverterContext(value, GetBaseConstant(units), units.ToString());
        }
    }

    public static class DataTransferRateConverterExtensions
    {
        #region From & To Methods
        //public DataTransferRateConverter FromBitsPerSecond(double v) { return StoreFromContext(this, v, BIS, "BIS"); }
        //public DataTransferRateConverter FromBytesPerSecond(double v) { return StoreFromContext(this, v, BS, "BS"); }
        //public DataTransferRateConverter FromEthernetsBase10(double v) { return StoreFromContext(this, v, E10, "E10"); }
        //public DataTransferRateConverter FromEthernetsBase100(double v) { return StoreFromContext(this, v, E100, "E100"); }
        //public DataTransferRateConverter FromEthernetsBase1000(double v) { return StoreFromContext(this, v, E1000, "E1000"); }
        //public DataTransferRateConverter FromFireWires400(double v) { return StoreFromContext(this, v, FW400, "FW400"); }
        //public DataTransferRateConverter FromFireWires800(double v) { return StoreFromContext(this, v, FW800, "FW800"); }
        //public DataTransferRateConverter FromFireWiresS1600_S3200(double v) { return StoreFromContext(this, v, FW3200, "FW3200"); }
        //public DataTransferRateConverter FromGigabitsPerSecond(double v) { return StoreFromContext(this, v, GBIS, "GBIS"); }
        //public DataTransferRateConverter FromGigabytesPerSecond(double v) { return StoreFromContext(this, v, GBS, "GBS"); }
        //public DataTransferRateConverter FromISDNsDual(double v) { return StoreFromContext(this, v, ISDND, "ISDND"); }
        //public DataTransferRateConverter FromISDNsSingle(double v) { return StoreFromContext(this, v, ISDNS, "ISDNS"); }
        //public DataTransferRateConverter FromKilobitsPerSecond(double v) { return StoreFromContext(this, v, KBIS, "KBIS"); }
        //public DataTransferRateConverter FromKilobytesPerSecond(double v) { return StoreFromContext(this, v, KBS, "KBS"); }
        //public DataTransferRateConverter FromMegabitsPerSecond(double v) { return StoreFromContext(this, v, MBIS, "MBIS"); }
        //public DataTransferRateConverter FromMegabytesPerSecond(double v) { return StoreFromContext(this, v, MBS, "MBS"); }
        //public DataTransferRateConverter FromModems110b(double v) { return StoreFromContext(this, v, M110, "M110"); }
        //public DataTransferRateConverter FromModems1200b(double v) { return StoreFromContext(this, v, M1200, "M1200"); }
        //public DataTransferRateConverter FromModems14_4k(double v) { return StoreFromContext(this, v, M14K, "M14K"); }
        //public DataTransferRateConverter FromModems2400b(double v) { return StoreFromContext(this, v, M2400, "M2400"); }
        //public DataTransferRateConverter FromModems28_8k(double v) { return StoreFromContext(this, v, M28K, "M28K"); }
        //public DataTransferRateConverter FromModems300b(double v) { return StoreFromContext(this, v, M300, "M300"); }
        //public DataTransferRateConverter FromModems33_6k(double v) { return StoreFromContext(this, v, M33K, "M33K"); }
        //public DataTransferRateConverter FromModems56k(double v) { return StoreFromContext(this, v, M56K, "M56K"); }
        //public DataTransferRateConverter FromModems9600b(double v) { return StoreFromContext(this, v, M9600, "M9600"); }
        //public DataTransferRateConverter FromOCs1(double v) { return StoreFromContext(this, v, OC1, "OC1"); }
        //public DataTransferRateConverter FromOCs12(double v) { return StoreFromContext(this, v, OC12, "OC12"); }
        //public DataTransferRateConverter FromOCs192(double v) { return StoreFromContext(this, v, OC192, "OC192"); }
        //public DataTransferRateConverter FromOCs24(double v) { return StoreFromContext(this, v, OC24, "OC24"); }
        //public DataTransferRateConverter FromOCs3(double v) { return StoreFromContext(this, v, OC3, "OC3"); }
        //public DataTransferRateConverter FromOCs48(double v) { return StoreFromContext(this, v, OC48, "OC48"); }
        //public DataTransferRateConverter FromOCs768(double v) { return StoreFromContext(this, v, OC768, "OC768"); }
        //public DataTransferRateConverter FromPetabitsPerSecond(double v) { return StoreFromContext(this, v, PBIS, "PBIS"); }
        //public DataTransferRateConverter FromPetabytesPerSecond(double v) { return StoreFromContext(this, v, PBS, "PBS"); }
        //public DataTransferRateConverter FromSIUnitGigabitsPerSecond(double v) { return StoreFromContext(this, v, SIGBIS, "SIGBIS"); }
        //public DataTransferRateConverter FromSIUnitGigabytesPerSecond(double v) { return StoreFromContext(this, v, SIGBS, "SIGBS"); }
        //public DataTransferRateConverter FromSIUnitKilobitsPerSecond(double v) { return StoreFromContext(this, v, SIKBIS, "SIKBIS"); }
        //public DataTransferRateConverter FromSIUnitKilobytesPerSecond(double v) { return StoreFromContext(this, v, SIKBS, "SIKBS"); }
        //public DataTransferRateConverter FromSIUnitMegabitsPerSecond(double v) { return StoreFromContext(this, v, SIMBIS, "SIMBIS"); }
        //public DataTransferRateConverter FromSIUnitMegabytesPerSecond(double v) { return StoreFromContext(this, v, SIMBS, "SIMBS"); }
        //public DataTransferRateConverter FromSIUnitPetabitsPerSecond(double v) { return StoreFromContext(this, v, SIPBIS, "SIPBIS"); }
        //public DataTransferRateConverter FromSIUnitPetabytesPerSecond(double v) { return StoreFromContext(this, v, SIPBS, "SIPBS"); }
        //public DataTransferRateConverter FromSIUnitTerabitsPerSecond(double v) { return StoreFromContext(this, v, SITBIS, "SITBIS"); }
        //public DataTransferRateConverter FromSIUnitTerabytesPerSecond(double v) { return StoreFromContext(this, v, SITBS, "SITBS"); }
        //public DataTransferRateConverter FromTerabitsPerSecond(double v) { return StoreFromContext(this, v, TBIS, "TBIS"); }
        //public DataTransferRateConverter FromTerabytesPerSecond(double v) { return StoreFromContext(this, v, TBS, "TBS"); }
        //public DataTransferRateConverter FromUSBs1_0(double v) { return StoreFromContext(this, v, USB1, "USB1"); }
        //public DataTransferRateConverter FromUSBs2_0(double v) { return StoreFromContext(this, v, USB2, "USB2"); }
        //public DataTransferRateConverter FromUSBs3_0(double v) { return StoreFromContext(this, v, USB3, "USB3"); }
        //public DataTransferRateConverter FromUSBs3_1(double v) { return StoreFromContext(this, v, USB31, "USB31"); }

        //public double ToBitsPerSecond() { return PerformConversion(BIS); }
        //public double ToBytesPerSecond() { return PerformConversion(BS); }
        //public double ToEthernetsBase10() { return PerformConversion(E10); }
        //public double ToEthernetsBase100() { return PerformConversion(E100); }
        //public double ToEthernetsBase1000() { return PerformConversion(E1000); }
        //public double ToFireWires400() { return PerformConversion(FW400); }
        //public double ToFireWires800() { return PerformConversion(FW800); }
        //public double ToFireWiresS1600_S3200() { return PerformConversion(FW3200); }
        //public double ToGigabitsPerSecond() { return PerformConversion(GBIS); }
        //public double ToGigabytesPerSecond() { return PerformConversion(GBS); }
        //public double ToISDNsDual() { return PerformConversion(ISDND); }
        //public double ToISDNsSingle() { return PerformConversion(ISDNS); }
        //public double ToKilobitsPerSecond() { return PerformConversion(KBIS); }
        //public double ToKilobytesPerSecond() { return PerformConversion(KBS); }
        //public double ToMegabitsPerSecond() { return PerformConversion(MBIS); }
        //public double ToMegabytesPerSecond() { return PerformConversion(MBS); }
        //public double ToModems110b() { return PerformConversion(M110); }
        //public double ToModems1200b() { return PerformConversion(M1200); }
        //public double ToModems14_4k() { return PerformConversion(M14K); }
        //public double ToModems2400b() { return PerformConversion(M2400); }
        //public double ToModems28_8k() { return PerformConversion(M28K); }
        //public double ToModems300b() { return PerformConversion(M300); }
        //public double ToModems33_6k() { return PerformConversion(M33K); }
        //public double ToModems56k() { return PerformConversion(M56K); }
        //public double ToModems9600b() { return PerformConversion(M9600); }
        //public double ToOCs1() { return PerformConversion(OC1); }
        //public double ToOCs12() { return PerformConversion(OC12); }
        //public double ToOCs192() { return PerformConversion(OC192); }
        //public double ToOCs24() { return PerformConversion(OC24); }
        //public double ToOCs3() { return PerformConversion(OC3); }
        //public double ToOCs48() { return PerformConversion(OC48); }
        //public double ToOCs768() { return PerformConversion(OC768); }
        //public double ToPetabitsPerSecond() { return PerformConversion(PBIS); }
        //public double ToPetabytesPerSecond() { return PerformConversion(PBS); }
        //public double ToSIUnitGigabitsPerSecond() { return PerformConversion(SIGBIS); }
        //public double ToSIUnitGigabytesPerSecond() { return PerformConversion(SIGBS); }
        //public double ToSIUnitKilobitsPerSecond() { return PerformConversion(SIKBIS); }
        //public double ToSIUnitKilobytesPerSecond() { return PerformConversion(SIKBS); }
        //public double ToSIUnitMegabitsPerSecond() { return PerformConversion(SIMBIS); }
        //public double ToSIUnitMegabytesPerSecond() { return PerformConversion(SIMBS); }
        //public double ToSIUnitPetabitsPerSecond() { return PerformConversion(SIPBIS); }
        //public double ToSIUnitPetabytesPerSecond() { return PerformConversion(SIPBS); }
        //public double ToSIUnitTerabitsPerSecond() { return PerformConversion(SITBIS); }
        //public double ToSIUnitTerabytesPerSecond() { return PerformConversion(SITBS); }
        //public double ToTerabitsPerSecond() { return PerformConversion(TBIS); }
        //public double ToTerabytesPerSecond() { return PerformConversion(TBS); }
        //public double ToUSBs1_0() { return PerformConversion(USB1); }
        //public double ToUSBs2_0() { return PerformConversion(USB2); }
        //public double ToUSBs3_0() { return PerformConversion(USB3); }
        //public double ToUSBs3_1() { return PerformConversion(USB31); }
        #endregion
    }




}