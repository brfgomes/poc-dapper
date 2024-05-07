using Application.DTOs;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Domain;

namespace Api.Controllers;

public class PersonController : ControllerBase
{
    [HttpGet("GetPersons")]
    public async Task<IEnumerable<PersonDTO>> GetUsers(
        [FromServices] IPersonRepository repository)
    {
        var result = await repository.GetPersons();
        return result;
    }
    
    [HttpGet("GetPerson/{idPerson}")]
    public async Task<PersonDTO> GetUsers(
        [FromServices] IPersonRepository repository,
        string idPerson
        )
    {
        var result = await repository.GetPerson(idPerson);
        return result;
    }
    
    [HttpPost("CreatePerson")]
    public async Task<string> GetUsers(
        [FromServices] IPersonRepository repository,
        [FromBody] PersonModel personModel
    )
    {
        var result = await repository.CreatePerson(personModel);
        return result;
    }
}