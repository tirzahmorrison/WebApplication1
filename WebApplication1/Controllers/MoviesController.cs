using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : ApiController
    {
        private Context db = new Context();

        // GET: /Movies
        [Route("Movies/{genre?}")]
        [HttpGet]
        public IQueryable<Movie> GetMovies(string genre = "")
        {
            if (genre == "")
            { 
                return db.Movies;
            }
            else
            {
                return db.Movies.Where(m => m.Genre == genre); 
            }
        }
        [Route("Search")]
        [HttpGet]
        public IQueryable<Movie> SearchMovies(string title)
        {
            return db.Movies.Where(g => g.Title.Contains(title));
        }

      

        // POST: api/Movies
        [Route("Movie")]
        [HttpPost]
        [ResponseType(typeof(Movie))]
        public Movie PostMovie(Movie movie)
        { 
            db.Movies.Add(movie);
            db.SaveChanges();

            return movie;
        }

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieExists(int id)
        {
            return db.Movies.Count(e => e.ID == id) > 0;
        }
    }
}