﻿using System.ComponentModel.DataAnnotations;

namespace ShoeGrabProductManagement.Dto;

public class CreateProductDto
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, double.MaxValue)]
    public double Price { get; set; }
    [Required]
    [StringLength(300)]
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
