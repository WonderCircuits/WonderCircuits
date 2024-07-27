using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 温度
    /// 默认数据库单位是: Celsius 
    /// </summary>
    public class WfTemperature
    {
        public const TemperatureUnits DefaultDatabaseUnit = TemperatureUnits.Celsius;
        #region Celcius
        public static double Cel(double value)
        {
            return Convert(value, TemperatureUnits.Celsius, DefaultDatabaseUnit);
        }
        public static double Db2Cel(double value)
        {
            return Convert(value, DefaultDatabaseUnit, TemperatureUnits.Celsius);
        }
        #endregion

        #region Fahrenheit
        public static double Fahr(double value)
        {
            return Convert(value, TemperatureUnits.Fahrenheit, DefaultDatabaseUnit);
        }
        public static double Db2fahr(double value)
        {
            return Convert(value, DefaultDatabaseUnit, TemperatureUnits.Fahrenheit);
        }
        #endregion


        public static double Convert(double value, TemperatureUnits fromUnits, TemperatureUnits toUnits)
        {
            return new TemperatureConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum TemperatureUnits
    {
        Celsius,
        Fahrenheit,
        Kelvin,
        Rankine,
        Reaumur,

    }
}
