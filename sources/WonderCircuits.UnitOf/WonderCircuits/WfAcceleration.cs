using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonderCircuits.UnitOf;

namespace WonderCircuits
{
    /// <summary>
    /// 加速度
    /// </summary>
    public class WfAcceleration
    {
        public static double Convert(double value, AccelerationUnits fromUnits, AccelerationUnits toUnits)
        {
            return new AccelerationConverter(value, fromUnits).To(toUnits);
        }
    }

    public enum AccelerationUnits
    {
        AttometersPerSecondSquared,
        CentimeterPerSecondSquared,
        DecimetersPerSecondSquared,
        DekametersPerSecondSquared,
        ExametersPerSecondSquared,
        FeetPerHourPerSecond,
        FeetPerMinutePerSecond,
        FeetPerSecondSquared,
        FemtometersPerSecondSquared,
        Galileos,
        GigametersPerSecondSquared,
        Gravity,
        HectometersPerSecondSquared,
        InchesPerMinutePerSecond,
        InchesPerSecondSquared,
        KilometersPerHourPerSecond,
        KilometersPerHourSquared,
        KilometersPerSecondSquared,
        KnotsPerSecond,
        MegametersPerSecondSquared,
        MetersPerSecondSquared,
        Microgalileos,
        MicrometersPerSecondSquared,
        MilesPerHourPerSecond,
        MilesPerMinutePerSecond,
        MilesPerSecondSquared,
        Milligalileos,
        MillimetersPerSecondSquared,
        NanometersPerSecondSquared,
        PetametersPerSecondSquared,
        PicometersPerSecondSquared,
        TerametersPerSecondSquared,
        YardsPerSecondSquared,
    }
}
