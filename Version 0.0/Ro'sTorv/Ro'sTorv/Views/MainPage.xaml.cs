using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Ro_sTorv.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ro_sTorv
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Loaded += MainPageLoaded;
        }

        // When mainpage is loaded, navigate to the log-in page
        //private void MainPageLoaded(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(LogIn));
        //}


        #region NavigationView event handlers
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {

            // Set selected element
            foreach (NavigationViewItemBase item in NavigationView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Home_Page") // If a page is named Home_Page, then navigate to it on load.
                {
                    NavigationView.SelectedItem = item; //First seleceted item is Home_Page
                    break;
                }
            }
            contentFrame.Navigate(typeof(Home));
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                contentFrame.Navigate(typeof(Settings));
            }
            else
            {
                TextBlock ItemContent = args.InvokedItem as TextBlock;
                if (ItemContent != null)
                {
                    switch (ItemContent.Tag)
                    {
                        case "Nav_Home":
                            contentFrame.Navigate(typeof(Home));
                            break;

                        case "Nav_Butik":
                            contentFrame.Navigate(typeof(Butikker));
                            break;

                        case "Nav_Event":
                            contentFrame.Navigate(typeof(Events));
                            break;

                        case "Nav_Biograf":
                            contentFrame.Navigate(typeof(Biograf));
                            break;

                        case "Nav_Parkering":
                            contentFrame.Navigate(typeof(Parkering));
                            break;

                        case "Nav_Leaderboard":
                            contentFrame.Navigate(typeof(Leaderboard));
                            break;

                        case "Nav_Spil":
                            contentFrame.Navigate(typeof(Spil));
                            break;

                        case "Nav_Center":
                            contentFrame.Navigate(typeof(Center));
                            break;

                        case "Nav_LogIn":
                            contentFrame.Navigate(typeof(LogIn));
                            break;
                    }
                }
            }

        }
        #endregion
    }
}
