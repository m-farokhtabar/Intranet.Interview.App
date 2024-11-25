using Dapper;
using Intranet.Interview.Application.DataForm.Dto;
using Intranet.Interview.Application.SeedWorks;
using Intranet.Interview.Infrastructure.Data.ReadDb;
using System.Data.SQLite;
using System.Security.Principal;
using System.Text.Json;

namespace Intranet.Interview.Infrastructure.DbProvider;

internal class FormMetaDataProvider : IFormMetaDataProvider
{
    private readonly IReadDataDbConnection dbConnection;

    public FormMetaDataProvider(IReadDataDbConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }
    public async Task<FormMetadataDto?> Get(Guid id)
    {
        using (var connection = new SQLiteConnection(dbConnection.ConnectionString))
        {
            string gId = id.ToString();            
            string query = "SELECT Content FROM FormMetaData WHERE Id = @Id";
            string? content = await connection.QueryFirstOrDefaultAsync<string>(query, new { Id = gId });            
            if (content == null)
                return null;
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };            
            return JsonSerializer.Deserialize<FormMetadataDto>(content, options);
        }
    }
}
