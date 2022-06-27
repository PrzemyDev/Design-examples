using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RallyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsDetails : ContentPage
    {
        public NewsDetails(string Title, string Date, string Description, string imageSource)
        {
            InitializeComponent();

            SelectedArticle.Text = Title;
            DateCall.Text = Date;
            TitleCall.Text = Title;
            DescriptionCall.Text = Description;
            ImageCall.Source = new UriImageSource() { Uri = new Uri(imageSource) };
            
        }
    }
}