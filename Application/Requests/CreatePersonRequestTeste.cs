using System.Text.Json.Serialization;
using Application.UseCases.Person;
using Flunt.Notifications;
using Models.Domain.Enums;

namespace Application.Requests;
public record CreatePersonRequestTeste(string Name, int Years, string Email, string Cnpj, int Status);