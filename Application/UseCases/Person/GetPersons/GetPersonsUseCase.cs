using Application.Requests;
using Application.DTOs;
using Application.Repositories;
using Application.Responses;

namespace Application.UseCases.Person;

public static class GetPersonsUseCase
{
    public async static Task<GenericResponse<IEnumerable<PersonDTO>>> Execute(IPersonRepository personRepository)
    {
        //validacoes aqui
        var isSuccess = true;
        var getPersonsResult = await personRepository.GetPersons();
        return new GenericResponse<IEnumerable<PersonDTO>>(isSuccess, getPersonsResult, null);
    }
}