using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;
using Models.Domain;

namespace Application.UseCases.Person;

public static class CreatePersonUseCase
{
    public static async Task<GenericResponse<PersonDTO>> Execute(IPersonRepository personRepository, CreatePersonRequest request)
    {
        //validacoes aqui
        var isSuccess = true;
        var personModel = new PersonModel(Guid.NewGuid(), request.name, request.years, DateTime.Now);
        var getPersonResult = await personRepository.CreatePerson(personModel);
        var personDTO = new PersonDTO(getPersonResult.Id, getPersonResult.Name, getPersonResult.Years, getPersonResult.CreationDate);
        return new GenericResponse<PersonDTO>(isSuccess, personDTO);
    }
}