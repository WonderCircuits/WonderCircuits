namespace WonderCircuits.ObjectModel.Services
{
    public interface IInterfaceTypeService
    {

        IInterfaceType FindById(int id);
        IInterfaceType FindByName(string name);
    }
}
