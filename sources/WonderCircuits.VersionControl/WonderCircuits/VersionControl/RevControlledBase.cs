using WonderCircuits.ObjectModel;

namespace WonderCircuits.VersionControl
{
    public abstract class RevControlledBase : InterfaceBase
    {
        public RevControlledBase(string typeName): base(typeName) 
        {

        }

        public IViewInfo ViewInfo { get; set; }
        public IRevisionInfo RevisionInfo { get; set; }
    }

    public abstract class RevControlledDependentBase : RevControlledBase
    {
        public RevControlledDependentBase(string typeName) : base(typeName)
        {

        }
    }

    public abstract class RevControlledItemBase : RevControlledBase
    {
        public RevControlledItemBase(string typeName) : base(typeName)
        {

        }

    }

    public abstract class RevControlledRootBase : RevControlledItemBase
    {
        public RevControlledRootBase(string typeName) : base(typeName)
        {

        }
    }
}
