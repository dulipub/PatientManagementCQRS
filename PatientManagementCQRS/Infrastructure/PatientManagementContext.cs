using Microsoft.EntityFrameworkCore;
using PatientManagementCQRS.Application.Models;

namespace PatientManagementCQRS.Infrastructure;

public class PatientManagementContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
	public DbSet<EmergencyContact> EmergencyContacts { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=127.0.0.1\\09731eb3804a902485ca59c80a52a8b3e40a457ffb94fcadefe49c69bebbfce5,1433;Database=PatientManagement;User Id=sa;Password=yourStrong(!)Password;TrustServerCertificate=True");
	}
}