using System;

namespace WonderCircuits.DependencyInjection
{
    public class ServiceLocator
    {
        public static IServiceProvider Current { get; private set; }

        public static void SetCurrent(IServiceProvider provider)
        {
            if(Current == null)
            {
                Current = provider;
            }
        }
    }
}
