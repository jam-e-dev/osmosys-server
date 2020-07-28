using DataAccess.Connections;
using Npgsql;

namespace DataAccess.Implementation.Connections
{
    public class ServerConnection : ConnectionBase, IServerConnection<NpgsqlConnection>
    {
        private const string ServerConnStr = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=password;";

        public ServerConnection() : base(ServerConnStr) {}
    }
}