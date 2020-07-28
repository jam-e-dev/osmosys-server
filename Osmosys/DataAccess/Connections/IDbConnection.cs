namespace DataAccess.Connections
{
    public interface IDbConnection<out T> : IServerConnection<T>
    {
    }
}