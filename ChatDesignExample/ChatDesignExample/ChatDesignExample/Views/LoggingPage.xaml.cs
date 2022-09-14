using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatDesignExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoggingPage : ContentPage
    {
        public LoggingPage()
        {
            InitializeComponent();
            this.BindingContext = this;

        }
        public ICommand LoginVerificationCommand => new Command(() => LoginVerification());


        void LoginVerification()
        {
            Application.Current.MainPage.Navigation.InsertPageBefore(new ChatPage(), this);
            Application.Current.MainPage.Navigation.PopAsync();
        }
        
     }
}