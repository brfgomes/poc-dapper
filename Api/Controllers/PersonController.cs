using Application.Factories;
using Application.Requests;
using Application.UseCases.Person;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet("person")]
    public async Task<IActionResult> GetPersons(
        [FromServices] IRepositoriesFactory repositoriesFactory)
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await GetPersonsUseCase.Execute(personRepository);
        return Ok(result);
    }
    
    [HttpGet("person/{idPerson}")]
    public async Task<IActionResult> GetPerson(
        [FromServices] IRepositoriesFactory repositoriesFactory,
        string idPerson
        )
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await GetPersonUseCase.Execute(personRepository, new GetPersonRequest(new Guid(idPerson)));
        return Ok(result);
    }
    
    [HttpPost("person/teste")]
    public async Task<IActionResult> GetPerson(
        [FromServices] IRepositoriesFactory repositoriesFactory,
        [FromBody] GetPersonRequest idPerson
    )
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await GetPersonUseCase.Execute(personRepository, idPerson);
        return Ok(result);
    }
    
    [HttpPost("person")]
    public async Task<IActionResult> CreatePerson(
        [FromServices] IRepositoriesFactory repositoriesFactory,
        [FromBody] CreatePersonRequest request
    )
    {
        var personRepository = repositoriesFactory.CreatePersonRepository();
        var result = await CreatePersonUseCase.Execute(personRepository, request);
        return Ok(result);
    }
}