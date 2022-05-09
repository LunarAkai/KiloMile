using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KiloMile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonConvert_OnClick(object sender, RoutedEventArgs e)
        {
            float kilometer;
            float miles;

            string? textBoxKilometerText = textBoxKilometer.Text;
            string? textBoxMilesText = textBoxMile.Text;
            

            if (textBoxKilometerText == "")
            {
                miles = float.Parse(textBoxMile.Text, CultureInfo.InvariantCulture.NumberFormat);
                float kResult = ConvertMileToKilometer(miles);

                kResult = MathF.Round(kResult, 4);

                textBoxKilometer.Text = kResult.ToString();
            }

            if (textBoxMilesText == "")
            {
                kilometer = float.Parse(textBoxKilometer.Text, CultureInfo.InvariantCulture.NumberFormat);
                float mResult = ConvertKilometerToMile(kilometer);

                mResult = MathF.Round(mResult,4);
                
                textBoxMile.Text = mResult.ToString();
            }
        }

        private float ConvertMileToKilometer(float _mile)
        {
            float kilometerConversion = 1.609344f;

            float kilometerResult = _mile * kilometerConversion;
            return kilometerResult;
        }
        
        private float ConvertKilometerToMile(float _kilometer)
        {
            float mileConversion = 0.6213711f;

            float mileResult = _kilometer * mileConversion;
            return mileResult;
        }
    }
}