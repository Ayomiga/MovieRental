﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApp.Models;
using MovieRentalApp.ViewModels;

namespace MovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Lego Movie" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Tobi Dahunsi"},
                new Customer {Name ="Olamide Jegede"},
                new Customer {Name = "Niyi Obikoya"}
            };
            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
        };

            
            return View(ViewModel);

            //return Content("Hello World");

            //return HttpNotFound();

            //return new EmptyResult();

            //return RedirectToAction("Index", "Home", new { page =1, sortBy= "name"});
        }
        
        //movies/edit?id
        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }

        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //movies/byreleaseddate/year/month
        [Route("movies/byreleasedate/{year:regex(\\d{4})}/{month:range(1,12)}")] 
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(String.Format("Movie release month and year = {0}/{1}", month,year));
        }
    }
}