using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpView : ContentPage
    {
        public HelpView()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public ICommand BackToMenuCommand => new Command(() => BackToMenu());
        private void BackToMenu()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
