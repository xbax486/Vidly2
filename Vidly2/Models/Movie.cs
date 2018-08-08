using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [ForeignKey("Genre")]
        [Display(Name = "Genre")]
        public int Genre_Id { get; set; }

        public int NumberAvailable { get; set; }
    }
}