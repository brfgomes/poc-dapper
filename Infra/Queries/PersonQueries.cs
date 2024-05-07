using Models.Domain;

namespace Infra.Queries;

public static class PersonQueries
{
    private static readonly string table = Map.ContextMapping.GetPersonsTable();
    public static QueryModel GetPersonsQuery()
    {
        var sql = @$"
            SELECT 
                pers_id AS Id,
                pers_name AS Name,
                pers_years AS Years,
                pers_creation_date AS CreationDate
            FROM {table}";
        return new QueryModel(sql, new {});
    }
    public static QueryModel GetPersonByIdQuery(string id)
    {
        var sql = @$"
            SELECT 
                pers_id AS Id,
                pers_name AS Name,
                pers_years AS Years,
                pers_creation_date AS CreationDate
            FROM {table}
            WHERE pers_id = @Id";
        var parameters = new { Id = new Guid(id) };
        return new QueryModel(sql, parameters);
    }

    public static QueryModel InsertPerson(PersonModel personModel)
    {
        var sql = @$"
            INSERT INTO persons 
                (pers_id, pers_name, pers_years, pers_creation_date)
            VALUES
                (@Id, @Name, @Years, CURRENT_TIMESTAMP);
            ";
        var parameters = new
        {
            Id = Guid.NewGuid(),
            Name = personModel.Name,
            Years = personModel.Years
        };
        return new QueryModel(sql, parameters);
    }
}