using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 重量
    /// 默认数据库单位是: grams
    /// </summary>
    public class WfWeight
    {
        public const WeightUnits DefaultDatabaseUnit = WeightUnits.Grams;
        #region Grams
        public static double Gram(double value)
        {
            return Convert(value, WeightUnits.Grams, DefaultDatabaseUnit);
        }
        public static double Db2Gram(double value)
        {
            return Convert(value, DefaultDatabaseUnit, WeightUnits.Grams);
        }
        #endregion

        #region Milligrams
        public static double Mg(double value)
        {
            return Convert(value, WeightUnits.Milligrams, DefaultDatabaseUnit);
        }
        public static double Db2Mg(double value)
        {
            return Convert(value, DefaultDatabaseUnit, WeightUnits.Milligrams);
        }
        #endregion

        #region Oz
        public static double Oz(double value)
        {
            return Convert(value, WeightUnits.OuncesUS, DefaultDatabaseUnit);
        }
        public static double Db2Oz(double value)
        {
            return Convert(value, DefaultDatabaseUnit, WeightUnits.OuncesUS);
        }
        #endregion

        public static double Convert(double value, WeightUnits fromUnits, WeightUnits toUnits)
        {
            return new WeightConverter(value, fromUnits).To(toUnits);
        }

    }


    public enum WeightUnits
    {
        Attograms,
        Carats,
        Centigrams,
        Centners,
        Decigrams,
        Dekagrams,
        Exagrams,
        Femtograms,
        Gamma,
        Gigagrams,
        Grams,
        Hectograms,
        Kilograms,
        Kilopounds,
        KilotonsMetric,
        Megagrams,
        Micrograms,
        Milligrams,
        Nanograms,
        OuncesMetric,
        OuncesUS,
        Petagrams,
        Picograms,
        Pounds,
        Quintals,
        Slugs,
        StonesUK,
        StonesUS,
        Teragrams,
        TonsImperial,
        TonsMetric,
        TonsUS,

    }
}
