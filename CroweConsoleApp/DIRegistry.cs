using System;
using System.Collections.Generic;
using System.Linq;
using StructureMap;

namespace CroweConsoleApp
{
    public class DIRegistry : Registry
    {
        public DIRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}
