﻿using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        public int Year { get; set; }
        public string ISBN { get; set; } = string.Empty;
    }
}