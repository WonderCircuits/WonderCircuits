using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 频率
    /// </summary>
    public class WfFrequency
    {
        public static double Convert(double value, FrequencyUnits fromUnits, FrequencyUnits toUnits)
        {
            return new FrequencyConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum FrequencyUnits
    {
        Attohertz,
        Centihertz,
        CyclesPerSecond,
        Decihertz,
        Dekahertz,
        Exahertz,
        Femtohertz,
        Gigahertz,
        Hectohertz,
        Hertz,
        Kilohertz,
        Megahertz,
        Microhertz,
        Millihertz,
        Nanohertz,
        Petahertz,
        Picohertz,
        RevolutionsPerDay,
        RevolutionsPerHour,
        RevolutionsPerMinute,
        RevolutionsPerSecond,
        Terahertz,
    }
}
