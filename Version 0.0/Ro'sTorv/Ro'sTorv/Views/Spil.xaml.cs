using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Security;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ro_sTorv.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Spil : Page
    {
        ViewModel vm = new ViewModel();
        public Spil()
        {
            this.InitializeComponent();
            this.Score.Text = "1";
        }

        private void SaveScore(object sender, RoutedEventArgs e)
        {
            string username = this.username.Text;
            string userscore = this.Score.Text + ":" +"0";
            vm.SaveScore(username, userscore);
        }

        //public void AddScore()
        //{
        //    int score = Int32.Parse(Score.Text);

        //    score++;
        //}


        //public void Higher()
        //{
        //    int newNumber = NumberGenerator();
        //    int currentNum = Int32.Parse(GameNumber.Text);
        //    if (currentNum < newNumber)
        //    {
        //        AddScore();
        //    }
        //    else
        //    {
        //        Score.Text = "0";
        //    }
        //}

        //public void Lower()
        //{
        //    int newNumber = NumberGenerator();
        //    int currentNum = Int32.Parse(GameNumber.Text);
        //    if (currentNum > newNumber)
        //    {
        //        AddScore();
        //    }
        //    else
        //    {
        //        Score.Text = "0";
        //    }
        //}

        //public int NumberGenerator()
        //{
        //    Random random = new Random();
        //    return random.Next(0, 10);
        //}

        //private void SendToSave(object sender, RoutedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void SendToLower(object sender, RoutedEventArgs e)
        //{
        //    Lower();
        //}

        //private void SendToHigher(object sender, RoutedEventArgs e)
        //{
        //    Higher();
        //}
    }
}
