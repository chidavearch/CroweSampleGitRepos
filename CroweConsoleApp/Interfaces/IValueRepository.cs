using System.Threading.Tasks;

namespace CroweConsoleApp.Interfaces
{
    public interface IValueRepository
    {
        Task<string> GetHelloText();
    }
}
