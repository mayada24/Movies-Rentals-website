using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Home_Of_Movies.Models;

namespace Home_Of_Movies.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}