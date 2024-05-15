using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;

namespace Application.UseCases.Person;

public static class GetPersonUseCase
{
    public async static Task<GenericResponse<PersonDTO>> Execute(IPersonRepository personRepository, GetPersonRequest request)
    {
        //validacoes aqui
        var isSuccess = true;
        var getPersonResult = await personRepository.GetPerson(request.idPerson.ToString());
        return new GenericResponse<PersonDTO>(isSuccess, getPersonResult, null);
    }
}