using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly5.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stocks")]
        [Range(1,20,ErrorMessage ="Number in stocks should be in 1 to 20")]
        public int NumberInStocks { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public Movies(string name, DateTime dataAdded, DateTime releaseDate, int stocks)
        {
            this.Name = name;
            this.DateAdded = dataAdded;
            this.ReleaseDate = releaseDate;
            this.NumberInStocks = stocks;
        }
        public Movies()
        {

        }
    }
}