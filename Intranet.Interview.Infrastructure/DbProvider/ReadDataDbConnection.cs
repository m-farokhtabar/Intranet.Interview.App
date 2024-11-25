using Intranet.Interview.Infrastructure.Data.ReadDb;

namespace Intranet.Interview.Infrastructure.DbProvider;

public class ReadDataDbConnection : IReadDataDbConnection
{
    public ReadDataDbConnection(string connection)
    {
        ConnectionString = connection;
    }
    public string ConnectionString { get; set; } = string.Empty;
}
