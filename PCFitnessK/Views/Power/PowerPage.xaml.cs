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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PCFitnessK.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PowerPage : Page
    {
        public PowerPage()
        {
            this.InitializeComponent();
        }

        private void NavigateToPushPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Power.PushPage), null);

        }

        private void NavigateToPullPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Power.PullPage), null);

        }

        private void NavigateToLegsPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Power.LegsPage), null);

        }

        private void NavigateBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }


    }
}
