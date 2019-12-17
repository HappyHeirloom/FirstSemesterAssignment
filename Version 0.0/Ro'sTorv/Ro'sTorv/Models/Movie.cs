using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;


namespace RosTorv.Models
{
    public class Movie : INotifyPropertyChanged
    {
        private string _Title;
        private string _Director;
        private string _Actors;
        private string _Length;
        private int _PG;
        private string _Path;



        public Movie(string Title, string Director, string Actors, string Length, int PG, string path)
        {
            _Title = Title;
            _Director = Director;
            _Actors = Actors;
            _Length = Length;
            _PG = PG;
            _Path = path;
        }

        public string Title
        {
            get => _Title;
            set
            {
                _Title = value;
                OnPropertyChanged();
            }
        }

        public string Director
        {
            get => _Director;
            set
            {
                _Director = value;
                OnPropertyChanged();
            }
        }

        public string Actors
        {
            get => _Actors;

            set
            {
                _Actors = value;
                OnPropertyChanged();
            }

        }

        public string Length
        {
            get => _Length;
            set
            {
                _Length = value;
                OnPropertyChanged();
            }
        }

        public int PG
        {
            get => _PG;

            set
            {
                _PG = value;
                OnPropertyChanged();
            }
        }

        public string Path
        {
            get => _Path;

            set
            {
                _Path = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return _Path;
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
