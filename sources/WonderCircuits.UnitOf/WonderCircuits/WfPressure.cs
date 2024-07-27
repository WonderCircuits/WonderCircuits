using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 压力
    /// </summary>
    public class WfPressure
    {
        public static double Convert(double value, PressureUnits fromUnits, PressureUnits toUnits)
        {
            return new PressureConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum PressureUnits
    {
        Attopascals,
        Bars,
        Baryes,
        CentimetersOfMercury0C,
        CentimetersOfWater4C,
        Centipascals,
        Decibars,
        Decipascals,
        Dekapascals,
        DynesPerSquareCentimeter,
        Exapascals,
        FeetOfSeaWater,
        FeetOfWater4C,
        FeetOfWater60F,
        Femtopascals,
        Gigapascals,
        GramsPerSquareCentimeter,
        Hectopascals,
        InchesOfMercury32F,
        InchesOfMercury60F,
        InchesOfWater4C,
        InchesOfWater60F,
        KilogramsPerSquareCentimeter,
        KilogramsPerSquareMeter,
        KilogramsPerSquareMillimeter,
        KilonewtonsPerSquareMeter,
        Kilopascals,
        KipsPerSquareInch,
        KSI,
        LongTonsPerSquareFoot,
        LongTonsPerSquareInch,
        Megapascals,
        MetersOfSeaWater,
        MetersOfWater4C,
        Microbars,
        Micropascals,
        Millibars,
        MillimetersOfMercury0C,
        MillimetersOfWater4C,
        Millipascals,
        Nanopascals,
        NewtonsPerSquareCentimeter,
        NewtonsPerSquareMeter,
        NewtonsPerSquareMillimeter,
        Pascals,
        Petapascals,
        Picopascals,
        Pieze,
        PoundalsPerSquareFoot,
        PoundsPerSquareFoot,
        PoundsPerSquareInch,
        PSI,
        ShortTonsPerSquareFoot,
        ShortTonsPerSquareInch,
        StandardAtmospheres,
        SthenesPerSquareMeter,
        TechnicalAtmospheres,
        Terapascals,
        Torrs,

    }
}
