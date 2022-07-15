using ChatDesignExample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatDesignExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoggingPage());

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
