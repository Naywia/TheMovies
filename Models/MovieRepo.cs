using System.Collections.ObjectModel;
using System.IO;

namespace TheMovies.Models
{
    public class MovieRepo
    {
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>() { new Movie("General Wettendorff's evil teachings", "01:12", new List<string> { "Horror", "Comedy", "Romance", "Action" }, "Colonel Noerby", new DateTime(1986, 07, 01), DateTime.Now) };

        public MovieRepo()
        {
            using StreamReader sr = new StreamReader("../../../Models/Pr38_TheMovies.CSV");
            _ = sr.ReadLine();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                List<string> genres = new List<string>();
                foreach (string genre in lines[4].Split(','))
                {
                    genres.Add(genre);
                }
                Movie movie = new(lines[3], lines[5], genres, lines[6], DateTime.Parse(lines[7]), DateTime.Parse(lines[2]));
                _movies.Add(movie);
            }
        }
        public bool CreateMovie(string title, string runtime, List<string> genres, string producer, DateTime releasedate, DateTime showtime)
        {
            Movie newMovie = new(title, runtime, genres, producer, releasedate, showtime);
            _movies.Add(newMovie);

            // This returns if the movies exists in the list
            return GetMovie(title) != null;
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
