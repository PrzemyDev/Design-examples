using fancyGaem.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MenuView()); // for quicker debugging, UI changes with hot reload,etc.
            MainPage = new NavigationPage(new LoadingView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
