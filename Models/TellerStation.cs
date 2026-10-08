namespace BlazorApp.Models;

public class TellerStation
{
    public string StationId { get; set; } = string.Empty; // e.g., "Teller 1", "Window 2"
    public string DepartmentCode { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}