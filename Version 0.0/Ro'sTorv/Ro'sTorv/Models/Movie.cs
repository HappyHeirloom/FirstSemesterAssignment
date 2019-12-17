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
    public class Movie
    {
        private string Director_;
        private string Actors_;
        private string Length_;
        private int PG_;

        public string Director { get; set; }
        public string Actors { get; set; }
        public string Length { get; set; }
        public int PG { get; set; }

        public Movie(string Director, string Actors, string Length, int PG)
        {

            Director = Director_;
            Actors = Actors_;
            Length = Length_;
            PG = PG_;

        }
    }
}
