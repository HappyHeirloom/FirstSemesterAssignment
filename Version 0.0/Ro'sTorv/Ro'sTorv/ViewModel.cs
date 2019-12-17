using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Ro_sTorv.Views;
using RosTorv.Models;

namespace Ro_sTorv
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; set; }
        readonly Movie StarwarsMovie = new Movie("Starwars The Rise of Skywalker", "J. J. Abrams", "Oscar Isaac, Daisy Ridley, Billie Lourd", "2:22", 13, "/Assets/movie1.jpg");
        readonly Movie FrozenMovie = new Movie("Frozen 2","Chris Buck, Jennifer Lee", "Kristen Bell, Idina Menzel, Josh Gad", "01:43", 7, "/Assets/movie2.jpg");
        readonly Movie GrudgeMovie = new Movie("The Grudge", "Nicolas Pesce", "John Cho, Jacki Weaver, Lin shaye, Andrea Risebprpugh, Demian Bichir, Betty Gilpin", "01:34", 13, "/Assets/movie3.jpeg");
        readonly Movie LastChristmasMovie = new Movie("Last Christmas", "Paul Feig", "Madison Ingoldsby, Emma Thompson, Boris Isakovic", "01:43", 13, "/Assets/movie4.jpg");



        private Movie _SelectedMovie;
        public ViewModel()
        {
            Movies = new ObservableCollection<Movie>
            {
                StarwarsMovie,
                FrozenMovie,
                GrudgeMovie,
                LastChristmasMovie
            };

            _SelectedMovie = Movies[1];
        }

        public Movie SelectedMovie
        {
            get => _SelectedMovie;

            set
            {
                _SelectedMovie = value;
                OnPropertyChanged();
            }
        }


        #region INotifyPropertyChanged code
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
