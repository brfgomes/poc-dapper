using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.UseCases.Person;
using Microsoft.AspNetCore.Mvc;
using Models.Domain;

namespace Api.Controllers;

public class PersonController : ControllerBase
{
    [HttpGet("GetPersons")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IPersonRepository personRepository)
    {
        var result = await GetPersonsUseCase.Execute(personRepository);
        return Ok(result);
    }
    
    [HttpGet("GetPerson/{idPerson}")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IPersonRepository personRepository,
        string idPerson
        )
    {
        var result = await GetPersonUseCase.Execute(personRepository, new GetPersonRequest(idPerson));
        return Ok(result);
    }
    
    [HttpPost("CreatePerson")]
    public async Task<IActionResult> GetUsers(
        [FromServices] IPersonRepository repository,
        [FromBody] CreatePersonRequest request
    )
    {
        var result = await CreatePersonUseCase.Execute(repository, request);
        return Ok(result);
    }
}