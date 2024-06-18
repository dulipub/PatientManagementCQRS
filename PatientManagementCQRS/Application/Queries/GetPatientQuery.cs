using MediatR;
using PatientManagementCQRS.Application.Models;

namespace PatientManagementCQRS.Application.Queries;

public record GetPatientQuery(int id) : IRequest<Patient>;