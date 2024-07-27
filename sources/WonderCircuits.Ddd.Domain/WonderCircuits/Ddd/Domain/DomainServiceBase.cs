using System;

namespace WonderCircuits.Ddd.Domain
{
    public abstract class DomainServiceBase
    {
        protected IServiceProvider Services
        {
            get
            {
                return WonderCircuits.DependencyInjection.ServiceLocator.Current; 
            }
        }
    }


}
