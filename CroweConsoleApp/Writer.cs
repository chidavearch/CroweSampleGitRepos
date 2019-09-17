using System;
using CroweConsoleApp.Interfaces;

namespace CroweConsoleApp
{
    public class Writer : IWriter
    {
        public void WriteMessage(string output)
        {
            Console.WriteLine(output);
        }
    }
}
