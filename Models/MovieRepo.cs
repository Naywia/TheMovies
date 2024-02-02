using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class MovieRepo
    {
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>() { new Movie("General Wettendorff's evil teachings", 82, new List<string> { "Horror", "Comedy", "Romance", "Action" }, "Colonel Noerby", new DateTime(1986, 07, 01), DateTime.Now ) };
        public bool CreateMovie(string title, int runtime, List<string> genres, string producer, DateTime releasedate, DateTime showtime)
        {
            Movie newMovie = new(title, runtime, genres, producer, releasedate, showtime);
            _movies.Add(newMovie);

            // This if statement, checks if the movies exists in the list
            if (GetMovie(title) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ObservableCollection<Movie> GetMovies() { return _movies; }

        // ? makes it able to return null
        public Movie? GetMovie(string title)
        {
            // Returns the first movie with "X" title  (Is like a for-loop)
            return _movies.Where(t => t.Title == title).FirstOrDefault();
        }
    }
}
