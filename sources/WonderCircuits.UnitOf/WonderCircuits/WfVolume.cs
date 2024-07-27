using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 体积
    /// </summary>
    public class WfVolume
    {
        public static double Convert(double value, VolumeUnits fromUnits, VolumeUnits toUnits)
        {
            return new VolumeConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum VolumeUnits
    {
        AcreFeetUSSurvey,
        AcreInches,
        ArceFeet,
        Attoliters,
        BarrelsOfOil,
        BarrelsUK,
        BarrelsUS,
        BoardFeet,
        Centiliters,
        Cords,
        CubicCentimeters,
        CubicDecimeters,
        CubicFeet,
        CubicInches,
        CubicKilometers,
        CubicMeters,
        CubicMiles,
        CubicMillimeters,
        CubicYards,
        CupsMetric,
        CupsUK,
        CupsUS,
        Deciliters,
        Decisteres,
        Dekaliters,
        Dekasteres,
        DessertspoonsUK,
        DessertspoonsUS,
        Drops,
        Exaliters,
        Femtoliters,
        FluidOuncesUK,
        FluidOuncesUS,
        GallonsUK,
        GallonsUS,
        Gigaliters,
        GillsUK,
        GillsUS,
        Hectoliters,
        Hogsheads,
        HundredCubicFeet,
        Kiloliters,
        Liters,
        Megaliters,
        Microliters,
        Milliliters,
        MinimsUK,
        MinimsUS,
        Nanoliters,
        Petaliters,
        Picoliters,
        PintsUK,
        PintsUS,
        QuartsUK,
        QuartsUS,
        RegisterTons,
        Steres,
        TablespoonsMetric,
        TablespoonsUK,
        TablespoonsUS,
        TeaspoonsMetric,
        TeaspoonsUK,
        TeaspoonsUS,
        Teraliters,
        Tuns,

    }
}
