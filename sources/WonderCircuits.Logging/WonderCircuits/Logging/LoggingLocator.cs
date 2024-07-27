using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderCircuits.Logging
{
    public class LoggingLocator
    {
        public static ILoggerFactory? Current { get; private set; }

        public static void SetCurrent(ILoggerFactory? factory)
        {
            if (Current == null)
            {
                Current = factory;
            }
        }
    }
}
