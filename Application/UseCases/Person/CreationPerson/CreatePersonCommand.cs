using Application.DTOs;
using Application.Repositories;
using Application.Requests;
using Application.Responses;
using Flunt.Notifications;
using MediatR;
using Models.Domain;

namespace Application.UseCases.Person;

public record CreatePersonCommand(
    string Name, 
    int Years,
    string Email,
    string Cnpj
) : IRequest<GenericResponse<CreatePersonResponse>>;