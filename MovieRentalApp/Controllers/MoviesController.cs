﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApp.Models;

namespace MovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Lego Movie" };
            return View(movie);

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
        //movies/byreleaseddate?year&month 
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(String.Format("Movie release month and year = {0}/{1}", month,year));
        }
    }
}