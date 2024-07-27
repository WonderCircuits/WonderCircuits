using System.Collections.Generic;

namespace WonderCircuits.ObjectModel.Services
{
    public interface IAttributeTypeService
    {
        IAttributeType FindById(int attrId);
        IEnumerable<IAttributeType> FindAllByInterfaceTypeName(string intName);
    }
}
