using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Windows;

namespace WonderCircuits.Windows
{
    public class ApplicationBase : System.Windows.Application
    {
        public ApplicationBase() 
        {
            //RegisterProvider GB2312 Encodings
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private IHost _Host;
        public IServiceProvider Services { get => _Host?.Services; }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder();
            OnHostConfiguring(builder);
            _Host = builder.Build();
            WonderCircuits.DependencyInjection.ServiceLocator.SetCurrent(Services);
            WonderCircuits.Logging.LoggingLocator.SetCurrent(Services?.GetService<ILoggerFactory>());
            OnHostStarting();
            await _Host.StartAsync();
            OnHostStarted();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
           if(_Host != null)
            {
                using (_Host)
                {
                    OnHostStopping();
                    await _Host.StopAsync();
                    OnHostStopped();
                }
            }
            base.OnExit(e);
        }

        protected virtual void OnHostConfiguring(IHostBuilder builder){   }

        protected virtual void OnHostStarting() {  }
        protected virtual void OnHostStarted() { }


        protected virtual void OnHostStopping() { }
        protected virtual void OnHostStopped() { }
    }

    public class Application : ApplicationBase
    {

    }
}

