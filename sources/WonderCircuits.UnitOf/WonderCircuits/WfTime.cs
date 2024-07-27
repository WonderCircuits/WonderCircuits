using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 时间
    /// </summary>
    public class WfTime
    {
        public static double Convert(double value, TimeUnits fromUnits, TimeUnits toUnits)
        {
            return new TimeConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum TimeUnits
    {
        Attoseconds,
        Centuries,
        Days,
        Decades,
        Femtoseconds,
        Fortnights,
        GregorianYears,
        Hours,
        JulianYears,
        LeapYears,
        Microseconds,
        Millenniums,
        Milliseconds,
        Minutes,
        Months,
        Nanoseconds,
        Picoseconds,
        Seconds,
        Weeks,
        Years,
    }
}
