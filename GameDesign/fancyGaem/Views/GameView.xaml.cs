using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameView : ContentPage
    {
        Random randomCounter = new Random();
        string[] LowerPuns = { "Click!", "Clock!", "FIX!", "CLACK", "CLICK", "NOICE" };
        string[] UpperPuns = { "Fix!", "FIXED!", "WOW!", "FIX", "FIX!", "FIXED!" };
        //string[] HorizontalOptions = { "LayoutOptions.Start", "LayoutOptions.Center", "LayoutOptions.End" };
        internal int TotalPoints = 0;
        internal int PointsPerClick = 1;
        internal int PointsPerSecond = 1;
        internal int rippleStep = 0;

        public GameView()
        {
            
            InitializeComponent();
            this.BindingContext = this;
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                // do something every 60 seconds
                Device.BeginInvokeOnMainThread(() =>
                {
                    TotalPoints += PointsPerSecond;
                    lblScore.Text = TotalPoints.ToString();
                });
                return true; // runs again, or false to stop
            });
        }

        public ICommand BackToMenuCommand => new Command(() => BackToMenu());
        public ICommand GoToUpgradesCommand => new Command(() => GoToUpgrades());
        public ICommand PPCAreaClickedCommand => new Command(() => PPCAreaClicked());

        private void PPCAreaClicked()
        {
            TotalPoints += PointsPerClick;
            lblScore.Text = TotalPoints.ToString();
            rippleStep += 1;

            
            RandomizeRippleColors();
            TransformClickArea();
            ShowAdditionals();
            RefresherTest();
        }
        int r, g, b, X, Y;
        private void RandomizeRippleColors()
        {
            var random = new Random();
            
            r = random.Next(156);
            g = random.Next(156);
            b = random.Next(156);
            X = random.Next(5,25);
            Y = random.Next(X,X+15);
            
            frameInside.BackgroundColor = Color.FromRgb(r, g, b);

            frameMiddle.BackgroundColor = Color.FromRgb(r+X, g+X, b+X);
            
            frameOutside.BackgroundColor = Color.FromRgb(r+Y, g + Y, b + Y);

        }
        private void TransformClickArea()
        {
            imgBtnClickArea.RotationX = randomCounter.Next(-9, 9);
            imgBtnClickArea.RotationY = randomCounter.Next(-9, 9);
            imgBtnClickArea.TranslationX = randomCounter.Next(-15, 15);
            imgBtnClickArea.TranslationY = randomCounter.Next(-15, 15);
        }
        private async void ShowAdditionals()
        {
            lblUpperOne.IsVisible = true;
            lblUpperOne.Text = UpperPuns[randomCounter.Next(0, 6)];
            lblUpperOne.FontSize = randomCounter.Next(18, 23);
            var temporaryTest = randomCounter.Next(0,3);
            switch (temporaryTest)
            {
                case 0:
                    lblUpperOne.HorizontalOptions = LayoutOptions.Start;
                    break;
                case 1:
                    lblUpperOne.HorizontalOptions = LayoutOptions.Center;
                    break;
                case 2:
                    lblUpperOne.HorizontalOptions = LayoutOptions.End;
                    break;
            }
            lblUpperTwo.IsVisible = true;
            lblUpperTwo.Text = UpperPuns[randomCounter.Next(0, 6)];
            lblUpperTwo.FontSize = randomCounter.Next(16, 19);
            var temporaryTest2 = randomCounter.Next(0,3);
            switch (temporaryTest)
            {
                case 0:
                    lblUpperTwo.HorizontalOptions = LayoutOptions.Start;
                    break;
                case 1:
                    lblUpperTwo.HorizontalOptions = LayoutOptions.Center;
                    break;
                case 2:
                    lblUpperTwo.HorizontalOptions = LayoutOptions.End;
                    break;
            }
            lblUpperThree.IsVisible = true;
            lblUpperThree.Text = UpperPuns[randomCounter.Next(0, 6)];
            lblUpperThree.FontSize = randomCounter.Next(14, 17);
            var temporaryTest3 = randomCounter.Next(0,3);
            switch (temporaryTest)
            {
                case 0:
                    lblUpperThree.HorizontalOptions = LayoutOptions.Start;
                    break;
                case 1:
                    lblUpperThree.HorizontalOptions = LayoutOptions.Center;
                    break;
                case 2:
                    lblUpperThree.HorizontalOptions = LayoutOptions.End;
                    break;
            }

            lblLowerOne.IsVisible = true;
            lblLowerOne.FontSize = randomCounter.Next(16, 75);
            lblLowerOne.Text = LowerPuns[randomCounter.Next(0, 6)];
            lblLowerOne.RotationX = randomCounter.Next(-45,45);
            lblLowerOne.RotationY = randomCounter.Next(-45,45);
            lblLowerOne.TranslationX = randomCounter.Next(-15, 15);
            lblLowerOne.TranslationY = randomCounter.Next(-15, 15);
        }
        private async void RefresherTest()
        {
            //1 --ripple
            FramesRippleEffect();
            //2 --ripple
            await Task.Delay(15);
            FramesRippleEffect();
            await Task.Delay(30);
            //3 --ripple
            FramesRippleEffect();
            await Task.Delay(45);
            //4 --ripple
            FramesRippleEffect();
            await Task.Delay(60);
            //5 --ripple
            FramesRippleEffect();
            
            //the lower the shorter (wave effect), do not put into labels, keep new lines -- labels
            await Task.Delay(150);
            lblUpperThree.IsVisible = false;
            await Task.Delay(200);
            lblUpperTwo.IsVisible = false;
            await Task.Delay(300);
            lblUpperOne.IsVisible = false;
            lblLowerOne.IsVisible = false;
        }

        private void FramesRippleEffect() 
        {
            switch (rippleStep)
            {
                case 0:
                    frameInside.Opacity = 0.0;
                    frameMiddle.Opacity = 0.0;
                    frameOutside.Opacity = 0.0;
                    break;
                case 1:
                    frameInside.Opacity += 0.5;
                    frameMiddle.Opacity += 0.25;
                    rippleStep = 2;
                    break;
                case 2:
                    frameInside.Opacity -= 0.25;
                    frameMiddle.Opacity += 0.25;
                    frameOutside.Opacity += 0.25;
                    rippleStep = 3;
                    break;
                case 3:
                    frameInside.Opacity -= 0.25;
                    frameMiddle.Opacity -= 0.25;
                    frameOutside.Opacity += 0.25;
                    rippleStep = 4;
                    break;
                case 4:
                    frameMiddle.Opacity -= 0.25;
                    frameOutside.Opacity -= 0.25;
                    rippleStep = 5;
                    break;
                case 5:
                    frameOutside.Opacity = 0.0;
                    rippleStep = 0;
                    break;
                default:
                    rippleStep = 0;
                    break;
            }

        }
        private void GoToUpgrades()
        {
            Application.Current.MainPage.Navigation.PushAsync(new UpgradesView());
        }

        private void BackToMenu()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}