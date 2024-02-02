using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class MovieViewModel
    {
        private static MovieRepo movieRepo = new MovieRepo();
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();

        public MovieViewModel()
        {
            Movies = movieRepo.GetMovies();
        }
    }
}
