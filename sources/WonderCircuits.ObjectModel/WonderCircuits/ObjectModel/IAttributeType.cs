namespace WonderCircuits.ObjectModel
{
    public interface IAttributeType
    {
        int Id { get; }
        string FieldName { get; }
        AttributeType Type { get; }
        AttributeContentType ContentType { get; }
        int? EnumId { get; }
    }


    public enum AttributeContentType
    {
        Int,
        Double,
        Bool,
        Enum,
        String,
        Datetime,
    }
    public enum AttributeType
    {
        Property,
        UDA
    }

}
