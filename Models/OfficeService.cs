namespace BlazorApp.Models;

public class OfficeService
{
    public int ServiceId { get; set; }
    public string DepartmentCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty; // e.g., "Transcript of Records"
    public int EstimatedMinutes { get; set; } = 5;
}