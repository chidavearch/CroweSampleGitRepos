using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CroweConsoleApp.Interfaces;

namespace CroweConsoleApp
{
    public class ConsoleApp : IConsoleApp
    {
        private readonly IWriter _writer;
        private readonly IValueRepository _repos;

        public ConsoleApp(IWriter writer, IValueRepository repository)
        {
            _writer = writer;
            _repos = repository;
        }

        public async void Run()
        {
            string messageText = await GetValue();  // await _repos.GetHelloText();
            WriteValue(messageText);                //_writer.WriteMessage(messageText);
        }

        public async Task<string> GetValue()
        {
            return await _repos.GetHelloText();
        }

        private void WriteValue(string messageText)
        {
            _writer.WriteMessage(messageText);
        }
    }
}
