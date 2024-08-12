using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public ICommand BackToMenuCommand => new Command(() => BackToMenu());
        private void BackToMenu()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            resetProgressButton.IsEnabled = !resetProgressButton.IsEnabled;
        }
    }
}