﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PCFitnessK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigateToHyperTrophyPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.HypertrophyPage), null);
        }

        private void NavigateToPowerPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.PowerPage), null);
        }

        private void NavigateTo1RMCalc(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views._1RepMaxCalculator._1RepMaxCalculatorPage), null);
        }

    }
}
