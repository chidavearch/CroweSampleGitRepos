using System;
using StructureMap;
using CroweConsoleApp.Interfaces;

namespace CroweConsoleApp
{
    class Program
    {
        /// <summary>
        /// MUST SET the port number of the Rest project in app config setting "restHostNumber"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var container = Container.For<DIRegistry>();
            var app = container.GetInstance<ConsoleApp>();
            app.Run();
            Console.ReadLine();
        }
    }
}
