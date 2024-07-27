using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 角度
    /// </summary>
    public class WfAngle
    {
        public static double Convert(double value, AngleUnits fromUnits, AngleUnits toUnits)
        {
            return new AngleConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum AngleUnits
    {
        Circles,
        Degrees,
        Gradians,
        Mils,
        Minutes,
        Quadrants,
        Radians,
        Revolutions,
        RightAngles,
        Seconds,
        Sextants,
        Signs,
        Turns,
    }
}
