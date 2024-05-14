using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Models.Domain.Enums;
using Npgsql;

namespace Infra.Factory;

public class SqlFactory(IConfiguration configuration)
{
    public IDbConnection CreateConnection()
    {
        var connectionString = configuration.GetSection("ConnectionString").Value;
        return new NpgsqlConnection(connectionString);
    }
}