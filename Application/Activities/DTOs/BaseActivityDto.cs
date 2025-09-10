namespace Application.Activities.DTOs;

public class BaseActivityDto
{
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public DateTime Date { get; set; }
    public string Category { get; set; } = String.Empty;
    
    
    //location props
    public string City { get; set; } = String.Empty;
    public string Venue { get; set; } = String.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}