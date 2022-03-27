using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly5.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public int NumberInStocks { get; set; }
        public string DateAdded { get; set; }
        public Genre Genre { get; set; }
    }
}