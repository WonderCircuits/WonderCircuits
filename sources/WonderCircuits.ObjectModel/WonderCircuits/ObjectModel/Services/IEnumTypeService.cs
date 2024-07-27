using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderCircuits.ObjectModel.Services
{
    public interface IEnumTypeService
    {
        IEnumType FindById(int typeId);
        IEnumType FindByName(string typeName);
    }
}
