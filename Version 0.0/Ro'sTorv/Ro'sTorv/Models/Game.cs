using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RosTorv.Models 
{
    public class Game : INotifyPropertyChanged
    {
        private string _Title;
        private int _Before;
        private int _Now;
        private string _Path;

        public Game(string Title, int Before, int Now, string path)
        {
            _Title = Title;
            _Before = Before;
            _Now = Now;
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

        public int Before
        {
            get => _Before;
            set
            {
                _Before = value;
                OnPropertyChanged();
            }
        }

        public int Now
        {
            get => _Now;
            set
            {
                _Now = value;
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

        #region INotifyPropertyChanged code
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
