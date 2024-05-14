using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;
using Flunt.Notifications;
using Models.Domain;
using Models.Domain.Enums;
using Models.Domain.ValueObjects;

namespace Application.UseCases.Person;

public static class CreatePersonUseCase
{
    public static async Task<GenericResponse<PersonDTO>> Execute(IPersonRepository personRepository, CreatePersonRequestTeste request)
    {
        // if(!request.IsValid) { return new GenericResponse<PersonDTO>(false, null, request.Notifications); }
        
        var personModel = new PersonModel(Guid.NewGuid(), (EStatus) request.Status, request.Name, request.Years, request.Email, new Cnpj(request.Cnpj), DateTime.Now);
        if (!personModel.IsValid) { return new GenericResponse<PersonDTO>(false, null, personModel.Notifications); }
        
        var getPersonResult = await personRepository.CreatePerson(personModel);
        var personDTO = new PersonDTO(getPersonResult.Id, getPersonResult.Status, getPersonResult.Name, getPersonResult.Years, getPersonResult.Email, getPersonResult.Cnpj.Value, getPersonResult.CreationDate);
        return new GenericResponse<PersonDTO>(true, personDTO, null);
    }
}