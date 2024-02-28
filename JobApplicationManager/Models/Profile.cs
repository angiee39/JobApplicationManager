﻿using System.ComponentModel.DataAnnotations;

namespace JobApplicationManager.Models;

public class Profile
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}