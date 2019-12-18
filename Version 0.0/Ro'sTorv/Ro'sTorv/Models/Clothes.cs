using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RosTorv.Models
{
    public class Clothes
    {
        private string _name;
        private int _before;
        private int _now;
        private string _imgPath;
        private string _modelPath;

        public Clothes(string name, int before, int now, string imgPath, string modelPath)
        {
            _name = name;
            _before = before;
            _now = now;
            _imgPath = imgPath;
            _modelPath = modelPath;


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

        public int Before
        {
            get => _before;
            set
            {
                _before = value;
                OnPropertyChanged();
            }
        }

        public int Now
        {
            get => _now;
            set
            {
                _now = value;
                OnPropertyChanged();
            }
        }

        public string imgPath
        {
            get => _imgPath;

            set
            {
                _imgPath = value;
                OnPropertyChanged();
            }
        }

        public string modelPath
        {
            get => _modelPath;

            set
            {
                _modelPath = value;
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
