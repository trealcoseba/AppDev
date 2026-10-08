namespace BlazorApp.Models;

public class Student
{
    public string StudentId { get; set; } = string.Empty; // e.g., "21-1234-567"
    public string FullName { get; set; } = string.Empty;
    public bool IsPriorityEligible { get; set; } = false; // PWD, Senior, Pregnant
}