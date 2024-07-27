using System;
using System.Collections.Generic;

namespace WonderCircuits.UnitOf
{
    public class BaseNumberConverter
    {
        public BaseNumberConverter()
        {
            Context = new NumberConverterContext();
        }
        public BaseNumberConverter(NumberConverterContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Instantiate class NumberConverterContext.cs for variables needed to perform conversions.
        /// </summary>
        public NumberConverterContext Context { get; private set; }


        /// <summary>
        /// Stores the needed values to do conversions of the measurement.
        /// This overload of the method is used in "From" methods in every measurement class other than Anything() and DataType().
        /// </summary>
        /// <param name="t">Class context of measurement passed (usually "this" is passed from caller).</param>
        /// <param name="v">User passed "From" value (double).</param>
        /// <param name="tt">Struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <param name="ty">String value of the struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <returns>class context passed in so variable like "UnitOf.LengthConverter len" can be used as the variable type</returns>
        protected void StoreFromContext(NumberConverterContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Used by every measurement class that converts just numbers (Anything() and DataType() do not apply here).
        /// Method performs the full conversion of taking the user defined "From" value and converting it into the user desired "Convert" value.
        /// </summary>
        /// <param name="toConstant">Struct readonly constant value of "Convert" unit. Unit being converted into conversion constant value.</param>
        /// <param name="isMultiplyThenDivide">Multiply then divide conversion algorithm, false will divide then multiply when converting "Convert"</param>
        /// <returns>Finished conversion. "from" converted into "to" value.</returns>
        protected double PerformConversion(double toConstant, bool isMultiplyThenDivide)
        {
            var value = Context.Value;
            var fromConstant = Context.Bases;
            return MultiplyOrDevide(MultiplyOrDevide(value, toConstant, isMultiplyThenDivide), fromConstant, !isMultiplyThenDivide);
        }

        /// <summary>
        /// All conversions use the following method to multiply or divide depending on how the measurement'StoreFromContext units are defined (See struct readonly constants).
        /// </summary>
        private static double MultiplyOrDevide(double x, double y, bool isMultiply)
        {
            return isMultiply ? (x * y) : (x / y);
        }
    }

    /// <summary>
    /// Instantiated variables from new UnitOf instance (Only used in class BaseNumberConverter).
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class NumberConverterContext
    {
        /// <summary>
        /// Empty constructor only called when instantiating from class BaseNumberConverter.cs
        /// </summary>
        public NumberConverterContext() : this(-1, -1, string.Empty)
        {

        }

        public NumberConverterContext(double value, double fromconst) : this(value, fromconst, string.Empty)
        {

        }

        /// <summary>
        /// Only used in class BaseNumberConverter.cs when measurement "From" method only converts numbers.
        /// All measurements other than DataType use this constructor.
        /// </summary>
        /// <param name="w">User passed "From" value (double).</param>
        /// <param name="s">Struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <param name="z">String value of struct readonly constant representing the "From" method of the measurement used.</param>
        public NumberConverterContext(double w, double s, string z)
        {
            Value = w;
            Bases = s;
            Label = z;
        }

        /// <summary>
        /// 需要转换的原单位值
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        /// 需要转换的原单位基数
        /// </summary>
        public double Bases { get; private set; }

        /// <summary>
        /// 需要转换的原单位类型
        /// </summary>
        public string Label { get; private set; }

    }
}