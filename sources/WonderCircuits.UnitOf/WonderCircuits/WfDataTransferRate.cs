using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 数据传输
    /// </summary>
    public class WfDataTransferRate
    {
        public static double Convert(double value, DataTransferRateUnits fromUnits, DataTransferRateUnits toUnits)
        {
            return new DataTransferRateConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum DataTransferRateUnits
    {
        BitsPerSecond,
        BytesPerSecond,
        EthernetsBase10,
        EthernetsBase100,
        EthernetsBase1000,
        FireWires400,
        FireWires800,
        FireWiresS1600_S3200,
        GigabitsPerSecond,
        GigabytesPerSecond,
        ISDNsDual,
        ISDNsSingle,
        KilobitsPerSecond,
        KilobytesPerSecond,
        MegabitsPerSecond,
        MegabytesPerSecond,
        Modems110b,
        Modems1200b,
        Modems14_4k,
        Modems2400b,
        Modems28_8k,
        Modems300b,
        Modems33_6k,
        Modems56k,
        Modems9600b,
        OCs1,
        OCs12,
        OCs192,
        OCs24,
        OCs3,
        OCs48,
        OCs768,
        PetabitsPerSecond,
        PetabytesPerSecond,
        SIUnitGigabitsPerSecond,
        SIUnitGigabytesPerSecond,
        SIUnitKilobitsPerSecond,
        SIUnitKilobytesPerSecond,
        SIUnitMegabitsPerSecond,
        SIUnitMegabytesPerSecond,
        SIUnitPetabitsPerSecond,
        SIUnitPetabytesPerSecond,
        SIUnitTerabitsPerSecond,
        SIUnitTerabytesPerSecond,
        TerabitsPerSecond,
        TerabytesPerSecond,
        USBs1_0,
        USBs2_0,
        USBs3_0,
        USBs3_1,
    }
}
