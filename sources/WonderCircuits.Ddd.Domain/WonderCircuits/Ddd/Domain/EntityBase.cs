using System;
using WonderCircuits.Mvvm;

namespace WonderCircuits.Ddd.Domain
{
    public abstract class EntityBase : BindableBase, IEntity
    {

        protected IServiceProvider Services
        {
            get
            {
                return WonderCircuits.DependencyInjection.ServiceLocator.Current;
            }
        }
    }

    public interface IEntity
    {

    }

    public interface IAggregateRoot : IEntity
    {

    }

}
