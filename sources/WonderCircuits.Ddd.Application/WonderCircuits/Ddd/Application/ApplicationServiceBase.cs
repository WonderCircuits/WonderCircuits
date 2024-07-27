using System;

namespace WonderCircuits.Ddd.Application
{
    public abstract class ApplicationServiceBase
    {
        protected IServiceProvider Services
        {
            get
            {
                return DependencyInjection.ServiceLocator.Current;
            }
        }
    }
}
