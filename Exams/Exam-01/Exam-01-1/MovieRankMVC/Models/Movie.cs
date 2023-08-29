﻿using System.ComponentModel.DataAnnotations;

namespace MovieRankMVC.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "The Title is required")]
    [StringLength(50)]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "The Synopsis is required")]
    [StringLength(300)]
    public string Synopsis { get; set; } = null!;

    [Required(ErrorMessage = "The Year is required")]
    public int Year { get; set; }

    [Required(ErrorMessage = "The Duration is required")]
    [StringLength(5)]
    public string Duration { get; set; } = null!;

    [Required(ErrorMessage = "The Rate is required")]
    public float Rate { get; set; }

    [Required(ErrorMessage = "The Title is required")]
    [StringLength(50)]
    public string Poster { get; set; } = null!;
    public string Genres { get; set; } = null!;

}