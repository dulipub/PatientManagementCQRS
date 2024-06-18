namespace PatientManagementCQRS.Application.Models;

public class EmergencyContact
{
    public int EmergencyContactId { get; set; }
	public int PatientId { get; set; }
	public string Name { get; set; }
    public string ContactNumber1 { get; set; }
	public string ContactNumber2 { get; set; }
	public string Email { get; set; }
    public string Address { get; set; }


    public Patient Patient { get; set; }
}