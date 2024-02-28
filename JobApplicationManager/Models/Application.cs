using System.ComponentModel.DataAnnotations;

namespace JobApplicationManager.Models;

public class Application
{
    [Key]
    public int Id { get; set; }
    public int JobId { get; set; }
    public int ProfileId { get; set; }
    public bool IsApplied { get; set; }
    
}