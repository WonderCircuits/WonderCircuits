using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 长度
    /// 默认数据库单位是: ThousandthInches(also mil)
    /// </summary>
    public class WfLength
    {
        public const LengthUnits DefaultDatabseUnit = LengthUnits.ThousandthInches;

        #region Centimetres
        public static double Cm(double value)
        {
            return Convert(value, LengthUnits.Centimeters, DefaultDatabseUnit);
        }
        public static double Db2Cm(double value)
        {
            return Convert(value, DefaultDatabseUnit, LengthUnits.Centimeters);
        }
        #endregion

        #region Inches
        public static double Inch(double value)
        {
            return Convert(value, LengthUnits.Inches, DefaultDatabseUnit);
        }
        public static double Db2Inch(double value)
        {
            return Convert(value, DefaultDatabseUnit, LengthUnits.Inches);
        }
        #endregion

        #region Microns
        public static double Mic(double value)
        {
            return Convert(value, LengthUnits.Micrometers, DefaultDatabseUnit);

        }
        public static double Db2Mic(double value)
        {
            return Convert(value, DefaultDatabseUnit, LengthUnits.Micrometers);

        }
        #endregion

        #region Mil
        public static double Mil(double value)
        {
            return Convert(value, LengthUnits.ThousandthInches, DefaultDatabseUnit);

        }
        public static double Db2Mil(double value)
        {
            return Convert(value, DefaultDatabseUnit, LengthUnits.ThousandthInches);

        }
        #endregion

        #region Millimetres
        public static double Mm(double value)
        {
            return Convert(value, LengthUnits.Millimeters, DefaultDatabseUnit);

        }
        public static double Db2Mm(double value)
        {
            return Convert(value, DefaultDatabseUnit, LengthUnits.Millimeters);

        }

        #endregion

        public static double Convert(double value, LengthUnits fromUnits, LengthUnits toUnits)
        {
            return new LengthConverter(value, fromUnits).To(toUnits);
        }



    }

    public enum LengthUnits
    {
        Angstroms,
        Attometers,
        Barleycorns,
        CablesImperial,
        CablesInternational,
        CablesUSCustomary,
        Caliber,
        CentiInches,
        Centimeters,
        Chains,
        Cubits,
        Decimeters,
        Dekameters,
        Ells,
        Exameters,
        Fathoms,
        Feet,
        Femtometers,
        Fingers,
        Furlongs,
        Gigameters,
        Hands,
        Hectometers,
        Inches,
        Kilometers,
        Kiloyards,
        Leagues,
        LightYears,
        Links,
        Megameters,
        Meters,
        MicroInches,
        Micrometers,
        Microns,
        Miles,
        Millimeters,
        Nails,
        Nanometers,
        NauticalLeaguesInternational,
        NauticalLeaguesUK,
        NauticalMilesInternational,
        NauticalMilesUK,
        NauticalMilesUSCustomary,
        Perches,
        Petameters,
        Picometers,
        Poles,
        Rods,
        Ropes,
        Spans,
        Terameters,
        ThousandthInches,
        Yards,
    }
}
