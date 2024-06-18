namespace PatientManagementCQRS.Application.Models;

public class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Diagnosis { get; set; }
    public string DOB { get; set; }
	public string Email { get; set; }

    public List<EmergencyContact> Contacts { get; set; }
}