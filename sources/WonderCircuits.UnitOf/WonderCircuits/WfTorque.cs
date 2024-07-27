using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 扭矩
    /// </summary>
    public class WfTorque
    {
        public static double Convert(double value, TorqueUnits fromUnits, TorqueUnits toUnits)
        {
            return new TorqueConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum TorqueUnits
    {
        DyneCentimeters,
        DyneMeters,
        DyneMillimeters,
        GramCentimeters,
        GramMeters,
        GramMillimeters,
        KilogramCentimeters,
        KilogramMeters,
        KilogramMillimeters,
        KilonewtonMeters,
        NewtonCentimeters,
        NewtonMeters,
        NewtonMillimeters,
        OunceFeet,
        OunceInches,
        PoundFeet,
        PoundInches,

    }
}
