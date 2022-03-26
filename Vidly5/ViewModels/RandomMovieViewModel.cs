using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly5.Models;

namespace Vidly5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}