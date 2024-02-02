using System.Windows.Controls;
using TheMovies.ViewModels;

namespace TheMovies.Views
{
    /// <summary>
    /// Interaction logic for MovieView.xaml
    /// </summary>
    public partial class MovieView : Page
    {
        public MovieView()
        {
            InitializeComponent();
            DataContext = new MovieViewModel();
        }
    }
}
