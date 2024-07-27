using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 数据存储
    /// </summary>
    public class WfDataStorage
    {
        public static double Convert(double value, DataStorageUnits fromUnits, DataStorageUnits toUnits)
        {
            return new DataStorageConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum DataStorageUnits
    {
        Bits,
        Blocks,
        BluRay_DoubleLayer,
        BluRay_SingleLayer,
        Bytes,
        CDs_74Minutes,
        CDs_80Minutes,
        DVDs_DoubleSidedDoubleLayer,
        DVDs_DoubleSidedSingleLayer,
        DVDs_SingleSidedDoubleLayer,
        DVDs_SingleSidedSingleLayer,
        Exabits,
        Exabytes,
        FloppyDisks_35DD,
        FloppyDisks_35ED,
        FloppyDisks_35HD,
        FloppyDisks_525DD,
        FloppyDisks_525HD,
        Gigabits,
        Gigabytes,
        Kilobits,
        Kilobytes,
        Megabits,
        Megabytes,
        Nibbles,
        Petabits,
        Petabytes,
        SIUnitExabits,
        SIUnitExabytes,
        SIUnitGigabits,
        SIUnitGigabytes,
        SIUnitKilobits,
        SIUnitKilobytes,
        SIUnitMegabits,
        SIUnitMegabytes,
        SIUnitPetabits,
        SIUnitPetabytes,
        SIUnitTerabits,
        SIUnitTerabytes,
        SIUnitYottabits,
        SIUnitYottabytes,
        SIUnitZettabits,
        SIUnitZettabytes,
        Terabits,
        Terabytes,
        Words,
        Yottabits,
        Yottabytes,
        Zettabits,
        Zettabytes,
    }
}
