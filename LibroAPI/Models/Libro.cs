﻿using System.ComponentModel.DataAnnotations;

namespace LibroAPI.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }
        public string? Autor { get; set; }
        public string? AnioPublicacion { get; set; }
    }
}
