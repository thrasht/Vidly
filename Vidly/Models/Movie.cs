using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NumberInStock { get; set; }
        [DefaultValue("getutcdate()")]
        public DateTime DateAdded { get; set; }
        public Genre Genre { get; set; }
        public short GenreId { get; set; }

    }
}