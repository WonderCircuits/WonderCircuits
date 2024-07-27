using System.Collections.Generic;

namespace WonderCircuits.ObjectModel
{
    public interface IEnumType
    {
        int Id { get; }
        string Name { get; }

        IEnumerable<IEnumValue> GetValues();
        IEnumValue GetValue(int index);
        IEnumValue GetValue(string value);
    }

    public interface IEnumValue
    {
        int Index { get; }
        string Value { get; }
        string DisplayValue { get; }
    }
}
