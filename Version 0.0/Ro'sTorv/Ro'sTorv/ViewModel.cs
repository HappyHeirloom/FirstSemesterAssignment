using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using RosTorv.Models;

namespace Ro_sTorv
{
    public class ViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }

        private string name_;
        public string Name { get; set; }
        public ViewModel()
        {
            Movies = new ObservableCollection<Movie>();
            Name = "Alex <3";
        }


        Movie StarwarsMovie = new Movie("J. J. Abrams", "Oscar Isaac, Daisy Ridley, Billie Lourd", "2:22", 13);

    }
}
