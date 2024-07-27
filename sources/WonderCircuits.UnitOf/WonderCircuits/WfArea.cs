using WonderCircuits.UnitOf;

namespace WonderCircuits
{

    /// <summary>
    /// 面积
    /// 默认数据库单位是: SquareThousandthInches(mil²)
    /// </summary>
    public class WfArea
    {
        public const AreaUnits DefaultDatabseUnit = AreaUnits.SquareThousandthInches;

        #region Centimetres
        public static double Cm(double value)
        {
            return Convert(value, AreaUnits.SquareCentimeters, DefaultDatabseUnit);
        }
        public static double Db2Cm(double value)
        {
            return Convert(value, DefaultDatabseUnit, AreaUnits.SquareCentimeters);
        }
        #endregion

        #region Inches
        public static double Inch(double value)
        {
            return Convert(value, AreaUnits.SquareInches, DefaultDatabseUnit);
        }
        public static double Db2Inch(double value)
        {
            return Convert(value, DefaultDatabseUnit, AreaUnits.SquareInches);
        }
        #endregion

        #region Microns
        public static double Mic(double value)
        {
            return Convert(value, AreaUnits.SquareMicrometers, DefaultDatabseUnit);

        }
        public static double Db2Mic(double value)
        {
            return Convert(value, DefaultDatabseUnit, AreaUnits.SquareMicrometers);

        }
        #endregion

        #region Mil
        public static double Mil(double value)
        {
            return Convert(value, AreaUnits.SquareThousandthInches, DefaultDatabseUnit);

        }
        public static double Db2Mil(double value)
        {
            return Convert(value, DefaultDatabseUnit, AreaUnits.SquareThousandthInches);

        }
        #endregion

        #region Millimetres
        public static double Mm(double value)
        {
            return Convert(value, AreaUnits.SquareMillimeters, DefaultDatabseUnit);

        }
        public static double Db2Mm(double value)
        {
            return Convert(value, DefaultDatabseUnit, AreaUnits.SquareMillimeters);

        }

        #endregion

        public static double Convert(double value, AreaUnits fromUnits, AreaUnits toUnits)
        {
            return new AreaConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum AreaUnits
    {
        Acres,
        Ares,
        Arpents,
        Barns,
        CircularInches,
        CircularMils,
        Hectares,
        Homesteads,
        Roods,
        Sabins,
        SquareCentimeters,
        SquareChains,
        SquareDecimeters,
        SquareDekameters,
        SquareFeet,
        SquareHectometers,
        SquareInches,
        SquareThousandthInches,
        SquareMicroInches,
        SquareKilometers,
        SquareMeters,
        SquareMicrometers,
        SquareMiles,
        SquareMillimeters,
        SquareNanometers,
        SquarePerches,
        SquarePoles,
        SquareRods,
        SquareYards,

    }
}
