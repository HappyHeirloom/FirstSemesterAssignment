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
using RosTorv;
using RosTorv.Models;
using Spil = RosTorv.Models.Spil;

namespace Ro_sTorv
{
    public class ViewModel : INotifyPropertyChanged
    {
        Persistence persistence = new Persistence();
        private string _Name;
        private string _Score;

        public ObservableCollection<Movie> Movies { get; set; }
        readonly Movie StarwarsMovie = new Movie("Starwars The Rise of Skywalker", "J. J. Abrams", "Oscar Isaac, Daisy Ridley, Billie Lourd", "2:22", 13, "/Assets/movie1.jpg");
        readonly Movie FrozenMovie = new Movie("Frozen 2","Chris Buck, Jennifer Lee", "Kristen Bell, Idina Menzel, Josh Gad", "01:43", 7, "/Assets/movie2.jpg");
        readonly Movie GrudgeMovie = new Movie("The Grudge", "Nicolas Pesce", "John Cho, Jacki Weaver, Lin shaye, Andrea Risebprpugh, Demian Bichir, Betty Gilpin", "01:34", 13, "/Assets/movie3.jpeg");
        readonly Movie LastChristmasMovie = new Movie("Last Christmas", "Paul Feig", "Madison Ingoldsby, Emma Thompson, Boris Isakovic", "01:43", 13, "/Assets/movie4.jpg");


        public ObservableCollection<Game> Games { get; set; } 
        readonly Game breakpointGame = new Game("Ghost Recon: Breakpoint", 549, 249, "/Assets/PS4Game1.jpg");
        readonly Game fifa20Game = new Game("Fifa 2020", 549, 549, "/Assets/PS4Game2.jpg");
        readonly Game rdr2Game = new Game("Red dead redemption 2", 349, 299, "/Assets/PS4Game3.jpg");
        readonly Game codmw19Game = new Game("Call of duty: Modern Warfare", 549, 469, "/Assets/PS4Game4.jpg");


        public ObservableCollection<Clothes> Clothes { get; set; }
        readonly Clothes hoodieClothes = new Clothes("Hoodie", 299, 229, "/Assets/hm1.jpg", "/Assets/hmModel1.jpg");
        readonly Clothes nightgownClothes = new Clothes("Nightgown", 629, 329, "/Assets/hm2.jpg", "/Assets/hmModel2.jpg");
        readonly Clothes kidsHoodieClothes = new Clothes("Kids Hoodie", 249, 119, "/Assets/hm3.jpg", "/Assets/hmModel3.jpg");
        readonly Clothes dressClothes = new Clothes("Dress", 789, 569, "/Assets/hm4.jpg", "/Assets/hmModel4.jpg");


        public ObservableCollection<Highscore> Highscores { get; set; }
        readonly  Highscore number1Highscore = new Highscore();


        private Movie _SelectedMovie;
        private Game _SelectedGame;
        private Clothes _SelectedClothes;
        public static readonly DependencyProperty CurrentScoreProperty = DependencyProperty.Register("CurrentScore", typeof(object), typeof(ViewModel), new PropertyMetadata(default(object)));

        public ViewModel()
        {
            Movies = new ObservableCollection<Movie>
            {
                StarwarsMovie,
                FrozenMovie,
                GrudgeMovie,
                LastChristmasMovie
            };

            _SelectedMovie = Movies[0];

            Games = new ObservableCollection<Game>
            {
                breakpointGame,
                fifa20Game,
                rdr2Game,
                codmw19Game
            };

            _SelectedGame = Games[0];

            Highscores = new ObservableCollection<Highscore>
            {
                number1Highscore
            };

            Clothes = new ObservableCollection<Clothes>
            {
                hoodieClothes,
                nightgownClothes,
                kidsHoodieClothes,
                dressClothes
            };

            _SelectedClothes = Clothes[0];

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

        public Game SelectedGame
        {
            get => _SelectedGame;

            set
            {
                _SelectedGame = value;
                OnPropertyChanged();
            }
        }

        public Clothes SelectedClothes
        {
            get => _SelectedClothes;

            set
            {
                _SelectedClothes = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        public string Score
        {
            get => _Score;
            set
            {
                _Score = value;
                OnPropertyChanged();
            }
        }

        public void ShowScore()
        {
            persistence.LoadScore();
        }

        public void SaveScore(string name, string score)
        {
            string username = name;
            string userscore = score;

            persistence.SaveScore(username, userscore);
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
