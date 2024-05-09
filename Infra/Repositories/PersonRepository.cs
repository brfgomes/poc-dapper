using System.Data;
using Application.DTOs;
using Application.Repositories;
using Infra.Factory;
using Models.Domain;
using Dapper;
using Infra.Queries;

namespace Infra.Repositories;

public class PersonRepository(SqlFactory factory) : IPersonRepository
{
    private readonly IDbConnection _connection = factory.CreateConnection();
    public async Task<IEnumerable<PersonDTO>> GetPersons()
    {
        var query = PersonQueries.GetPersonsQuery();
        var persons = await _connection.QueryAsync<PersonDTO>(query.Query, query.Parameters);
        return persons;
    }

    public async Task<PersonDTO> GetPerson(string idPerson)
    {
        var query = PersonQueries.GetPersonByIdQuery(idPerson);
        var person = await _connection.QueryFirstAsync<PersonDTO>(query.Query, query.Parameters);
        return person;
    }

    public async Task<PersonModel> CreatePerson(PersonModel person)
    {
        var query = PersonQueries.InsertPerson(person);
        var result = await _connection.ExecuteAsync(query.Query, query.Parameters);
        return (result > 0) ? person : null;
    }
}