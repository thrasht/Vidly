using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        public DateTime? DateAdded { get; set; }
        
        [Required]
        [Display(Name = "Género de la película")]
        public short GenreId { get; set; }

        public MovieFormViewModel(Movie movie)
        {
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            DateAdded = movie.DateAdded;
            GenreId = movie.GenreId;
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
    }
}