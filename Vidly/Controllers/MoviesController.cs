using System;
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
        private List<Customer> tstCustomers = new List<Customer>
        {
            new Customer {Name = "John Smith", Id=1 },
            new Customer {Name = "Mary Williams", Id=2 }
        };

        private List<Movie> tstMovies = new List<Movie>
        {
            new Movie {Name = "Sherk!", Id = 1},
            new Movie {Name = "Wall-e", Id = 2}
        };
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return Content("Hello World!");
        }

        [Route("Movies")]
        public ActionResult Movies()
        {
            return View(tstMovies);
        }

        [Route("Customers")]
        public ActionResult Customers()
        {
            return View(tstCustomers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = tstCustomers.FirstOrDefault(x => x.Id == id); //?? new Customer() { Name="No data." };
            if (customer == null) return new HttpNotFoundResult();
            return View(customer);
        }
        //public ActionResult Edit(int id)
        //{
        //    return Content("id = "+ id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue) pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy{1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}