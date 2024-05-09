using Application.Factories;
using Application.Requests;
using Application.UseCases.Person;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class PersonController : ControllerBase
{
    [HttpGet("GetPersons")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IRepositoriesFactory repositoriesFactory)
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await GetPersonsUseCase.Execute(personRepository);
        return Ok(result);
    }
    
    [HttpGet("GetPerson/{idPerson}")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IRepositoriesFactory repositoriesFactory,
        string idPerson
        )
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await GetPersonUseCase.Execute(personRepository, new GetPersonRequest(idPerson));
        return Ok(result);
    }
    
    [HttpPost("CreatePerson")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IRepositoriesFactory repositoriesFactory,
        [FromBody] CreatePersonRequest request
    )
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await CreatePersonUseCase.Execute(personRepository, request);
        return Ok(result);
    }
}