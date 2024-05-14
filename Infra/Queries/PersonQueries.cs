using Models.Domain;

namespace Infra.Queries;

public static class PersonQueries
{
    private static readonly string table = "persons";
    public static QueryModel GetPersonsQuery()
    {
        var sql = @$"
            SELECT 
                pers_id AS Id,
                pers_status AS Status,
                pers_name AS Name,
                pers_years AS Years,
                pers_email AS Email,
                pers_cnpj AS Cnpj,
                pers_creation_date AS CreationDate
            FROM {table}";
        return new QueryModel(sql, new {});
    }
    public static QueryModel GetPersonByIdQuery(string id)
    {
        var sql = @$"
            SELECT 
                pers_id AS Id,
                pers_status AS Status,
                pers_name AS Name,
                pers_years AS Years,
                pers_email AS Email,
                pers_cnpj AS Cnpj,
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
                (pers_id, pers_status, pers_name, pers_years, pers_email, pers_cnpj, pers_creation_date)
            VALUES
                (@Id, @Status, @Name, @Years, @Email, @Cnpj ,CURRENT_TIMESTAMP);
            ";
        var parameters = new
        {
            Id = Guid.NewGuid(),
            personModel.Name,
            personModel.Status,
            personModel.Years,
            personModel.Email,
            Cnpj = personModel.Cnpj.Value
        };
        return new QueryModel(sql, parameters);
    }
}