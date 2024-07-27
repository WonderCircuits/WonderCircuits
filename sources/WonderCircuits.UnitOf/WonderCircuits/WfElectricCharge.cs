using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 电量
    /// </summary>
    public class WfElectricCharge
    {
        public static double Convert(double value, ElectricChargeUnits fromUnits, ElectricChargeUnits toUnits)
        {
            return new ElectricChargeConverter(value, fromUnits).To(toUnits);
        }

    }

    public enum ElectricChargeUnits
    {
        Abcoulombs,
        AmpereHours,
        AmpereMinutes,
        AmpereSeconds,
        Coulombs,
        ElectronCharge,
        EMUsOfCharge,
        ESUsOfCharge,
        FaradayCarbon12,
        FaradayChemistry,
        FaradayPhysics,
        FaradVolts,
        Franklins,
        Kilocoulombs,
        Megacoulombs,
        Microcoulombs,
        Millicoulombs,
        Nanocoulombs,
        Picocoulombs,
        Statcoulombs,

    }
}
