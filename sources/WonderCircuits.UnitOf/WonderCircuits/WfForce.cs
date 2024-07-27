using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 力
    /// </summary>
    public class WfForce
    {
        public static double Convert(double value, ForceUnits fromUnits, ForceUnits toUnits)
        {
            return new ForceConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum ForceUnits
    {
        AtomicUnitsOfForce,
        Attonewtons,
        Centinewtons,
        Decinewtons,
        Dekanewtons,
        Dynes,
        Exanewtons,
        Femtonewtons,
        Giganewtons,
        GramForces,
        GraveForces,
        Hectonewtons,
        JouleCentimeters,
        JouleMeters,
        KilogramForces,
        Kilonewtons,
        Kiloponds,
        KilopoundForces,
        LongTonForces,
        Meganewtons,
        MetricTonForces,
        Micronewtons,
        MilligraveForces,
        Millinewtons,
        Nanonewtons,
        Newtons,
        OunceForces,
        Petanewtons,
        Piconewtons,
        Ponds,
        Poundals,
        PoundFeetPerSecondSquared,
        PoundForces,
        ShortTonForces,
        Sthenes,
        Teranewtons,

    }
}
