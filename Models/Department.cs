namespace BlazorApp.Models;

public class Department
{
    public string Code { get; set; } = string.Empty; // "REG", "FIN", "ETO"
    public string Name { get; set; } = string.Empty; // e.g., "Registrar Office"
    public List<OfficeService> Services { get; set; } = new();
    public List<TellerStation> Stations { get; set; } = new();
}