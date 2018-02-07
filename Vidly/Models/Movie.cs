using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(0, 20)]
        public int NumberInStock { get; set; }

        [Required]
        public int NumberAvailable { get; set; }

        public DateTime? DateAdded { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public short GenreId { get; set; }

    }
}