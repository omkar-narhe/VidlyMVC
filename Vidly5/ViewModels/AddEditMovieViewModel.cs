using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly5.Models;

namespace Vidly5.ViewModels
{
    public class AddEditMovieViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stocks")]
        [Range(1, 20, ErrorMessage = "Number in stocks should be in 1 to 20")]
        public int? NumberInStocks { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        public IEnumerable<Genre> Genre { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
        public AddEditMovieViewModel(Movies movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            DateAdded = movie.DateAdded;
            ReleaseDate = movie.ReleaseDate;
            NumberInStocks = movie.NumberInStocks;
        }
        public AddEditMovieViewModel()
        {
            Id = 0;
        }
    }
}