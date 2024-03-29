﻿using System;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace RosTorv.Models
{
    public class Spil : INotifyPropertyChanged
    {
        private string _name;
        private string _score;

        public Spil(string Name, string Score)
        {
            _name = Name;
            _score = Score;
        }


        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Score
        {
            get => _score;
            set
            {
                _score = value;
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
