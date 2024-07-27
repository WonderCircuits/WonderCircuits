using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 油耗
    /// </summary>
    public class WfFuelEconomy
    {
        public static double Convert(double value, FuelEconomyUnits fromUnits, FuelEconomyUnits toUnits)
        {
            return new FuelEconomyConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum FuelEconomyUnits
    {
        CentimetersPerLiter,
        DekametersPerLiter,
        ExametersPerLiter,
        GigametersPerLiter,
        HectometersPerLiter,
        KilometersPerGallonUK,
        KilometersPerGallonUS,
        KilometersPerLiter,
        MegametersPerLiter,
        MetersPerCubicCentimeter,
        MetersPerCubicFoot,
        MetersPerCubicInch,
        MetersPerCubicMeter,
        MetersPerCubicYard,
        MetersPerCupUK,
        MetersPerCupUS,
        MetersPerFluidOunceUK,
        MetersPerFluidOunceUS,
        MetersPerGallonUK,
        MetersPerGallonUS,
        MetersPerLiter,
        MetersPerPintUK,
        MetersPerPintUS,
        MetersPerQuartUK,
        MetersPerQuartUS,
        MilesPerGallonUK,
        MilesPerGallonUS,
        MilesPerLiterUS,
        NauticalMilesPerGallonUS,
        NauticalMilesPerLiter,
        PetametersPerLiter,
        TerametersPerLiter,
    }
}
