using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;
using Flunt.Notifications;
using MediatR;
using Models.Domain;

namespace Application.UseCases.Person;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, GenericResponse<CreatePersonResponse>>
{
    public Task<GenericResponse<CreatePersonResponse>> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        // if(!request.IsValid) { return new GenericResponse<PersonDTO>(false, null, request.Notifications); }
        //     
        // var personModel = new PersonModel(Guid.NewGuid(), request.Name, request.Years, request.Email, request.Cnpj, DateTime.Now);
        // if (!personModel.IsValid) { return new GenericResponse<PersonDTO>(false, null, personModel.Notifications); }
        //     
        // var getPersonResult = await personRepository.CreatePerson(personModel);
        // var personDTO = new PersonDTO(getPersonResult.Id, getPersonResult.Name, getPersonResult.Years, getPersonResult.Email, getPersonResult.Cnpj, getPersonResult.CreationDate);
        // return new GenericResponse<PersonDTO>(true, personDTO, null);
    }
}