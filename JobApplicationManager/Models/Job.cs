using System.ComponentModel.DataAnnotations;

namespace JobApplicationManager.Models;

public class Job
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
}