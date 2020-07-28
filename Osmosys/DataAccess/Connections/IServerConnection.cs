using System.Threading.Tasks;

namespace DataAccess.Connections
{
    public interface IServerConnection<out T>
    {
        T Current { get; }
        
        Task OpenAsync();

        Task CloseAsync();
    }
}