using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RosTorv.Models
{
    public class Highscore : INotifyPropertyChanged
    {
        Persistence persistence = new Persistence();

        private string _Name;
        private string _Score;

        public Highscore()
        {
            persistence.LoadScore();
            Name = persistence.HighscoreName;
            Score = persistence.HighscoreScore;

            _Name = Name;
            _Score = Score;
        }

        public string Name
        {
            get => persistence.HighscoreName;
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        public string Score
        {
            get => persistence.HighscoreScore;
            set
            {
                _Score = value;
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
