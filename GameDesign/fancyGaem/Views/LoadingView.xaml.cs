using System.Threading.Tasks;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingView : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Color upperGradientOffset;

        public Color UpperGradientOffset
        {
            get { return upperGradientOffset; }
            set
            {
                upperGradientOffset = value;
                OnPropertyChanged(nameof(UpperGradientOffset));
            }
        }

        private Color middleGradientOffset;

        public Color MiddleGradientOffset
        {
            get { return middleGradientOffset; }
            set
            {
                middleGradientOffset = value;
                OnPropertyChanged(nameof(MiddleGradientOffset));
            }
        }

        private Color lowerGradientOffset;

        public Color LowerGradientOffset
        {
            get { return lowerGradientOffset; }
            set
            {
                lowerGradientOffset = value;
                OnPropertyChanged(nameof(LowerGradientOffset));
            }
        }
        private string loadingGameState;

        public string LoadingGameState
        {
            get { return loadingGameState; }
            set { loadingGameState = value;
                OnPropertyChanged(nameof(LoadingGameState));
            }
        }

        public LoadingView()
        {
            InitializeComponent();
            this.BindingContext = this;
            UpdateBackground();
        }
        private async Task UpdateBackground()
        {
            if (parabolicSlider == null)
            {
                Console.WriteLine("parabolicSlider is not initialized.");
                return;
            }

            await foreach (var (upperRed, upperGreen, upperBlue, middleRed, middleGreen, middleBlue, lowerRed, lowerGreen, lowerBlue, isDay, daynNiteOpacity) in parabolicSlider.StartSliderAnimation())
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    UpperGradientOffset = Color.FromRgb(upperRed, upperGreen, upperBlue);
                    MiddleGradientOffset = Color.FromRgb(middleRed, middleGreen, middleBlue);
                    LowerGradientOffset = Color.FromRgb(lowerRed, lowerGreen, lowerBlue);
                    if (!isDay) {
                        Nitelbl.TextColor = Color.FromHex("#101010");
                        Nitelbl.Opacity = -daynNiteOpacity;
                    }
                    Daynlbl.Opacity = daynNiteOpacity;
                    LoadingGameState = $"Loading... {Math.Round(((loadingGameVariable + 1)/2.55),2)}%";
                    loadingGameVariable++;
                });
            }

            AnimationDone();
        }
        double loadingGameVariable = 0;
        private void AnimationDone()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                welcomeMsglbl.IsVisible = true;
                LoadingGameState += "\nTap anywhere to start!";
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) =>
                {
                        Application.Current.MainPage.Navigation.InsertPageBefore(new MenuView(), this);
                        Application.Current.MainPage.Navigation.PopAsync();
                };
                MainGrid.GestureRecognizers.Add(tapGestureRecognizer);

            });
        }
    }
}