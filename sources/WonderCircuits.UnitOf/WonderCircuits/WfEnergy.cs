using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 能量
    /// </summary>
    public class WfEnergy
    {
        public static double Convert(double value, EnergyUnits fromUnits, EnergyUnits toUnits)
        {
            return new EnergyConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum EnergyUnits
    {
        Attojoules,
        BarrelsOfOilEquivalent,
        BTUsInternationalStandard,
        BTUsThermochemical,
        CaloriesInternationalSteam,
        CaloriesNutritional,
        CaloriesThermochemical,
        DyneCentimeters,
        ElectronVolts,
        Ergs,
        FootPounds,
        Gigajoules,
        GigatonsOfTNT,
        GigawattHours,
        GramForceCentimeters,
        GramForceMeters,
        Hartrees,
        HorsepowerHours,
        HorsepowerHoursMetric,
        InchOunces,
        InchPounds,
        Joules,
        KilocaloriesInternationalSteam,
        KilocaloriesThermochemical,
        KiloelectronVolts,
        KilogramForceCentimeters,
        KilogramForceMeters,
        KilogramsOfTNT,
        Kilojoules,
        KilopondMeters,
        KilotonsOfTNT,
        KilowattHours,
        KilowattSeconds,
        LiterAtmospheres,
        MegaBTUsInternationalStandard,
        MegaelectronVolts,
        Megajoules,
        MegatonsOfTNT,
        MegawattHours,
        Microjoules,
        Millijoules,
        Nanojoules,
        NewtonMeters,
        PlanckEnergy,
        PoundalFeet,
        Rydbergs,
        ThermsEC,
        ThermsUS,
        TonsOfTNT,
        WattHours,
        WattSeconds,

    }
}
