﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }


    //I am simply keeping this rough draft of code for personal references. 
    //public class MoviesController : Controller
    //{
    //    // GET: Movies/Random
    //    public ActionResult Random()
    //    {
    //        var movie = new Movie() { Name = "Shrek!" };
    //        var customers = new List<Customer>
    //        {
    //            new Customer {Name = "Customer 1"},
    //            new Customer {Name = "Customer 2"}
    //        };

    //        var viewModel = new RandomMovieViewModel
    //        {
    //            Movie = movie,
    //            Customers = customers

    //        };
    //        return View(viewModel);
    //    }

    //    [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]                       //Attribute routes that add constraints to the parameters.
    //    public ActionResult ByReleaseDate(int year, byte month)
    //    {
    //        return Content(year + "/" + month);
    //    }

    //    // movies
    //    public ActionResult Index(int? pageIndex, string sortBy)
    //    {
    //        if (!pageIndex.HasValue)
    //            pageIndex = 1;

    //        if (String.IsNullOrWhiteSpace(sortBy))
    //            sortBy = "Name";

    //        return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy ));
    //    }
    //} 
}