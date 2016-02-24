using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApp.Models {
    public class MovieRepository {

        private IList<Movie> _movies = new List<Movie>() {
                new Movie() { Title = "Star Wars", Director = "Lucas" },
                new Movie() { Title = "Alien", Director = "Scott" },
                new Movie() { Title = "Jurassic World", Director = "Spielberg" }
            };

        public IEnumerable<Movie> List() {
            return _movies;
        }

        public void Add(Movie movie) {
            _movies.Add(movie);
        }

        public Movie Find(string title) {

            Movie movie = null;
            foreach (var m in _movies) {
                if (m.Title == title) {
                    movie = m;
                    break;
                }
            }
            return movie;
        }

        public void Delete(string title) {

            _movies.Remove(Find(title));
        }
    }
}