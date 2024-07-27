using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 速度
    /// </summary>
    public class WfSpeed
    {
        public static double Convert(double value, SpeedUnits fromUnits, SpeedUnits toUnits)
        {
            return new SpeedConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum SpeedUnits
    {
        CentimetersPerHour,
        CentimetersPerMinute,
        CentimetersPerSecond,
        EarthsVelocity,
        FeetPerHour,
        FeetPerMinute,
        FeetPerSecond,
        FirstCosmicVelocity,
        InchesPerHour,
        InchesPerMinute,
        InchesPerSecond,
        KilometersPerHour,
        KilometersPerMinute,
        KilometersPerSecond,
        Knots,
        Light,
        Mach,
        MetersPerHour,
        MetersPerMinute,
        MetersPerSecond,
        MilesPerHour,
        MilesPerMinute,
        MilesPerSecond,
        MillimetersPerHour,
        MillimetersPerMinute,
        MillimetersPerSecond,
        SecondCosmicVelocity,
        SoundsInAir,
        SoundsInWater,
        ThirdCosmicVelocity,
        YardsPerHour,
        YardsPerMinute,
        YardsPerSecond,

    }
}
