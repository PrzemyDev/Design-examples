using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fancyGaem.Views
{
    /// <summary>
    /// Parabolic slider is more than just a slider, but for sake of preview it is mixed!
    /// </summary>
    public class ParabolicSlider : ContentView
    {
        private Image _indicator;
        private double _sliderWidth = 255; //300 -> 255
        private double _sliderHeight = 100;
        private int indicatorImageMoveXAxis = 30;
        private int indicatorImageMoveYAxis = 30; 

        public ParabolicSlider()
        {
            var grid = new Grid
            {
                WidthRequest = _sliderWidth,
                HeightRequest = _sliderHeight,
                //BackgroundColor = Color.Transparent, 
                Margin = new Thickness(0, 100, 0, 0) 
            };

            // Add parabolic curve (symulacja przy użyciu kilku BoxView)
            for (int i = 0; i <= _sliderWidth; i += 1)
            {
                double x = i;
                double y = ComputeParabolicY(x);

                var boxView = new BoxView
                {
                    Color = Color.Gray,
                    WidthRequest = 5,
                    HeightRequest = 1.5,
                    VerticalOptions = LayoutOptions.Start,
                    HorizontalOptions = LayoutOptions.Start,
                    TranslationX = x,
                    TranslationY = _sliderHeight - y - 5 // Offset by height of the BoxView
                };

                grid.Children.Add(boxView);
            }

            _indicator = new Image
            {
                Source = "sunshine.png",
                WidthRequest = 60,
                HeightRequest = 60,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
                TranslationX = 0, 
                TranslationY = _sliderHeight - ComputeParabolicY(0) , 
                Margin = new Thickness(-indicatorImageMoveXAxis,-indicatorImageMoveYAxis,0,0) 
                /*offset for move operation */
            };
            grid.Children.Add(_indicator);

            Content = grid;

        }

        private double ComputeParabolicY(double x)
        {
            double a = -4 * _sliderHeight / (_sliderWidth * _sliderWidth); 
            return a * (x - _sliderWidth / 2) * (x - _sliderWidth / 2);
        }

        internal async IAsyncEnumerable<(byte, byte, byte, byte, byte, byte, byte, byte, byte, bool, double)> StartSliderAnimation()
        {         
            _indicator.Margin = new Thickness(-indicatorImageMoveXAxis, 0, 0, 0);
            while (_indicator.TranslationX < _sliderWidth)
            {
                var x = _indicator.TranslationX;
                x = Math.Max(0, Math.Min(x, _sliderWidth));
                var y = ComputeParabolicY(x);
                _indicator.TranslationX += 1;
                _indicator.TranslationY = _sliderHeight - y - indicatorImageMoveYAxis;
                await Task.Delay(millisecondsDelay: 1);
                daynNiteOpacity -= 0.008;
                if (_indicator.TranslationX >= (_sliderWidth - indicatorImageMoveXAxis) / 2)
                {
                    _indicator.Source = "moon.png";
                    isDay = false;
                }

                if(_indicator.TranslationX <= _sliderWidth)
                {
                    //if (upperRed > 135) upperRed -= 1;
                        if (upperRed < 135  ) upperRed += 1;
                    //if (upperGreen > 135) upperGreen -=1; 
                         if (upperGreen < 135) upperGreen += 1;
                    if (upperBlue > 135) upperBlue -= 1;
                    if (middleRed > 40) middleRed -= 1;
                    if (middleGreen > 0) middleGreen -= 1;
                    if (middleBlue > 120) middleBlue -= 1;
                    if (lowerRed > 10) lowerRed -=1;
                    if (lowerGreen > 90) lowerGreen -= 1;
                    if (lowerBlue > 10) lowerBlue -= 1;
                }

                yield return (upperRed, upperGreen, upperBlue, middleRed, middleGreen, middleBlue, lowerRed, lowerGreen, lowerBlue, isDay, daynNiteOpacity);
            }
        }
        //Colors for linear gradients in loading screen
        byte upperRed = 0;
        byte upperGreen = 167;
        byte upperBlue = 255;
        byte middleRed = 250;
        byte middleGreen = 250;
        byte middleBlue = 210;
        byte lowerRed = 20;
        byte lowerGreen = 255;
        byte lowerBlue = 68;
        bool isDay = true;
        double daynNiteOpacity = 1.25; // for 1 -0,008, slowed on purpose     
    }
}
