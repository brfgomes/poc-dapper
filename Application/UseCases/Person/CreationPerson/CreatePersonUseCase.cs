using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;
using FluentValidation;
using Models.Domain;
using Models.Domain.Enums;
using Models.Domain.ValueObjects;

namespace Application.UseCases.Person;

public static class CreatePersonUseCase
{
    public static async Task<GenericResponse<PersonDTO>> Execute(IPersonRepository personRepository, CreatePersonRequest request)
    {
        var personModel = new PersonModel(Guid.NewGuid(), (EStatus) request.Status, request.Name, request.Years, request.Email, new Cnpj(request.Cnpj), DateTime.Now);

        var personValidator = new CreatePersonModelValidator();
        var validationResult = personValidator.Validate(personModel);
        
        if (!validationResult.IsValid) { return new GenericResponse<PersonDTO>(false, null, validationResult.Errors); }
        
        var getPersonResult = await personRepository.CreatePerson(personModel);
        var personDTO = new PersonDTO(getPersonResult.Id, getPersonResult.Status, getPersonResult.Name, getPersonResult.Years, getPersonResult.Email, getPersonResult.Cnpj.Value, getPersonResult.CreationDate);
        return new GenericResponse<PersonDTO>(true, personDTO, null);
    }
}