using Application.DTOs;
using Models.Domain;

namespace Application.Repositories;

public interface IPersonRepository
{
    Task<IEnumerable<PersonDTO>> GetPersons();
    Task<PersonDTO> GetPerson(string idPerson);
    Task<string> CreatePerson(PersonModel person);
}