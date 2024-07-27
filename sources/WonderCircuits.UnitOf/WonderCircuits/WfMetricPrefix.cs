using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 国际单位制词头
    /// </summary>
    public class WfMetricPrefix
    {
        public static double Convert(double value, MetricPrefixUnits fromUnits, MetricPrefixUnits toUnits)
        {
            return new MetricPrefixConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum MetricPrefixUnits
    {
        Atto,
        Centi,
        Deci,
        Deka,
        Exa,
        Femto,
        Giga,
        Hecto,
        Kilo,
        Mega,
        Micro,
        Milli,
        Nano,
        NoPrefix,
        Peta,
        Pico,
        Tera,
        Yocto,
        Yotta,
        Zepto,
        Zetta,
    }
}
