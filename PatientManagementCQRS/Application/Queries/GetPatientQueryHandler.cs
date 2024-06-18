using MediatR;
using PatientManagementCQRS.Application.Models;

namespace PatientManagementCQRS.Application.Queries;

public sealed class GetPatientQueryHandler : IRequestHandler<GetPatientQuery, Patient>
{
	public Task<Patient> Handle(GetPatientQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
