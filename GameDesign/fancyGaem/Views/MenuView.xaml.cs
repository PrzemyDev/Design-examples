using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage, INotifyPropertyChanged
    {
        Random randomCounter = new Random();
        string[] descriptionQuotes = { "Better than cookie clicker!","Welcome!", "Also try Formula Clicker!", "Made by PrzemyDev :)", "Hello there!", "Time to fix sum bugzzzz" };
        public MenuView()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblMenuDescription.Text = descriptionQuotes[randomCounter.Next(0,5)];
        }
        public ICommand PlayGameCommand => new Command(() => PlayGame());
        public ICommand ExitGameCommand => new Command(() => ExitGame());
        public ICommand GoToHelpCommand => new Command(() => SwitchToHelp());
        public ICommand GoToSettingsCommand => new Command(() => SwitchToSettings());

        GameView gameView = new GameView();
        private void SwitchToSettings()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }

        private async Task PlayGame()
        {
            await Application.Current.MainPage.Navigation.PushAsync(gameView);
        }
        private async void ExitGame()
        {
            var GameAlert = await DisplayAlert("Quit", "Surely? Quit game?", "Yes", "No");
            if (GameAlert)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            
        }
        private void SwitchToHelp()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HelpView());
        }

    }
}